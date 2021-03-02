using System.Collections.Generic;

namespace Effectory.Questionnaire.Data.Entities
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string QuestionnaireName { get; set; }
        public ICollection<QuestionnaireItem> QuestionnaireItems { get; set; }

    }
}
