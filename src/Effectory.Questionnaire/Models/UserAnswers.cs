using System.Collections.Generic;

namespace Effectory.Questionnaire.Models
{
    public class UserAnswers
    {
        public int UserId { get; set; }
        public List<QuestionAnswer> Answers { get; set; }
    }
}
