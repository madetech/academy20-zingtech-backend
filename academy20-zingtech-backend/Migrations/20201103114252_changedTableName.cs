using Microsoft.EntityFrameworkCore.Migrations;

namespace academy20_zingtech_backend.Migrations
{
    public partial class changedTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems");

            migrationBuilder.RenameTable(
                name: "TodoItems",
                newName: "EmployeeData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeData",
                table: "EmployeeData",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeData",
                table: "EmployeeData");

            migrationBuilder.RenameTable(
                name: "EmployeeData",
                newName: "TodoItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems",
                column: "Id");
        }
    }
}
