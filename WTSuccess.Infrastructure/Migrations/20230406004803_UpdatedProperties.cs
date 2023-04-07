using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WTSuccess.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Course_CourseId",
                table: "Chapter");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseId",
                table: "Chapter",
                type: "numeric(20,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,0)");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Course_CourseId",
                table: "Chapter",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Course_CourseId",
                table: "Chapter");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseId",
                table: "Chapter",
                type: "numeric(20,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,0)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Course_CourseId",
                table: "Chapter",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
