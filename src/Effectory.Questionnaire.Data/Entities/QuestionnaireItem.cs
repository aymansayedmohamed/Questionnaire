namespace Effectory.Questionnaire.Data.Entities
{
    public class QuestionnaireItem
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public Subject Subject { get; set; }
        public int QuestionnaireId { get; set; }
        public Questionnaire Questionnaire { get; set; }
    }

}
