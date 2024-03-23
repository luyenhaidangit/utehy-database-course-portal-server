namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class ClassPeriod
    {
        public int Id { get; set; }
        public int NumberOfPeriod { get; set; }
        public bool IsActive { get; set; }
        public int AttendanceId { get; set; }
    }
}
