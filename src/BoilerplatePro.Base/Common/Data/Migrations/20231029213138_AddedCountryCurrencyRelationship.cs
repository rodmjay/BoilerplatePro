using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoilerplatePro.Base.common.data.migrations
{
    /// <inheritdoc />
    public partial class AddedCountryCurrencyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryCurrency",
                columns: table => new
                {
                    CurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iso2 = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCurrency", x => new { x.Iso2, x.CurrencyCode });
                    table.ForeignKey(
                        name: "FK_CountryCurrency_Country_Iso2",
                        column: x => x.Iso2,
                        principalTable: "Country",
                        principalColumn: "Iso2",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryCurrency_Currency_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currency",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 21, 31, 38, 427, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.InsertData(
                table: "CountryCurrency",
                columns: new[] { "CurrencyCode", "Iso2" },
                values: new object[] { "USD", "US" });

            migrationBuilder.CreateIndex(
                name: "IX_CountryCurrency_CurrencyCode",
                table: "CountryCurrency",
                column: "CurrencyCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryCurrency");

            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 20, 7, 3, 504, DateTimeKind.Utc).AddTicks(947));
        }
    }
}
