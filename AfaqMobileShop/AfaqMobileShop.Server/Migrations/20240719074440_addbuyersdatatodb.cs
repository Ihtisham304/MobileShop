using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class addbuyersdatatodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buying",
                columns: new[] { "Id", "Adrss", "CNIC", "CNICPicture", "Color", "Date", "FName", "IMEI1", "IMEI2", "MobileModel", "MobileNumber", "Name", "PurchasePrice", "Specs" },
                values: new object[] { 1, "NSR", "173743753773", new byte[] { 0, 1, 2, 3, 4, 5 }, "red", new DateTime(2024, 7, 19, 12, 44, 39, 894, DateTimeKind.Local).AddTicks(7630), "Jan", "s54646chghchfg", "no979879jh986", "2020", "03048034098", "Khan", 2300, "8gb 128gb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buying",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
