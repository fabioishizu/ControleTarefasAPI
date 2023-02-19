using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleProjetosAPI.Migrations
{
    /// <inheritdoc />
    public partial class TornandoFKCollaboratorIdNullable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTrackers_Tasks_tasksId",
                table: "TimeTrackers");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TimeTrackers");

            migrationBuilder.RenameColumn(
                name: "tasksId",
                table: "TimeTrackers",
                newName: "TasksId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTrackers_tasksId",
                table: "TimeTrackers",
                newName: "IX_TimeTrackers_TasksId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTrackers_Tasks_TasksId",
                table: "TimeTrackers",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTrackers_Tasks_TasksId",
                table: "TimeTrackers");

            migrationBuilder.RenameColumn(
                name: "TasksId",
                table: "TimeTrackers",
                newName: "tasksId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTrackers_TasksId",
                table: "TimeTrackers",
                newName: "IX_TimeTrackers_tasksId");

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "TimeTrackers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTrackers_Tasks_tasksId",
                table: "TimeTrackers",
                column: "tasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
