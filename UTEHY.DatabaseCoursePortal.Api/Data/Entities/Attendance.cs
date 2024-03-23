using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Attendance : EntityBase
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ScheduleId { get; set; }

        public List<ClassPeriod> ClassPeriods { get; set; }
    }
}
