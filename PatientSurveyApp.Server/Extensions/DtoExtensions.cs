using PatientSurveyApp.Server.Dtos;
using PatientSurveyApp.Server.Models;

namespace PatientSurveyApp.Server.Extensions
{
    public static class DtoExtensions
    {
        // extension method called ToDto takes survey -> returns survey DTO 
        public static SurveyDto ToDto(this Survey survey)
        {
            return new SurveyDto
            {
                Name = survey.Name,
                Code = survey.Code,
            };
        }

        public static SurveyResponseDto ToDto(this SurveyResponse surveyResponse)
        {
            return new SurveyResponseDto
            {
                SurveyId = surveyResponse.SurveyId,
                Email = surveyResponse.Email,
                Answers = surveyResponse.SurveyResponseAnswers.Select(a => a.ToDto()).ToList(),
            };
        }

        public static SurveyResponse ToModel(this SurveyResponseDto surveyResponseDto)
        {
            return new SurveyResponse
            {
                SurveyId = surveyResponseDto.SurveyId,
                Email = surveyResponseDto.Email,
                SurveyResponseAnswers = surveyResponseDto.Answers.Select(a => a.ToModel()).ToList(),
            };
        }

        public static SurveyResponseAnswerDto ToDto(this SurveyResponseAnswer surveyResponseAnswer)
        {
            return new SurveyResponseAnswerDto
            {
                QuestionId = surveyResponseAnswer.QuestionId,
                Response = surveyResponseAnswer.Response,
            };
        }

        public static SurveyResponseAnswer ToModel(this SurveyResponseAnswerDto surveyResponseAnswer)
        {
            return new SurveyResponseAnswer
            {
                QuestionId = surveyResponseAnswer.QuestionId,
                Response = surveyResponseAnswer.Response,
            };
        }
    }
}
