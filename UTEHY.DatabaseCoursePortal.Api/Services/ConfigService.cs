using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class ConfigService
    {
        private readonly ApplicationDbContext _dbContext;

        public ConfigService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> GetConfigValue(string key)
        {
            var value = await _dbContext.Configs.Where(x => x.Key == key).FirstOrDefaultAsync();

            return value.Value;
        }
    }
}
