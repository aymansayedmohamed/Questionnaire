using System.Collections.Generic;

namespace Effectory.Questionnaire.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public Dictionary<string, string> Texts { get; set; }
        public List<Question> Questions { get; set; }
        public int QuestionnaireItemId { get; set; }
    }

}
