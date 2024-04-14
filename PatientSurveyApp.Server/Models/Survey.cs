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

    public class Question
    {
        public int Id { get; set; }

        // enum implicitly an Int
        public QuestionType Type { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }

        // does Question need links to SurveyResponseAnswers or SurveyQuestions?
    }

    public enum QuestionType
    {
        RadioButton,
        CheckBox,
        SingleLineText,
        MultiLineText,
        DropDown
    }

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
