using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RIGProjeck.Migrations
{
    /// <inheritdoc />
    public partial class novamigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Nepremicninas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uporabnikov_id",
                table: "Nepremicninas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    verified = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nepremicninas_UserId",
                table: "Nepremicninas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nepremicninas_Users_UserId",
                table: "Nepremicninas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nepremicninas_Users_UserId",
                table: "Nepremicninas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Nepremicninas_UserId",
                table: "Nepremicninas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Nepremicninas");

            migrationBuilder.DropColumn(
                name: "uporabnikov_id",
                table: "Nepremicninas");
        }
    }
}
