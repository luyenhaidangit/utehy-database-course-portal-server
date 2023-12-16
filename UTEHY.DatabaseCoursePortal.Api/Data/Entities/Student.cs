using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Student : EntityBase
    {
        public int? Id { get; set; }

        public Guid? UserId { get; set; }

        public string? StudentId { get; set; }

        public virtual User User { get; set; }
    }
}
