namespace UTEHY.DatabaseCoursePortal.Api.Models.Lesson
{
    public class EditLessonRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool? IsPublished { get; set; }

        public int? CourseId { get; set; }
    }
}
