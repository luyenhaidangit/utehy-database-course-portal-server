namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Teacher
    {
        public int? Id { get; set; }

        public Guid? UserId { get; set; }

        public string? TeacherId { get; set; }

        public virtual User User { get; set; }
    }
}
