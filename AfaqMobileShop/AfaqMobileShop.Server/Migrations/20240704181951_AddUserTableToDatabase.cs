using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTableToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Sales");

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Baqaya", "CNIC", "Garranty", "IMEI1", "IMEI2", "Name", "Price", "SellDate", "Warranty", "Wasol" },
                values: new object[,]
                {
                    { 1, 10000, "173743753773", "2year", "s54646chghchfg", "no979879jh986", "Khan", 30000, new DateTime(2024, 7, 4, 15, 43, 1, 61, DateTimeKind.Local).AddTicks(1457), "1year", 20000 },
                    { 2, 10000, "173743753773", "2year", "s54646chghchfg", "no979879jh986", "Jan", 30000, new DateTime(2024, 7, 4, 15, 43, 1, 61, DateTimeKind.Local).AddTicks(1472), "1year", 20000 }
                });
        }
    }
}
