using Microsoft.EntityFrameworkCore.Migrations;

namespace Brainzzler.Migrations
{
    public partial class mgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.AddColumn<string>(
                name: "WrongText",
                table: "Questions",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "QuestionId",
                table: "QuestionResponse",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "QuestionId",
                table: "Answers",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<string>(
                name: "WrongText",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionResponse_QuestionId",
                table: "QuestionResponse",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionResponse_Questions_QuestionId",
                table: "QuestionResponse",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionResponse_Questions_QuestionId",
                table: "QuestionResponse");

            migrationBuilder.DropIndex(
                name: "IX_QuestionResponse_QuestionId",
                table: "QuestionResponse");

            migrationBuilder.DropColumn(
                name: "WrongText",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "WrongText",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionResponse",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "QuestionId",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
