using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Attendence;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class AttendenceService
    {
        private readonly ApplicationDbContext _dbContext;

        public AttendenceService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Attendance> Create(CreateAttendenceRequest request)
        {
            var student = await _dbContext.Students.FindAsync(request.StudentId);
            if(student == null)
            {
                throw new ApiException("Không tìm thấy mã sinh viên hợp lệ!", HttpStatusCode.InternalServerError);
            }

            var schedule = await _dbContext.Schedules.FindAsync(request.ScheduleId);
            if(schedule == null)
            {
                throw new ApiException("Không tìm thấy lịch học nào!", HttpStatusCode.InternalServerError);
            }

            var attendence = new Attendance
            {
                StudentId = request.StudentId,
                ScheduleId = request.ScheduleId,
            };
            await _dbContext.Attendances.AddAsync(attendence);
            await _dbContext.SaveChangesAsync();

            foreach(var item in request.classPeriodRequests)
            {
                var classPeriod = new ClassPeriod
                {
                    NumberOfPeriod = item.NumberOfPeriod,
                    IsActive = item.IsActive,
                    AttendanceId = attendence.Id
                };
                await _dbContext.ClassPeriods.AddAsync(classPeriod);

            }
            await _dbContext.SaveChangesAsync();

            return attendence;
        }

        public async Task<PagingResult<Attendance>> Get(GetAttendenceRequest request)
        {
            try
            {
                var query = _dbContext.Attendances.Where(x => x.DeletedAt == null).AsQueryable();

                if (request.ScheduleId != null)
                {
                    query = query.Where(x => x.ScheduleId == request.ScheduleId);
                }
                if (request.StudentId != null)
                {
                    query = query.Where(x => x.StudentId == request.StudentId);
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

                var result = new PagingResult<Attendance>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }


    }
}
