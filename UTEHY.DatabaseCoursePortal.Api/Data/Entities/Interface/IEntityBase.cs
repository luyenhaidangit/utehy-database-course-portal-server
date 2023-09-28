namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface
{
    public interface IEntityBase
    {
        public int? CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
