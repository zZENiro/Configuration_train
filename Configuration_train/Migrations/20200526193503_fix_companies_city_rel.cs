using Microsoft.EntityFrameworkCore.Migrations;

namespace Configuration_train.Migrations
{
    public partial class fix_companies_city_rel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies_cities_conns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies_cities_conns",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies_cities_conns", x => new { x.CityId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_companies_cities_conns_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_companies_cities_conns_company_tbl_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_cities_conns_CompanyId",
                table: "companies_cities_conns",
                column: "CompanyId");
        }
    }
}
