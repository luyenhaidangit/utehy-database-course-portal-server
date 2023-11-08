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
                new Config
                {
                    Id = 2,
                    Key = "MaxBannerHome",
                    Value = "10",
                    Description = "Số lượng banner hiển thị tối đa tại trang chủ"
                },
                new Config
                {
                    Id = 3,
                    Key = "MaxPageFeatureHome",
                    Value = "10",
                    Description = "Số lượng trang tính năng hiển thị tối đa tại trang chủ"
                },
            };

            return configs;
        }
    }
}
