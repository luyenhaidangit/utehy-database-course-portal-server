using Microsoft.AspNetCore.Identity;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        #region Relationship
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
        #endregion
    }
}
