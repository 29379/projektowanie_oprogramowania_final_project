using Microsoft.EntityFrameworkCore.Migrations;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    public partial class reservation_seat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationSeat");

            migrationBuilder.CreateTable(
                name: "ReservationSeats",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationSeats", x => new { x.ReservationId, x.SeatId });
                    table.ForeignKey(
                        name: "FK_ReservationSeats_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationSeats_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSeats_SeatId",
                table: "ReservationSeats",
                column: "SeatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationSeats");

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
    }
}
