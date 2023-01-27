using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class eksperyment_reservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Seats");

            migrationBuilder.CreateTable(
                name: "ReservationSeat",
                columns: table => new
                {
                    ReservationsReservationId = table.Column<int>(type: "int", nullable: false),
                    SeatsSeatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationSeat", x => new { x.ReservationsReservationId, x.SeatsSeatId });
                    table.ForeignKey(
                        name: "FK_ReservationSeat_Reservations_ReservationsReservationId",
                        column: x => x.ReservationsReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationSeat_Seats_SeatsSeatId",
                        column: x => x.SeatsSeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSeat_SeatsSeatId",
                table: "ReservationSeat",
                column: "SeatsSeatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationSeat");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
