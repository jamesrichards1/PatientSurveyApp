using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientSurveyApp.Server.Dtos;
using PatientSurveyApp.Server.Extensions;
using PatientSurveyApp.Server.Models;

namespace PatientSurveyApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurveyController 
        : ControllerBase
    {
        private readonly PatientSurveyAppDbContext dbContext;

        public SurveyController(PatientSurveyAppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IEnumerable<SurveyDto>> GetSurveysAsync()
        {
            var surveys = await dbContext.Surveys.ToListAsync();
            return surveys.Select(s => s.ToDto());
        }

        [HttpGet("responses/{surveyCode}")]
        public async Task<IEnumerable<SurveyResponseDto>> GetSurveyResponsesAsync(string surveyCode)
        {
            var surveyResponses = await dbContext.SurveyResponses
                .Where(responses => responses.Survey.Code == surveyCode)
                .ToListAsync();

            return surveyResponses.Select(response => response.ToDto());
        }

        [HttpPost]
        public async Task<IActionResult> SendSurveyResponseAsync(SurveyResponseDto surveyResponse)
        {
            if (ValidateSurveyResponse(surveyResponse))
            {
                var surveyResponseModel = surveyResponse.ToModel();
                dbContext.Add(surveyResponseModel);
                await dbContext.SaveChangesAsync();

                return Ok();
            }
            else
            {
                // add message?
                return BadRequest();
            }
        }

        private bool ValidateSurveyResponse(SurveyResponseDto surveyResponse)
        {
            if (String.IsNullOrEmpty(surveyResponse.Email)) 
            {
                return false;
            }
            foreach(var answer in surveyResponse.Answers)
            {
                if(answer.Response.Length > 2000)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
