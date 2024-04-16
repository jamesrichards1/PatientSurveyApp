using System.ComponentModel.DataAnnotations;

namespace PatientSurveyApp.Server.Models
{
    public class SurveyResponse
    {
        public int Id { get; set; }

        public int SurveyId { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // (navigation property) to link SurveyId 
        public Survey Survey { get; set; }

        // a Survey Response has many Answers
        public virtual ICollection<SurveyResponseAnswer> SurveyResponseAnswers { get; set; }
    }
}
