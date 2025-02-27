using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission08_Team0108.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskName",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskName",
                table: "Tasks");
        }
    }
}
