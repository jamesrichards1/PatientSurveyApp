using System.ComponentModel.DataAnnotations;

namespace PatientSurveyApp.Server.Models
{
    public class Question
    {
        public int Id { get; set; }

        // enum implicitly an Int
        public QuestionType Type { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }

        // does Question need links to SurveyResponseAnswers or SurveyQuestions?
    }
}
