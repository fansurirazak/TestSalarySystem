using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestSalarySystem.Migrations
{
    public partial class ipetime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Tutor_TutorID",
                table: "Statuses");

            migrationBuilder.AlterColumn<int>(
                name: "TutorID",
                table: "Statuses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Salary",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PayDate",
                table: "Salary",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RefNo",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Tutor_TutorID",
                table: "Statuses",
                column: "TutorID",
                principalTable: "Tutor",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Tutor_TutorID",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "PayDate",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "RefNo",
                table: "Admin");

            migrationBuilder.AlterColumn<int>(
                name: "TutorID",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Tutor_TutorID",
                table: "Statuses",
                column: "TutorID",
                principalTable: "Tutor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
