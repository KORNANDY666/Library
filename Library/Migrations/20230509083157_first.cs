using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNr = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "BookConnections",
                columns: table => new
                {
                    BookConnectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CustomerId = table.Column<int>(type: "int", nullable: false),
                    FK_BookId = table.Column<int>(type: "int", nullable: false),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    Barrowed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookConnections", x => x.BookConnectionId);
                    table.ForeignKey(
                        name: "FK_BookConnections_Book_FK_BookId",
                        column: x => x.FK_BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookConnections_Customer_FK_CustomerId",
                        column: x => x.FK_CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "Title" },
                values: new object[,]
                {
                    { 1, " Reidar Nilsen", "Code like a Pro" },
                    { 2, "Albert Einstein", "Fishing at night" },
                    { 3, "Stina Stinasson", "Murderer at the hospital" },
                    { 4, "Tony Tonysson", "Face to face" },
                    { 5, "My Mysson", "From dusk till dawn" },
                    { 6, "Mårten Mårtesson", "Run away" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "Name", "PhoneNr", "PostCode" },
                values: new object[,]
                {
                    { 1, "Greger Vägen 10", "Gregerstad", "Greger Gregersson", "1234567890", "12345" },
                    { 2, "Lena Vägen 99", "Lenastad", "Lena Lenasson", "9876543210", "12346" },
                    { 3, "Stenvägen 66", "Stenstad", "Sten Stensson", "19834563214", "23456" },
                    { 4, "Sivvägen 7", "Sivstad", "Siv Sivsson", "23568971", "98765" }
                });

            migrationBuilder.InsertData(
                table: "BookConnections",
                columns: new[] { "BookConnectionId", "Barrowed", "FK_BookId", "FK_CustomerId", "IsReturned" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2472), 1, 1, false },
                    { 2, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2516), 2, 1, false },
                    { 3, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2518), 4, 2, true },
                    { 4, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2519), 6, 3, true },
                    { 5, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2521), 5, 4, false },
                    { 6, new DateTime(2023, 5, 9, 10, 31, 57, 789, DateTimeKind.Local).AddTicks(2522), 6, 4, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookConnections_FK_BookId",
                table: "BookConnections",
                column: "FK_BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookConnections_FK_CustomerId",
                table: "BookConnections",
                column: "FK_CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookConnections");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
