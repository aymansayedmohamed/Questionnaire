using System.Collections.Generic;

namespace Effectory.Questionnaire.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string QuestionnaireName { get; set; }
        public List<QuestionnaireItem> QuestionnaireItems { get; set; }

    }
}
