using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class new_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Rooms_RoomId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Films_ShowedFilmFilmId",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "ShowedFilmFilmId",
                table: "Showings",
                newName: "FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_ShowedFilmFilmId",
                table: "Showings",
                newName: "IX_Showings_FilmId");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Seats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Rooms_RoomId",
                table: "Seats",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Films_FilmId",
                table: "Showings",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Rooms_RoomId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Films_FilmId",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Showings",
                newName: "ShowedFilmFilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_FilmId",
                table: "Showings",
                newName: "IX_Showings_ShowedFilmFilmId");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Rooms_RoomId",
                table: "Seats",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Films_ShowedFilmFilmId",
                table: "Showings",
                column: "ShowedFilmFilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
