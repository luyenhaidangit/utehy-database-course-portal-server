using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Question : EntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Feedback { get; set; }

        public int Score { get; set; }

        public Guid? UserId { get; set; }

        public int QuestionCategoryId { get; set; }

        public int Difficulty { get; set; }

        public int Type { get; set; }

        public virtual QuestionCategory QuestionCategory { get; set; }

        public virtual List<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
