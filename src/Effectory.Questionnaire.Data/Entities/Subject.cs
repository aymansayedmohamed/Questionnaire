using System.Collections.Generic;

namespace Effectory.Questionnaire.Data.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public ICollection<SubjectText> Texts { get; set; }
        public ICollection<Question> Questions { get; set; }
        public QuestionnaireItem QuestionnaireItem { get; set; }
        public int QuestionnaireItemId { get; set; }
    }

}
