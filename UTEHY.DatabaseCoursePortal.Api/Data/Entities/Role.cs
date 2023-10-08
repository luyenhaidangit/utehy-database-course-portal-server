using Microsoft.AspNetCore.Identity;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }

        public List<RolePermission> RolePermissions { get; set; }
    }
}
