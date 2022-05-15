using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSoPro.Migrations
{
    public partial class fixedGenreFk2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre");

            migrationBuilder.DropIndex(
                name: "IX_genre_Movieid",
                table: "genre");

            migrationBuilder.DropColumn(
                name: "Movieid",
                table: "genre");

            migrationBuilder.AddColumn<int>(
                name: "genreId",
                table: "movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_movie_genreId",
                table: "movie",
                column: "genreId");

            migrationBuilder.AddForeignKey(
                name: "FK_movie_genre_genreId",
                table: "movie",
                column: "genreId",
                principalTable: "genre",
                principalColumn: "genreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movie_genre_genreId",
                table: "movie");

            migrationBuilder.DropIndex(
                name: "IX_movie_genreId",
                table: "movie");

            migrationBuilder.DropColumn(
                name: "genreId",
                table: "movie");

            migrationBuilder.AddColumn<int>(
                name: "Movieid",
                table: "genre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_genre_Movieid",
                table: "genre",
                column: "Movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre",
                column: "Movieid",
                principalTable: "movie",
                principalColumn: "Movieid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
