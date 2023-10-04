using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class BannerService
    {
        private readonly ApplicationDbContext _dbContext;

        public BannerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PageResult<Banner>> Get(int? page,int? size,string? type, string? place)
        {
            var query = _dbContext.Banners.AsQueryable();

            if (!string.IsNullOrEmpty(type))
            {
                query = query.Where(b => b.Type == type);
            }

            // Kiểm tra xem place có giá trị không null trước khi thêm vào truy vấn
            if (!string.IsNullOrEmpty(place))
            {
                query = query.Where(b => b.Place == place);
            }

            int total = await query.CountAsync();

            if (page == null) page = 1;
            if (size == null) size = total;

            int totalPages = (int)Math.Ceiling((double)total / size.Value);

            var items = await query
            .OrderByDescending(b => b.Priority)
            .Skip((page.Value - 1) * size.Value)
            .Take(size.Value)
            .ToListAsync();

            var result = new PageResult<Banner>(items,page.Value,size.Value,total,totalPages);

            return result;
        }
    }
}
