using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Home;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ConfigService _configService;

        public HomeService(ApplicationDbContext dbContext, ConfigService configService)
        {
            _dbContext = dbContext;
            _configService = configService;
        }

        public async Task<List<Banner>> GetBanners(GetBannerRequest request)
        {
            var query = _dbContext.Banners.AsQueryable();

            var result = await query.Where(b => b.Type == request.Type && b.Place == request.Place && b.Expired > DateTime.UtcNow)
            .OrderByDescending(b => b.Priority).ToListAsync();

            return result;
        }

        public async Task<List<Course>> GetCourses()
        {
            var maxCourseHomeConfig = await _configService.GetConfigValue(ConfigConstant.MaxCourseHome);
            var maxCourseHome = int.Parse(maxCourseHomeConfig);

            var query = _dbContext.Courses.AsQueryable();

            var result = await query
            .OrderByDescending(b => b.Priority)
            .Take(maxCourseHome)
            .ToListAsync();

            return result;
        }
    }
}
