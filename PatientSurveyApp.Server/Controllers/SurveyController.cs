using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Survey>> GetSurveysAsync()
        {
            return await dbContext.Surveys.ToListAsync();
        }

        [HttpGet("responses/{surveyCode}")]
        public async Task<IEnumerable<SurveyResponse>> GetSurveyResponsesAsync(string surveyCode)
        {
            return await dbContext.SurveyResponses.Where(responses => responses.Survey.Code == surveyCode).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<SurveyResponse>> SendSurveyResponseAsync(SurveyResponse surveyResponse)
        {
            if (ValidateSurveyResponse(surveyResponse))
            {
                dbContext.Add(surveyResponse);
                await dbContext.SaveChangesAsync();

                return CreatedAtAction(nameof(SendSurveyResponseAsync), new { id = surveyResponse.Id}, surveyResponse);
            }
            else
            {
                // add message?
                return BadRequest();
            }
        }

        private bool ValidateSurveyResponse(SurveyResponse surveyResponse)
        {
            if (String.IsNullOrEmpty(surveyResponse.Email)) 
            {
                return false;
            }
            foreach(var answer in surveyResponse.SurveyResponseAnswers)
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
