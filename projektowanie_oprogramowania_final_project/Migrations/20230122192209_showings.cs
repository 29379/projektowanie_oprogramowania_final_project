using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class showings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Rooms_ScreeningRoomRoomId",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "ScreeningRoomRoomId",
                table: "Showings",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_ScreeningRoomRoomId",
                table: "Showings",
                newName: "IX_Showings_RoomId");

            migrationBuilder.AlterColumn<int>(
                name: "ShowingId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations",
                column: "ShowingId",
                principalTable: "Showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Rooms_RoomId",
                table: "Showings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Rooms_RoomId",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Showings",
                newName: "ScreeningRoomRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_RoomId",
                table: "Showings",
                newName: "IX_Showings_ScreeningRoomRoomId");

            migrationBuilder.AlterColumn<int>(
                name: "ShowingId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations",
                column: "ShowingId",
                principalTable: "Showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Rooms_ScreeningRoomRoomId",
                table: "Showings",
                column: "ScreeningRoomRoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
