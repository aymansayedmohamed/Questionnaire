namespace Effectory.Questionnaire.Data.Entities
{
    public class QuestionText
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }


    }


}
