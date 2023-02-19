using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleProjetosAPI.Migrations
{
    /// <inheritdoc />
    public partial class TornandoFKCollaboratorIdNullable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTrackers_Collaborators_collaboratorsId",
                table: "TimeTrackers");

            migrationBuilder.DropColumn(
                name: "CollaboratorId",
                table: "TimeTrackers");

            migrationBuilder.RenameColumn(
                name: "collaboratorsId",
                table: "TimeTrackers",
                newName: "CollaboratorsId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTrackers_collaboratorsId",
                table: "TimeTrackers",
                newName: "IX_TimeTrackers_CollaboratorsId");

            migrationBuilder.AlterColumn<int>(
                name: "CollaboratorsId",
                table: "TimeTrackers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTrackers_Collaborators_CollaboratorsId",
                table: "TimeTrackers",
                column: "CollaboratorsId",
                principalTable: "Collaborators",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTrackers_Collaborators_CollaboratorsId",
                table: "TimeTrackers");

            migrationBuilder.RenameColumn(
                name: "CollaboratorsId",
                table: "TimeTrackers",
                newName: "collaboratorsId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTrackers_CollaboratorsId",
                table: "TimeTrackers",
                newName: "IX_TimeTrackers_collaboratorsId");

            migrationBuilder.AlterColumn<int>(
                name: "collaboratorsId",
                table: "TimeTrackers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollaboratorId",
                table: "TimeTrackers",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTrackers_Collaborators_collaboratorsId",
                table: "TimeTrackers",
                column: "collaboratorsId",
                principalTable: "Collaborators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
