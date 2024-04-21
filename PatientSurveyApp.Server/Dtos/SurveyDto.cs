using System.ComponentModel.DataAnnotations;

namespace PatientSurveyApp.Server.Dtos
{
    public class SurveyDto
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }

    public class SurveyResponseDto
    {
        public int SurveyId { get; set; }
        public string Email { get; set; }

        //is this right?
        public List<SurveyResponseAnswerDto> Answers { get; set; }
    }

    public class SurveyResponseAnswerDto
    {
        public int QuestionId { get; set; }

        [MaxLength(2000)]
        public string Response { get; set; }
    }
}
