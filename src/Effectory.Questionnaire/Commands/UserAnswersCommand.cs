using Effectory.Questionnaire.Models;
using MediatR;
using System.Collections.Generic;

namespace Effectory.Questionnaire.Commands
{
    public class UserAnswersCommand : IRequest
    {
        public int UserId { get; set; }
        public List<QuestionAnswer> Answers { get; set; }
    }
}
