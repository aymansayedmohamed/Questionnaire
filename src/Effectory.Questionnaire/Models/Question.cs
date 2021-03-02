using System.Collections.Generic;

namespace Effectory.Questionnaire.Models
{
    public class Question
    {

        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int OrderNumber { get; set; }
        public List<Answer> Answers { get; set; }
        public Dictionary<string, string> Texts { get; set; }

    }
}
