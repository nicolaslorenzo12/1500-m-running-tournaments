using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1500_m_race_simulation.Migrations
{
    /// <inheritdoc />
    public partial class third_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Runners_Races_RaceId",
                table: "Runners");

            migrationBuilder.DropIndex(
                name: "IX_Runners_RaceId",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Runners");

            migrationBuilder.CreateTable(
                name: "RaceRunner",
                columns: table => new
                {
                    RacesId = table.Column<int>(type: "int", nullable: false),
                    RunnersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceRunner", x => new { x.RacesId, x.RunnersId });
                    table.ForeignKey(
                        name: "FK_RaceRunner_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceRunner_Runners_RunnersId",
                        column: x => x.RunnersId,
                        principalTable: "Runners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceRunner_RunnersId",
                table: "RaceRunner",
                column: "RunnersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceRunner");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Runners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runners_RaceId",
                table: "Runners",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Runners_Races_RaceId",
                table: "Runners",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");
        }
    }
}
