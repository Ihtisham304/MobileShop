using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedStockTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Buying",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 24, 15, 45, 59, 615, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "MobileName", "Quantity" },
                values: new object[,]
                {
                    { 1, "Infinix", 3 },
                    { 2, "realme", 5 },
                    { 3, "Techno", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.UpdateData(
                table: "Buying",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 19, 12, 44, 39, 894, DateTimeKind.Local).AddTicks(7630));
        }
    }
}
