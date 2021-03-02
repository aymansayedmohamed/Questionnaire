namespace Effectory.Questionnaire.Data.Entities
{
    public class SubjectText
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }


}
