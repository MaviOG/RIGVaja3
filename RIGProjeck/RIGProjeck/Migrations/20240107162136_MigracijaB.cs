using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RIGProjeck.Migrations
{
    /// <inheritdoc />
    public partial class MigracijaB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nepremicninas",
                columns: table => new
                {
                    NepremičninaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    lokacija = table.Column<string>(type: "TEXT", nullable: false),
                    cena = table.Column<int>(type: "INTEGER", nullable: false),
                    dan_izgradnje = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    stevilo_kopalnic = table.Column<int>(type: "INTEGER", nullable: false),
                    stevilo_prostorov = table.Column<int>(type: "INTEGER", nullable: false),
                    velikost = table.Column<int>(type: "INTEGER", nullable: false),
                    stevilo_balkonov = table.Column<int>(type: "INTEGER", nullable: false),
                    stevilo_spalnic = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocena = table.Column<string>(type: "TEXT", nullable: false),
                    Komentarji = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nepremicninas", x => x.NepremičninaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nepremicninas");
        }
    }
}
