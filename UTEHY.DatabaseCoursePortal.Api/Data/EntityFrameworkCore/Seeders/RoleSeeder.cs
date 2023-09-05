using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public class RoleSeeder
    {
        public static Role Data()
        {
            return new Role
            {
                Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                Name = "admin",
                NormalizedName = "admin",
                Description = "Admin Role"
            };
        }
    }
}
