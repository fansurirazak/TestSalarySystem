using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestSalarySystem.Migrations
{
    public partial class ipetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatchNumber",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "BatchID",
                table: "Tutor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Performance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_BatchID",
                table: "Tutor",
                column: "BatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_StudentID",
                table: "Performance",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Performance_Student_StudentID",
                table: "Performance",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Batches_BatchID",
                table: "Tutor",
                column: "BatchID",
                principalTable: "Batches",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performance_Student_StudentID",
                table: "Performance");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Batches_BatchID",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Tutor_BatchID",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Performance_StudentID",
                table: "Performance");

            migrationBuilder.DropColumn(
                name: "BatchID",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Performance");

            migrationBuilder.AddColumn<string>(
                name: "BatchNumber",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
