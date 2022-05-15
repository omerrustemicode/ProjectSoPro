using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSoPro.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    Movieid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.Movieid);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    Personid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.Personid);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    genreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movieid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.genreId);
                    table.ForeignKey(
                        name: "FK_genre_movie_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movie",
                        principalColumn: "Movieid");
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    directors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    producers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movieid = table.Column<int>(type: "int", nullable: true),
                    Personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.RolesId);
                    table.ForeignKey(
                        name: "FK_roles_movie_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movie",
                        principalColumn: "Movieid");
                    table.ForeignKey(
                        name: "FK_roles_person_Personid",
                        column: x => x.Personid,
                        principalTable: "person",
                        principalColumn: "Personid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_genre_Movieid",
                table: "genre",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_roles_Movieid",
                table: "roles",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_roles_Personid",
                table: "roles",
                column: "Personid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "genre");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "movie");

            migrationBuilder.DropTable(
                name: "person");
        }
    }
}
