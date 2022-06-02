using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestSalarySystem.Migrations
{
    public partial class mirage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefNo",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "IC",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefNo",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IC",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "RefNo",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "RefNo",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
