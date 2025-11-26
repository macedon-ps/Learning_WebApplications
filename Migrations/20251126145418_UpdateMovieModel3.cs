using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovieModel3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "BoxOfficeReceipts",
                table: "Movies",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOfficeReceipts", "Country", "Genre", "Price", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, 2923706026L, "США", "Sci-Fi", 11.00m, 2009, "Аватар" },
                    { 2, 2799439100L, "США", "Superhero", 12.00m, 2019, "Мстители: Конец игры" },
                    { 3, 1495696292L, "США", "Action", 11.50m, 2022, "Top Gun: Maverick" },
                    { 4, 1074458282L, "США", "Thriller/Drama", 10.50m, 2019, "Джокер" },
                    { 5, 1342359942L, "Великобритания", "Fantasy", 10.20m, 2011, "Гарри Поттер и дары смерти: Часть 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "BoxOfficeReceipts",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
