using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class Sedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Address", "Baqaya", "CNIC", "Garranty", "IMEI1", "IMEI2", "Name", "Price", "SellDate", "Warranty", "Wasol" },
                values: new object[,]
                {
                    { 2, "NSR", 10000, "173743753773", "2year", "s54646chghchfg", "no979879jh986", "Khan", 30000, new DateTime(2024, 7, 6, 10, 40, 45, 327, DateTimeKind.Local).AddTicks(2178), "1year", 20000 },
                    { 3, "NSR", 10000, "173743753773", "2year", "s54646chghchfg", "no979879jh986", "Jan", 30000, new DateTime(2024, 7, 6, 10, 40, 45, 327, DateTimeKind.Local).AddTicks(2209), "1year", 20000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "UserName" },
                values: new object[] { 1, "Admin", "Admin123", "Admin" });
        }
    }
}
