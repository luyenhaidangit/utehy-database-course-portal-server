using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Lesson : EntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool? Status { get; set; }

        public int? Priority { get; set; }

        public int? SectionId { get; set; }

        public virtual List<LessonContent> LessonContents { get; set; }
    }
}
