using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Exam: EntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public virtual List<ExamQuestion> ExamQuestions { get; set; }
    }
}
