using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class addresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_InstitutionAddress_AddressId",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionAddress",
                table: "InstitutionAddress");

            migrationBuilder.RenameTable(
                name: "InstitutionAddress",
                newName: "InstitutionAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShowingId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionAddresses",
                table: "InstitutionAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_InstitutionAddresses_AddressId",
                table: "Cinemas",
                column: "AddressId",
                principalTable: "InstitutionAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations",
                column: "ShowingId",
                principalTable: "Showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_InstitutionAddresses_AddressId",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionAddresses",
                table: "InstitutionAddresses");

            migrationBuilder.RenameTable(
                name: "InstitutionAddresses",
                newName: "InstitutionAddress");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShowingId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionAddress",
                table: "InstitutionAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_InstitutionAddress_AddressId",
                table: "Cinemas",
                column: "AddressId",
                principalTable: "InstitutionAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Showings_ShowingId",
                table: "Reservations",
                column: "ShowingId",
                principalTable: "Showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
