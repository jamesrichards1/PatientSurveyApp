namespace PatientSurveyApp.Server.Models
{
    public class SurveyQuestion
    {
        public int Id { get; set; }

        public int SurveyId { get; set; }

        public int QuestionId { get; set; }

        public bool IsMandatoryField { get; set; }

        // (navigation property) to link table Id props
        public Survey Survey { get; set; }

        public Question Question { get; set; }
    }
}
