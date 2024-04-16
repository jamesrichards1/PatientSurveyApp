using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientSurveyApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Type", "Text" },
                values: new object[,]
                {
                    { 0, "This is an example radio button question" },
                    { 1, "This is an example checkbox question" },
                    { 2, "This is an example text question" },
                    { 3, "This is an example dropdown question"}
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
