using Microsoft.EntityFrameworkCore;
using PatientSurveyApp.Server.Models;

namespace PatientSurveyApp.Server
{
    public class PatientSurveyAppDbContext : DbContext
    {
        public PatientSurveyAppDbContext(DbContextOptions<PatientSurveyAppDbContext> options) 
            : base(options) { }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }

        public DbSet<SurveyResponse> SurveyResponses { get; set; }

        public DbSet<SurveyResponseAnswer> SurveyResponsesAnswers { get; set; }
    }
}
