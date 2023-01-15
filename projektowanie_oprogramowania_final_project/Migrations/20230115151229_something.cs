using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_InstitutionAddresses_AddressId",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "InstitutionAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_AddressId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Cinemas");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Cinemas");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Cinemas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InstitutionAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionAddresses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_AddressId",
                table: "Cinemas",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_InstitutionAddresses_AddressId",
                table: "Cinemas",
                column: "AddressId",
                principalTable: "InstitutionAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Cinemas_CinemaId",
                table: "Rooms",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
