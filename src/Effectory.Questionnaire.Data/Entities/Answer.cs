using System.Collections.Generic;

namespace Effectory.Questionnaire.Data.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public ICollection<AnswerText> Texts { get; set; }
        public int OrderNumber { get; set; }
        public int AnswerType { get; set; }

    }


}
