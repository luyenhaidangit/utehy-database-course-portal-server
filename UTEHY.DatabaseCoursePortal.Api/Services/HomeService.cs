using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Course;
using UTEHY.DatabaseCoursePortal.Api.Models.Home;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ConfigService _configService;
        private readonly IMapper _mapper;

        public HomeService(ApplicationDbContext dbContext, ConfigService configService, IMapper mapper)
        {
            _dbContext = dbContext;
            _configService = configService;
            _mapper = mapper;
        }

        public async Task<List<BannerDto>> GetBanners(Models.Home.GetBannerRequest request)
        {
            var maxBannerHomeConfig = await _configService.GetConfigValue(ConfigConstant.MaxCourseHome);
            var query = _dbContext.Banners.AsQueryable();

            var banners = await query.Where(b => b.Type == request.Type && b.Place == request.Place && b.Expired > DateTime.UtcNow)
            .OrderByDescending(b => b.Priority).ToListAsync();

            var result = _mapper.Map<List<BannerDto>>(banners);

            return result;
        }

        public async Task<List<CourseDto>> GetCourses()
        {
            var maxCourseBannerConfig = await _configService.GetConfigValue(ConfigConstant.MaxCourseHome);
            var maxCourseHome = int.Parse(maxCourseBannerConfig);

            var query = _dbContext.Courses.Include(course => course.UserCourses).AsQueryable();

            var courses = await query
            .Where(b => b.IsPublished == true && b.PublishedAt < DateTime.UtcNow)
            .OrderByDescending(b => b.Priority)
            .Take(maxCourseHome)
            .ToListAsync();

            var result = _mapper.Map<List<CourseDto>>(courses);

            return result;
        }
    }
}
