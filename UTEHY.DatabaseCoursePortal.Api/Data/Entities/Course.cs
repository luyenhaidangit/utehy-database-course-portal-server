using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Course : EntityBase
    {
        public int? Id { get; set; }
        public string? CertificateName { get; set; }
        public string? Content { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public string? LandingPage { get; set; }
        public int? Priority { get; set; }
        public int? PublishedAt { get; set; }
    }
}
