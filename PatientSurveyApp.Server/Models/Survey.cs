using System.ComponentModel.DataAnnotations;

namespace PatientSurveyApp.Server.Models
{
    public class Survey
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(32)]
        public string Code { get; set; }

        // a survey has many responses / questions
        public virtual ICollection<SurveyResponse> SurveyResponses { get; set; }

        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
