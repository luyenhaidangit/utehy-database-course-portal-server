namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Teacher
    {
        public int? Id { get; set; }

        public Guid? UserId { get; set; }

        public User User { get; set; }
    }
}
