using System.ComponentModel.DataAnnotations.Schema;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Comment : EntityBase
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TypeCommentable { get; set; }
        public int CommentsCount { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsApproved { get; set; }
        public bool IsReacted { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsVoted { get; set; }
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public int VotersCount { get; set; }

        public virtual User User { get; set; }

    }
}
