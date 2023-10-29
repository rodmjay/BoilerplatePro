using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoilerplatePro.Base.common.data.migrations
{
    /// <inheritdoc />
    public partial class RemoveEnabledCountryFromSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnabledCountry",
                keyColumn: "Iso2",
                keyValue: "US");

            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 20, 7, 3, 504, DateTimeKind.Utc).AddTicks(947));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 17, 46, 33, 454, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.InsertData(
                table: "EnabledCountry",
                columns: new[] { "Iso2", "UserId" },
                values: new object[] { "US", 1 });
        }
    }
}
