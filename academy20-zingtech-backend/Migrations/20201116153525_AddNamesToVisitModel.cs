using Microsoft.EntityFrameworkCore.Migrations;

namespace academy20_zingtech_backend.Migrations
{
    public partial class AddNamesToVisitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "VisitData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "VisitData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "VisitData");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "VisitData");
        }
    }
}
