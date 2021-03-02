using System.Collections.Generic;

namespace Effectory.Questionnaire.Data.Entities
{
    public class Question
    {

        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int OrderNumber { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<QuestionText> Texts { get; set; }

    }
}
