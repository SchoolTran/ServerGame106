using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerGame106.Migrations
{
    /// <inheritdoc />
    public partial class OnModeCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameLevel",
                columns: new[] { "LevelID", "Description", "title" },
                values: new object[,]
                {
                    { 1, null, "Cấp độ 1" },
                    { 2, null, "Cấp độ 2" },
                    { 3, null, "Cấp độ 3" }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionID", "Answer", "ContentQuestion", "LevelID", "Option1", "Option2", "Option3", "Option4" },
                values: new object[,]
                {
                    { 1, "Đáp án 1", "Câu hỏi 1", 1, "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4" },
                    { 2, "Đáp án 2", "Câu hỏi 2", 2, "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionID", "Name" },
                values: new object[,]
                {
                    { 1, "Đồng bằng sông hồng" },
                    { 2, "Đồng bằng sông cuu long" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameLevel",
                keyColumn: "LevelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameLevel",
                keyColumn: "LevelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameLevel",
                keyColumn: "LevelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Region",
                keyColumn: "RegionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Region",
                keyColumn: "RegionID",
                keyValue: 2);
        }
    }
}
