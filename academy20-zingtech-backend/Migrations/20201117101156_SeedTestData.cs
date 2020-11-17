using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace academy20_zingtech_backend.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VisitData",
                columns: new[]
                {
                    "Host", "FirstName", "LastName", "StartDatetime", "EndDatetime", "Email", "MobileNumber",
                    "OfficeLocation", "Purpose", "Notes"
                },
                values: new object[]
                {
                    2, "Andrew", "Anderson", new DateTime(2025, 11, 16, 16, 21, 00),
                    new DateTime(2025, 11, 16, 17, 21, 00), "07845624178", "andrew.anderson@ibm.com", "Bristol",
                    "Sales pitch", ""
                });

            migrationBuilder.InsertData(
                table: "VisitData",
                columns: new[]
                {
                    "Host", "FirstName", "LastName", "StartDatetime", "EndDatetime", "Email", "MobileNumber",
                    "OfficeLocation", "Purpose", "Notes"
                },
                values: new object[]
                {
                    3, "Sarah", "Sarahson", new DateTime(2025, 11, 16, 16, 21, 00),
                    new DateTime(2025, 11, 16, 17, 21, 00), "07463827950", "ssarahson@google.com", "London",
                    "Client meeting", "Arriving by taxi"
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
