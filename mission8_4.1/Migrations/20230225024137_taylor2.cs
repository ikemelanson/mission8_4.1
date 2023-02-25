using Microsoft.EntityFrameworkCore.Migrations;

namespace mission8_4._1.Migrations
{
    public partial class taylor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 1, true, "2023-03-28", "4", "Make Dinner" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 6, 2, false, "2023-02-24", "2", "Finish Project" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 2, false, "2023-02-24", "2", "Finish Project" });
        }
    }
}
