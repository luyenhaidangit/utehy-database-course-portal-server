using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class DeleteCoulumnCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CreatedBy",
                table: "Lessons",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_DeletedBy",
                table: "Lessons",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SectionId",
                table: "Lessons",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_UpdatedBy",
                table: "Lessons",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Sections_SectionId",
                table: "Lessons",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Users_CreatedBy",
                table: "Lessons",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Users_DeletedBy",
                table: "Lessons",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Users_UpdatedBy",
                table: "Lessons",
                column: "UpdatedBy",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Sections_SectionId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Users_CreatedBy",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Users_DeletedBy",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Users_UpdatedBy",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CreatedBy",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_DeletedBy",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_SectionId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_UpdatedBy",
                table: "Lessons");
        }
    }
}
