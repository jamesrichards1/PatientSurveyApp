using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientSurveyApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Name", "Code" },
                values: new object[,]
                {
                    { 1, "Test Survey 1", "TS1" },
                    { 2, "Test Survey 2", "TS2" },
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
