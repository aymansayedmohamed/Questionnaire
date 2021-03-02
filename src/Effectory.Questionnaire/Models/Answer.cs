using System.Collections.Generic;

namespace Effectory.Questionnaire.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Dictionary<string, string> Texts { get; set; }
        public int OrderNumber { get; set; }
        public int AnswerType { get; set; }

    }


}
