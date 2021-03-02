using Effectory.Questionnaire.Data;
using Effectory.Questionnaire.Queries;
using Effectory.Questionnaire.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Effectory.Questionnaire.Handlers
{
    public class QuestionsHandler : IRequestHandler<QuestionsQuery, QuestionsResponseModel>
    {
        private readonly DbContextQuestionnaire _dbContext;

        public QuestionsHandler(DbContextQuestionnaire dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<QuestionsResponseModel> Handle(QuestionsQuery request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var questions = _dbContext.Questions
                                            .Include(q => q.Texts)
                                            .Include(q => q.Answers)
                                            .ThenInclude(s => s.Texts)
                                            .OrderBy(q => q.OrderNumber).AsNoTracking()
                                            .Skip(request.pageSize * (request.pageNumber - 1))
                                            .Take(request.pageSize).ToList();

            var respone = new QuestionsResponseModel();

            respone.Questions = questions?.Select(q => new Models.Question()
            {
                Id = q.Id,
                OrderNumber = q.OrderNumber,
                SubjectId = q.SubjectId,
                Texts = q.Texts?.Select(p => new { p.Code, p.Value }).ToDictionary(kvp => kvp.Code, kvp => kvp.Value),
                Answers = q.Answers?.OrderBy(a => a.OrderNumber).Select(a => new Models.Answer()
                {
                    Id = a.Id,
                    AnswerType = a.AnswerType,
                    OrderNumber = a.OrderNumber,
                    QuestionId = a.QuestionId,
                    Texts = a.Texts?.Select(p => new { p.Code, p.Value }).ToDictionary(kvp => kvp.Code, kvp => kvp.Value)
                }).ToList()
            }).ToArray();

            return respone;

        }
    }
}
