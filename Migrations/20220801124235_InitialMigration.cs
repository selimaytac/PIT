using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTPersonalInfoTracker.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    RecordId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PozisyonSeviyesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SirketEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicilNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yonetici = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.RecordId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");
        }
    }
}
