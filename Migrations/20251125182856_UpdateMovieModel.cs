using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovieModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Name");
        }
    }
}
