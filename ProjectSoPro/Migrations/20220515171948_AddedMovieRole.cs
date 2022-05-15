using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSoPro.Migrations
{
    public partial class AddedMovieRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Producers",
                table: "roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Directors",
                table: "roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Actors",
                table: "roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "movieRoles",
                columns: table => new
                {
                    MovieRolesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Movieid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieRoles", x => x.MovieRolesId);
                    table.ForeignKey(
                        name: "FK_movieRoles_genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "genre",
                        principalColumn: "genreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieRoles_movie_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movie",
                        principalColumn: "Movieid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movieRoles_GenreId",
                table: "movieRoles",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_movieRoles_Movieid",
                table: "movieRoles",
                column: "Movieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Producers",
                table: "roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Directors",
                table: "roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Actors",
                table: "roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
