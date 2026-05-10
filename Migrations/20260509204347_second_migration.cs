using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1500_m_race_simulation.Migrations
{
    /// <inheritdoc />
    public partial class second_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Runners_Tournaments_TournamentId",
                table: "Runners");

            migrationBuilder.DropIndex(
                name: "IX_Runners_TournamentId",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Runners");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tournaments");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Runners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runners_TournamentId",
                table: "Runners",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Runners_Tournaments_TournamentId",
                table: "Runners",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }
    }
}
