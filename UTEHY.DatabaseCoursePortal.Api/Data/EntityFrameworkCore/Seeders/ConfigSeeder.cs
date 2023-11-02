using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public class ConfigSeeder
    {
        public static List<Config> Data()
        {
            var configs = new List<Config>()
            {
                new Config
                {
                    Id = 1,
                    Key = "MaxCourseHome",
                    Value = "20",
                    Description = "Số lượng khoá học hiển thị tối đa tại trang chủ"
                },
            };

            return configs;
        }
    }
}
