using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Schedule;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class ScheduleService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ScheduleService(IMapper mapper, ApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<PagingResult<Schedule>> Get(GetScheduleRequest request)
        {
            try
            {
                var query = _dbContext.Schedules.Where(x => x.DeletedAt == null).AsQueryable();

                if (!string.IsNullOrEmpty(request.GroupModuleName))
                {
                    query = query.Where(x => x.GroupModule.Name.ToLower().Contains(request.GroupModuleName));
                }

                if(request.GroupModuleId != null)
                {
                    query = query.Where(x => x.GroupModuleId == request.GroupModuleId);
                }

                int total = await query.CountAsync();

                if (request.PageIndex == null) request.PageIndex = 1;
                if (request.PageSize == null) request.PageSize = total;

                int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

                if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else if (string.IsNullOrEmpty(request.OrderBy))
                {
                    if (request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }
                else if (string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else
                {
                    if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }

                var items = await query
                    .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                    .Take(request.PageSize.Value)
                    .ToListAsync();

                var result = new PagingResult<Schedule>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Schedule> Create(CreateScheduleRequest request)
        {
            try
            {
                var groupModule = await _dbContext.GroupModules.FindAsync(request.GroupModuleId);
                if (groupModule == null)
                {
                    throw new ApiException("Mã lớp không tồn tại trong hệ thống!", HttpStatusCode.InternalServerError);
                }

                // create schedule
                var scheduleCreate = new Schedule
                {
                    GroupModuleId = request.GroupModuleId,
                    ClassPeriods = request.ClassPeriods,
                    DateSchool = request.DateSchool,
                };

                await _dbContext.Schedules.AddAsync(scheduleCreate);
                await _dbContext.SaveChangesAsync();

                return scheduleCreate;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
