namespace UTEHY.DatabaseCoursePortal.Api.Models.Attendence
{
    public class CreateAttendenceRequest
    {
        public int StudentId { get; set; }
        public int ScheduleId { get; set; }
        public List<CreateClassPeriodRequest> classPeriodRequests { get; set; }
    }

    public class CreateClassPeriodRequest
    {
        public int NumberOfPeriod { get; set; }
        public bool IsActive { get; set; }
    }
}
