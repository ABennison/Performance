using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataSql.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    InstrumentIdentifier = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    InstrumentType = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    LocalCurrencyCode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.InstrumentIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentType",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentType", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "MarketPrice",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InstrumentIdentifier = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 24, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPrice", x => new { x.Date, x.InstrumentIdentifier });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "InstrumentType");

            migrationBuilder.DropTable(
                name: "MarketPrice");
        }
    }
}
