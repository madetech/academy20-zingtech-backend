using Microsoft.EntityFrameworkCore.Migrations;

namespace academy20_zingtech_backend.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VisitData",
                columns: new[] { "Id", "Host", "FirstName", "LastName", "StartDatetime", "EndDatetime", "Email", "MobileNumber", "OfficeLocation", "Purpose", "Notes" },
                values: new object[] { 1, 2, "Andrew", "Anderson", "2025-11-16T14:16:21+00:00", "2025-11-16T15:16:21+00:00", "07845624178", "andrew.anderson@ibm.com", "Bristol", "Sales pitch", "" });

            migrationBuilder.InsertData(
                table: "VisitData",
                columns: new[] { "Id", "Host", "FirstName", "LastName", "StartDatetime", "EndDatetime", "Email", "MobileNumber", "OfficeLocation", "Purpose", "Notes" },
                values: new object[] { 1, 2, "Sarah", "Sarahson", "2025-11-18T09:16:21+00:00", "2025-11-18T15:16:21+00:00", "07463827950", "ssarahson@google.com", "London", "Client meeting", "Arriving by taxi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
