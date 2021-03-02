using Effectory.Questionnaire.Commands;
using Effectory.Questionnaire.Models;
using Effectory.Questionnaire.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Effectory.Questionnaire.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<QuestionnaireController> _logger;


        public QuestionnaireController(IMediator mediator, ILogger<QuestionnaireController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [ActionName("Questions")]
        public async Task<ActionResult<Question[]>> Get(int pageNumber = 1, int pageSize = 10)

        {
            try
            {
                var questionsQuery = new QuestionsQuery() { pageNumber = pageNumber, pageSize = pageSize };

                var result = await _mediator.Send(questionsQuery);
                return result.Questions;
            }
            catch (Exception ex)
            {
                _logger.LogError($"an error occured during retrieve the Question ", ex);
                return null;
            }
        }

        [HttpPost]
        [ActionName("UserAnswers")]
        public async Task<ActionResult<bool>> UserAnswers(UserAnswers answers)

        {
            try
            {
                var result = await _mediator.Send(new UserAnswersCommand() { UserId = answers.UserId, Answers = answers.Answers });
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"an error occured during saving the user Answers ", ex);
                return false;
            }
        }

    }
}
