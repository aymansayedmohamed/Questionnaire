using Effectory.Questionnaire.Commands;
using Effectory.Questionnaire.Data;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Effectory.Questionnaire.Handlers
{
    public class UserAnswersCommandHandler : AsyncRequestHandler<UserAnswersCommand>
    {
        private readonly DbContextQuestionnaire _dbContext;
        private readonly ILogger<UserAnswersCommandHandler> _logger;

        public UserAnswersCommandHandler(DbContextQuestionnaire dbContext, ILogger<UserAnswersCommandHandler> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        protected override async Task Handle(UserAnswersCommand request, CancellationToken cancellationToken)
        {

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in request.Answers)
                    {
                        _dbContext.UserAnswers.Add(new Data.Entities.UserAnswer()
                        {
                            UserId = request.UserId,
                            AnswerId = item.AnswerId,
                            QuestionId = item.QuestionId
                        });
                    }
                    _ = _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    _logger.LogError($"an error occurred during saving the answers to the DB", ex);
                    transaction.Rollback();
                }
            }

        }
    }
}
