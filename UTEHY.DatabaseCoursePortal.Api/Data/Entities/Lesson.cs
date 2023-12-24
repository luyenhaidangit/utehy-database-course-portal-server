using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Lesson : EntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool? IsPublished { get; set; }
    }
}
