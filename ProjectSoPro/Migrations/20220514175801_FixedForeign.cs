using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSoPro.Migrations
{
    public partial class FixedForeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre");

            migrationBuilder.DropForeignKey(
                name: "FK_roles_movie_Movieid",
                table: "roles");

            migrationBuilder.DropForeignKey(
                name: "FK_roles_person_Personid",
                table: "roles");

            migrationBuilder.RenameColumn(
                name: "producers",
                table: "roles",
                newName: "Producers");

            migrationBuilder.RenameColumn(
                name: "directors",
                table: "roles",
                newName: "Directors");

            migrationBuilder.RenameColumn(
                name: "actors",
                table: "roles",
                newName: "Actors");

            migrationBuilder.AlterColumn<int>(
                name: "Personid",
                table: "roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Movieid",
                table: "roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "surname",
                table: "person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Movieid",
                table: "genre",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre",
                column: "Movieid",
                principalTable: "movie",
                principalColumn: "Movieid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roles_movie_Movieid",
                table: "roles",
                column: "Movieid",
                principalTable: "movie",
                principalColumn: "Movieid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roles_person_Personid",
                table: "roles",
                column: "Personid",
                principalTable: "person",
                principalColumn: "Personid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre");

            migrationBuilder.DropForeignKey(
                name: "FK_roles_movie_Movieid",
                table: "roles");

            migrationBuilder.DropForeignKey(
                name: "FK_roles_person_Personid",
                table: "roles");

            migrationBuilder.RenameColumn(
                name: "Producers",
                table: "roles",
                newName: "producers");

            migrationBuilder.RenameColumn(
                name: "Directors",
                table: "roles",
                newName: "directors");

            migrationBuilder.RenameColumn(
                name: "Actors",
                table: "roles",
                newName: "actors");

            migrationBuilder.AlterColumn<int>(
                name: "Personid",
                table: "roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Movieid",
                table: "roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "surname",
                table: "person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Movieid",
                table: "genre",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_genre_movie_Movieid",
                table: "genre",
                column: "Movieid",
                principalTable: "movie",
                principalColumn: "Movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_roles_movie_Movieid",
                table: "roles",
                column: "Movieid",
                principalTable: "movie",
                principalColumn: "Movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_roles_person_Personid",
                table: "roles",
                column: "Personid",
                principalTable: "person",
                principalColumn: "Personid");
        }
    }
}
