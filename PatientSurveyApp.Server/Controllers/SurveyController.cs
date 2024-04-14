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
    }
}
