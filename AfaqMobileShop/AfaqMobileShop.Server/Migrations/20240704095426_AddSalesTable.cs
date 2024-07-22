using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AfaqMobileShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSalesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Garranty = table.Column<int>(type: "int", nullable: false),
                    Wasol = table.Column<int>(type: "int", nullable: false),
                    Baqaya = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
