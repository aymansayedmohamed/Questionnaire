namespace Effectory.Questionnaire.Data.Entities
{
    public class AnswerText
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }


    }


}
