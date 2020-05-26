using Microsoft.EntityFrameworkCore.Migrations;

namespace Configuration_train.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "country_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: false),
                    FlagUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("country_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lang_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lang_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "company_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    county_id = table.Column<int>(nullable: true),
                    city_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("comp_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_tbl_City_city_id",
                        column: x => x.city_id,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_company_tbl_country_tbl_county_id",
                        column: x => x.county_id,
                        principalTable: "country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "companies_cities_conns",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "employee_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    country_id = table.Column<int>(nullable: true),
                    company_id = table.Column<int>(nullable: true),
                    city_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("employee_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employee_tbl_City_city_id",
                        column: x => x.city_id,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_tbl_company_tbl_company_id",
                        column: x => x.company_id,
                        principalTable: "company_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_tbl_country_tbl_country_id",
                        column: x => x.country_id,
                        principalTable: "country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees_companies_conn",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees_companies_conn", x => new { x.CompanyId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_employees_companies_conn_company_tbl_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_companies_conn_employee_tbl_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees_lang_conns",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees_lang_conns", x => new { x.LanguageId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_employees_lang_conns_employee_tbl_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_lang_conns_lang_tbl_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "lang_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_cities_conns_CompanyId",
                table: "companies_cities_conns",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_company_tbl_city_id",
                table: "company_tbl",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_tbl_county_id",
                table: "company_tbl",
                column: "county_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_tbl_city_id",
                table: "employee_tbl",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_tbl_company_id",
                table: "employee_tbl",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_tbl_country_id",
                table: "employee_tbl",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_companies_conn_EmployeeId",
                table: "employees_companies_conn",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_lang_conns_EmployeeId",
                table: "employees_lang_conns",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies_cities_conns");

            migrationBuilder.DropTable(
                name: "employees_companies_conn");

            migrationBuilder.DropTable(
                name: "employees_lang_conns");

            migrationBuilder.DropTable(
                name: "employee_tbl");

            migrationBuilder.DropTable(
                name: "lang_tbl");

            migrationBuilder.DropTable(
                name: "company_tbl");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "country_tbl");
        }
    }
}
