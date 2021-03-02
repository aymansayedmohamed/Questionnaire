using Effectory.Questionnaire.Responses;
using MediatR;

namespace Effectory.Questionnaire.Queries
{
    public class QuestionsQuery : IRequest<QuestionsResponseModel>
    {
        public int pageNumber { get; set; }
        public int pageSize { get; set; }

    }
}
