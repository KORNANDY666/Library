using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 1,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 2,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 3,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 4,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 5,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 6,
                column: "Barrowed",
                value: new DateTime(2023, 5, 10, 13, 14, 6, 555, DateTimeKind.Local).AddTicks(8154));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 1,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 2,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 3,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 4,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 5,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "BookConnections",
                keyColumn: "BookConnectionId",
                keyValue: 6,
                column: "Barrowed",
                value: new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2522));
        }
    }
}
