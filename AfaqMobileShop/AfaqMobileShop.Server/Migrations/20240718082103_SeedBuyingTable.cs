using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedBuyingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Buying",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adrss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNICPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Specs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<int>(type: "int", nullable: false),
                    MobileModel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buying", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Buying",
                columns: new[] { "Id", "Adrss", "CNIC", "CNICPicture", "Color", "Date", "FName", "IMEI1", "IMEI2", "MobileModel", "MobileNumber", "Name", "PurchasePrice", "Specs" },
                values: new object[] { 1, "NSR", "173743753773", new byte[] { 0, 1, 2, 3, 4, 5 }, "red", new DateTime(2024, 7, 18, 13, 21, 1, 663, DateTimeKind.Local).AddTicks(9596), "Jan", "s54646chghchfg", "no979879jh986", "2020", "03048034098", "Khan", 2300, "8gb 128gb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buying");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "UserName" },
                values: new object[] { 1, "Admin", "Admin123", "Admin" });
        }
    }
}
