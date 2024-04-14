using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PatientSurveyApp.Server
{
    public class PatientSurveyAppDbContextFactory : IDesignTimeDbContextFactory<PatientSurveyAppDbContext>
    {
        public PatientSurveyAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PatientSurveyAppDbContext>();
            optionsBuilder.UseSqlServer("Server=James-PC\\JRDEVSQL;Database=PatientSurveyApp;Trusted_Connection=True;TrustServerCertificate=True;");

            return new PatientSurveyAppDbContext(optionsBuilder.Options);
        }
    }
}
