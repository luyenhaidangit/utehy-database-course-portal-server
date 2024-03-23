namespace UTEHY.DatabaseCoursePortal.Api.Models.Schedule
{
    public class CreateScheduleRequest
    {
        public int GroupModuleId { get; set; }
        public string? ClassPeriods { get; set; }
        public DateTime DateSchool { get; set; }
    }
}
