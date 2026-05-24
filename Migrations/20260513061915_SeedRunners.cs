using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace running_race_simulation.Migrations
{
    /// <inheritdoc />
    public partial class SeedRunners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Runners",
                columns: new[] { "Id", "Name", "Ranking" },
                values: new object[,]
                {
                    { 1, "Jakob Ingebrigtsen", 1 },
                    { 2, "Josh Kerr", 2 },
                    { 3, "Yared Nuguse", 3 },
                    { 4, "Cole Hocker", 4 },
                    { 5, "Narve Gilje Nordas", 5 },
                    { 6, "Timothy Cheruiyot", 6 },
                    { 7, "Abel Kipsang", 7 },
                    { 8, "Neil Gourley", 8 },
                    { 9, "Stewart McSweyn", 9 },
                    { 10, "Oliver Hoare", 10 },
                    { 11, "Samuel Tefera", 11 },
                    { 12, "Azeddine Habz", 12 },
                    { 13, "Isaac Nader", 13 },
                    { 14, "Mohamed Katir", 14 },
                    { 15, "Reynold Cheruiyot", 15 },
                    { 16, "George Mills", 16 },
                    { 17, "Mario García", 17 },
                    { 18, "Adel Mechaal", 18 },
                    { 19, "Pietro Arese", 19 },
                    { 20, "Marcin Lewandowski", 20 },
                    { 21, "Henrik Ingebrigtsen", 21 },
                    { 22, "Filip Ingebrigtsen", 22 },
                    { 23, "Jake Wightman", 23 },
                    { 24, "Hobbs Kessler", 24 },
                    { 25, "Vincent Ciattei", 25 },
                    { 26, "Elliot Giles", 26 },
                    { 27, "Robert Farken", 27 },
                    { 28, "Kieran Lumb", 28 },
                    { 29, "Cameron Myers", 29 },
                    { 30, "Paddy Dever", 30 },
                    { 31, "Luke Houser", 31 },
                    { 32, "Eric Holt", 32 },
                    { 33, "Ben Pattison", 33 },
                    { 34, "Ayanleh Souleiman", 34 },
                    { 35, "Ronald Kwemoi", 35 },
                    { 36, "Silas Kiplagat", 36 },
                    { 37, "Elijah Manangoi", 37 },
                    { 38, "Asbel Kiprop", 38 },
                    { 39, "Taoufik Makhloufi", 39 },
                    { 40, "Matthew Centrowitz", 40 },
                    { 41, "Nick Willis", 41 },
                    { 42, "Bernard Lagat", 42 },
                    { 43, "Mo Farah", 43 },
                    { 44, "James Webb", 44 },
                    { 45, "Daniel Komen", 45 },
                    { 46, "Noah Ngeny", 46 },
                    { 47, "Hicham El Guerrouj", 47 },
                    { 48, "Noureddine Morceli", 48 },
                    { 49, "Sebastian Coe", 49 },
                    { 50, "Steve Ovett", 50 },
                    { 51, "Steve Cram", 51 },
                    { 52, "Said Aouita", 52 },
                    { 53, "Fermín Cacho", 53 },
                    { 54, "Mehdi Baala", 54 },
                    { 55, "Augustine Choge", 55 },
                    { 56, "Mekonnen Gebremedhin", 56 },
                    { 57, "Lopez Lomong", 57 },
                    { 58, "Chris O'Hare", 58 },
                    { 59, "Andrew Wheating", 59 },
                    { 60, "Leo Manzano", 60 },
                    { 61, "Nick Symmonds", 61 },
                    { 62, "Andrés Díaz", 62 },
                    { 63, "Brahim Boulami", 63 },
                    { 64, "Yusuf Saad Kamel", 64 },
                    { 65, "Harun Keitany", 65 },
                    { 66, "Soufiane El Bakkali", 66 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Runners",
                keyColumn: "Id",
                keyValue: 66);
        }
    }
}
