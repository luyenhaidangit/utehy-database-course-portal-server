using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Reaction : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public int TypeReactable { get; set; }
        public string Type { get; set; }
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
