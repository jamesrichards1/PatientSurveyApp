using System.ComponentModel.DataAnnotations;

namespace PatientSurveyApp.Server.Models
{
    public class SurveyResponseAnswer
    {
        public int Id { get; set; }

        public int SurveyResponseId { get; set; }

        public int QuestionId { get; set; }

        [MaxLength(2000)]
        public string Response { get; set; }

        // (navigation property) to link table Id props
        public SurveyResponse SurveyResponse { get; set; }

        public Question Question { get; set; }
    }
}
