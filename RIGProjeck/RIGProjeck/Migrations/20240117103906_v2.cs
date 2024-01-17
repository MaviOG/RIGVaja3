using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RIGProjeck.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Komentarji",
                table: "Nepremicninas");

            migrationBuilder.DropColumn(
                name: "Ocena",
                table: "Nepremicninas");

            migrationBuilder.AddColumn<int>(
                name: "uporabnikov_id",
                table: "Nepremicninas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uporabnikov_id",
                table: "Nepremicninas");

            migrationBuilder.AddColumn<string>(
                name: "Komentarji",
                table: "Nepremicninas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ocena",
                table: "Nepremicninas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
