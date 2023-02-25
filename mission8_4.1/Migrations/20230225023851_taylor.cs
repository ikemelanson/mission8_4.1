using Microsoft.EntityFrameworkCore.Migrations;

namespace mission8_4._1.Migrations
{
    public partial class taylor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "DueDate", "Quadrant" },
                values: new object[] { "2023-02-25", "3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, "2023-03-06", "2", "Practice Presentation" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, 4, false, "2023-02-26", "1", "Write Talk" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 4, 1, false, "2023-02-28", "4", "Yeet" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 5, 2, false, "2023-02-24", "2", "Finish Project" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "DueDate", "Quadrant" },
                values: new object[] { "2023-02-26", "1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "Task" },
                values: new object[] { 4, "2023-02-24", "4", "Finish Project" });
        }
    }
}
