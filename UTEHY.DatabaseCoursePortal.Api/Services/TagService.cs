using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Enums;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Mail;
using UTEHY.DatabaseCoursePortal.Api.Models.Question;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Models.Tag;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Models.User;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class TagService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public TagService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Tag>?> Get(GetTagRequestcs request)
        {
            var tags = await _dbContext.Tags
            .Where(x => (request.Type == null || x.Type == request.Type) && (request.Name == null || x.Name.ToLower().Contains(request.Name.ToLower())))
            .ToListAsync();

            return tags;
        }

        public async Task<Tag> Create(CreateTagRequest request)
        {
            try
            {
                var existingTag = _dbContext.Tags.FirstOrDefault(x => x.Name.Trim().ToLower() == request.Name.Trim().ToLower());

                if(existingTag != null) 
                {
                    throw new ApiException("Tồn tại thẻ tag, vui lòng chọn tên khác!", HttpStatusCode.InternalServerError);
                }

                var tag = _mapper.Map<Tag>(request);

                _dbContext.Tags.Add(tag);
                await _dbContext.SaveChangesAsync();

                return tag;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
    }   
}
