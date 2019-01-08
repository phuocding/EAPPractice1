using Microsoft.EntityFrameworkCore.Migrations;

namespace EAP_Exam.Migrations
{
    public partial class ExchangeAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExchangeRatio",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ratio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRatio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRatio");
        }
    }
}
