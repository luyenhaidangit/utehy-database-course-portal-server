using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Home;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Banner>> GetBanners(GetBannerRequest request)
        {
            var query = _dbContext.Banners.AsQueryable();

            var result = await query.Where(b => b.Type == request.Type && b.Place == request.Place && b.Expired > DateTime.UtcNow)
            .OrderByDescending(b => b.Priority).ToListAsync();

            return result;
        }
    }
}
