using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoilerplatePro.Base.common.data.migrations
{
    /// <inheritdoc />
    public partial class AddedCountryTimezoneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone");

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACT", "Acre Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AFT", "Afghanistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DFT", "AIX specific equivalent of Central European Time[5]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AKDT", "Alaska Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AKST", "Alaska Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMST", "Amazon Summer Time (Brazil)[1]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMT", "Amazon Time (Brazil)[2]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AST", "Arabia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ART", "Argentina Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMT", "Armenia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACT", "ASEAN Common Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ADT", "Atlantic Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AST", "Atlantic Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACDT", "Australian Central Daylight Savings Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACST", "Australian Central Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEDT", "Australian Eastern Daylight Savings Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEST", "Australian Eastern Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AWST", "Australian Western Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZT", "Azerbaijan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZOT", "Azores Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZOST", "Azores Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BIT", "Baker Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "Bangladesh Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BTT", "Bhutan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BOT", "Bolivia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "Bougainville Standard Time[3]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BRST", "Brasilia Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BRT", "Brasilia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BIOT", "British Indian Ocean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BDT", "Brunei Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CVT", "Cape Verde Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CAT", "Central Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CDT", "Central Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CEST", "Central European Summer Time (Cf. HAEC)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CET", "Central European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CIT", "Central Indonesia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACST", "Central Standard Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "Central Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACDT", "Central Summer Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CWST", "Central Western Standard Time (Australia) unofficial" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHST", "Chamorro Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHADT", "Chatham Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHAST", "Chatham Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CLT", "Chile Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CLST", "Chile Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "China Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CT", "China time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHOT", "Choibalsan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHOST", "Choibalsan Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CXT", "Christmas Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHUT", "Chuuk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CIST", "Clipperton Island Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CCT", "Cocos Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "COST", "Colombia Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "COT", "Colombia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CKT", "Cook Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "", "Coordinated Universal Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CDT", "Cuba Daylight Time[4]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "Cuba Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DAVT", "Davis Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DDUT", "Dumont d'Urville Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EAT", "East Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EAST", "Easter Island Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EASST", "Easter Island Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ECT", "Eastern Caribbean Time (does not recognise DST)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EDT", "Eastern Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EEST", "Eastern European Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EET", "Eastern European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EGST", "Eastern Greenland Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EGT", "Eastern Greenland Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EIT", "Eastern Indonesian Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEST", "Eastern Standard Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EST", "Eastern Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEDT", "Eastern Summer Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ECT", "Ecuador Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FKST", "Falkland Islands Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FKT", "Falkland Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FNT", "Fernando de Noronha Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FJT", "Fiji Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GFT", "French Guiana Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FET", "Further-eastern European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GALT", "Galapagos Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GIT", "Gambier Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GAMT", "Gambier Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GET", "Georgia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GILT", "Gilbert Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GMT", "Greenwich Mean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GST", "Gulf Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GYT", "Guyana Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HADT", "Hawaii-Aleutian Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HAST", "Hawaii-Aleutian Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HMT", "Heard and McDonald Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HAEC", "Heure Avancée d'Europe Centrale francised name for CEST" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HKT", "Hong Kong Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IOT", "Indian Ocean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Indian Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TFT", "Indian/Kerguelen" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ICT", "Indochina Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRDT", "Iran Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRST", "Iran Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Irish Standard Time[6]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRKT", "Irkutsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IDT", "Israel Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Israel Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "JST", "Japan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "USZ1", "Kaliningrad Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PETT", "Kamchatka Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HOVT", "Khovd Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HOVST", "Khovd Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KST", "Korea Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KOST", "Kosrae Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KRAT", "Krasnoyarsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KGT", "Kyrgyzstan time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LINT", "Line Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LHST", "Lord Howe Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LHST", "Lord Howe Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MIST", "Macquarie Island Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MAGT", "Magadan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MST", "Malaysia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MYT", "Malaysia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MVT", "Maldives Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MART", "Marquesas Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MIT", "Marquesas Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MHT", "Marshall Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MUT", "Mauritius Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MAWT", "Mawson Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MEST", "Middle European Summer Time Same zone as CEST" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MET", "Middle European Time Same zone as CET" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MSK", "Moscow Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MDT", "Mountain Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MST", "Mountain Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MMT", "Myanmar Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NPT", "Nepal Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NCT", "New Caledonia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NZDT", "New Zealand Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NZST", "New Zealand Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NDT", "Newfoundland Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NST", "Newfoundland Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NT", "Newfoundland Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NUT", "Niue Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NFT", "Norfolk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "OMST", "Omsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ORAT", "Oral Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PDT", "Pacific Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PST", "Pacific Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PKT", "Pakistan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PGT", "Papua New Guinea Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PYST", "Paraguay Summer Time (South America)[7]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PYT", "Paraguay Time (South America)[8]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PET", "Peru Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PST", "Philippine Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PHT", "Philippine Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PHOT", "Phoenix Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PONT", "Pohnpei Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "RET", "Réunion Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ROTT", "Rothera Research Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PMDT", "Saint Pierre and Miquelon Daylight time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PMST", "Saint Pierre and Miquelon Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAKT", "Sakhalin Island time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAMT", "Samara Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SST", "Samoa Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SCT", "Seychelles Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SYOT", "Showa Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SST", "Singapore Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SGT", "Singapore Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SBT", "Solomon Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAST", "South African Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GST", "South Georgia and the South Sandwich Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SRET", "Srednekolymsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SLST", "Sri Lanka Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SRT", "Suriname Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TAHT", "Tahiti Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TJT", "Tajikistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "THA", "Thailand Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TLT", "Timor Leste Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TKT", "Tokelau Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TOT", "Tonga Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TRT", "Turkey Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TMT", "Turkmenistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TVT", "Tuvalu Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ULAT", "Ulaanbaatar Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ULAST", "Ulaanbaatar Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UYT", "Uruguay Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UYST", "Uruguay Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UZT", "Uzbekistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VUT", "Vanuatu Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VET", "Venezuelan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VLAT", "Vladivostok Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VOLT", "Volgograd Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VOST", "Vostok Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAKT", "Wake Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAST", "West Africa Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAT", "West Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WEST", "Western European Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WET", "Western European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WIT", "Western Indonesian Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WST", "Western Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "YAKT", "Yakutsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "YEKT", "Yekaterinburg Time" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateTable(
                name: "CountryTimezone",
                columns: table => new
                {
                    TimezoneCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iso2 = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    TimezoneName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTimezone", x => new { x.Iso2, x.TimezoneCode });
                    table.ForeignKey(
                        name: "FK_CountryTimezone_Country_Iso2",
                        column: x => x.Iso2,
                        principalTable: "Country",
                        principalColumn: "Iso2",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryTimezone_Timezone_TimezoneCode_TimezoneName",
                        columns: x => new { x.TimezoneCode, x.TimezoneName },
                        principalTable: "Timezone",
                        principalColumns: new[] { "Code", "Name" });
                });

            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 23, 34, 8, 175, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.InsertData(
                table: "Timezone",
                columns: new[] { "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "", "Coordinated Universal Time", "±00" },
                    { "ACDT", "Australian Central Daylight Savings Time", "+10:30" },
                    { "ACDT", "Central Summer Time (Australia)", "+10:30" },
                    { "ACST", "Australian Central Standard Time", "+09:30" },
                    { "ACST", "Central Standard Time (Australia)", "+09:30" },
                    { "ACT", "Acre Time", "-05" },
                    { "ACT", "ASEAN Common Time", "+06:30 - +09" },
                    { "ADT", "Atlantic Daylight Time", "-03" },
                    { "AEDT", "Australian Eastern Daylight Savings Time", "+11" },
                    { "AEDT", "Eastern Summer Time (Australia)", "+11" },
                    { "AEST", "Australian Eastern Standard Time", "+10" },
                    { "AEST", "Eastern Standard Time (Australia)", "+10" },
                    { "AFT", "Afghanistan Time", "+04:30" },
                    { "AKDT", "Alaska Daylight Time", "-08" },
                    { "AKST", "Alaska Standard Time", "-09" },
                    { "AMST", "Amazon Summer Time (Brazil)[1]", "-03" },
                    { "AMT", "Amazon Time (Brazil)[2]", "-04" },
                    { "AMT", "Armenia Time", "+04" },
                    { "ART", "Argentina Time", "-03" },
                    { "AST", "Arabia Standard Time", "+03" },
                    { "AST", "Atlantic Standard Time", "-04" },
                    { "AWST", "Australian Western Standard Time", "+08" },
                    { "AZOST", "Azores Summer Time", "±00" },
                    { "AZOT", "Azores Standard Time", "-01" },
                    { "AZT", "Azerbaijan Time", "+04" },
                    { "BDT", "Brunei Time", "+08" },
                    { "BIOT", "British Indian Ocean Time", "+06" },
                    { "BIT", "Baker Island Time", "-12" },
                    { "BOT", "Bolivia Time", "-04" },
                    { "BRST", "Brasilia Summer Time", "-02" },
                    { "BRT", "Brasilia Time", "-03" },
                    { "BST", "Bangladesh Standard Time", "+06" },
                    { "BST", "Bougainville Standard Time[3]", "+11" },
                    { "BST", "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)", "+01" },
                    { "BTT", "Bhutan Time", "+06" },
                    { "CAT", "Central Africa Time", "+02" },
                    { "CCT", "Cocos Islands Time", "+06:30" },
                    { "CDT", "Central Daylight Time (North America)", "-05" },
                    { "CDT", "Cuba Daylight Time[4]", "-04" },
                    { "CEST", "Central European Summer Time (Cf. HAEC)", "+02" },
                    { "CET", "Central European Time", "+01" },
                    { "CHADT", "Chatham Daylight Time", "+13:45" },
                    { "CHAST", "Chatham Standard Time", "+12:45" },
                    { "CHOST", "Choibalsan Summer Time", "+09" },
                    { "CHOT", "Choibalsan Standard Time", "+08" },
                    { "CHST", "Chamorro Standard Time", "+10" },
                    { "CHUT", "Chuuk Time", "+10" },
                    { "CIST", "Clipperton Island Standard Time", "-08" },
                    { "CIT", "Central Indonesia Time", "+08" },
                    { "CKT", "Cook Island Time", "-10" },
                    { "CLST", "Chile Summer Time", "-03" },
                    { "CLT", "Chile Standard Time", "-04" },
                    { "COST", "Colombia Summer Time", "-04" },
                    { "COT", "Colombia Time", "-05" },
                    { "CST", "Central Standard Time (North America)", "-06" },
                    { "CST", "China Standard Time", "+08" },
                    { "CST", "Cuba Standard Time", "-05" },
                    { "CT", "China time", "+08" },
                    { "CVT", "Cape Verde Time", "-01" },
                    { "CWST", "Central Western Standard Time (Australia) unofficial", "+08:45" },
                    { "CXT", "Christmas Island Time", "+07" },
                    { "DAVT", "Davis Time", "+07" },
                    { "DDUT", "Dumont d'Urville Time", "+10" },
                    { "DFT", "AIX specific equivalent of Central European Time[5]", "+01" },
                    { "EASST", "Easter Island Summer Time", "-05" },
                    { "EAST", "Easter Island Standard Time", "-06" },
                    { "EAT", "East Africa Time", "+03" },
                    { "ECT", "Eastern Caribbean Time (does not recognise DST)", "-04" },
                    { "ECT", "Ecuador Time", "-05" },
                    { "EDT", "Eastern Daylight Time (North America)", "-04" },
                    { "EEST", "Eastern European Summer Time", "+03" },
                    { "EET", "Eastern European Time", "+02" },
                    { "EGST", "Eastern Greenland Summer Time", "±00" },
                    { "EGT", "Eastern Greenland Time", "-01" },
                    { "EIT", "Eastern Indonesian Time", "+09" },
                    { "EST", "Eastern Standard Time (North America)", "-05" },
                    { "FET", "Further-eastern European Time", "+03" },
                    { "FJT", "Fiji Time", "+12" },
                    { "FKST", "Falkland Islands Summer Time", "-03" },
                    { "FKT", "Falkland Islands Time", "-04" },
                    { "FNT", "Fernando de Noronha Time", "-02" },
                    { "GALT", "Galapagos Time", "-06" },
                    { "GAMT", "Gambier Islands", "-09" },
                    { "GET", "Georgia Standard Time", "+04" },
                    { "GFT", "French Guiana Time", "-03" },
                    { "GILT", "Gilbert Island Time", "+12" },
                    { "GIT", "Gambier Island Time", "-09" },
                    { "GMT", "Greenwich Mean Time", "±00" },
                    { "GST", "Gulf Standard Time", "+04" },
                    { "GST", "South Georgia and the South Sandwich Islands", "-02" },
                    { "GYT", "Guyana Time", "-04" },
                    { "HADT", "Hawaii-Aleutian Daylight Time", "-09" },
                    { "HAEC", "Heure Avancée d'Europe Centrale francised name for CEST", "+02" },
                    { "HAST", "Hawaii-Aleutian Standard Time", "-10" },
                    { "HKT", "Hong Kong Time", "+08" },
                    { "HMT", "Heard and McDonald Islands Time", "+05" },
                    { "HOVST", "Khovd Summer Time", "+08" },
                    { "HOVT", "Khovd Standard Time", "+07" },
                    { "ICT", "Indochina Time", "+07" },
                    { "IDT", "Israel Daylight Time", "+03" },
                    { "IOT", "Indian Ocean Time", "+03" },
                    { "IRDT", "Iran Daylight Time", "+04:30" },
                    { "IRKT", "Irkutsk Time", "+08" },
                    { "IRST", "Iran Standard Time", "+03:30" },
                    { "IST", "Indian Standard Time", "+05:30" },
                    { "IST", "Irish Standard Time[6]", "+01" },
                    { "IST", "Israel Standard Time", "+02" },
                    { "JST", "Japan Standard Time", "+09" },
                    { "KGT", "Kyrgyzstan time", "+06" },
                    { "KOST", "Kosrae Time", "+11" },
                    { "KRAT", "Krasnoyarsk Time", "+07" },
                    { "KST", "Korea Standard Time", "+09" },
                    { "LHST", "Lord Howe Standard Time", "+10:30" },
                    { "LHST", "Lord Howe Summer Time", "+11" },
                    { "LINT", "Line Islands Time", "+14" },
                    { "MAGT", "Magadan Time", "+12" },
                    { "MART", "Marquesas Islands Time", "-09:30" },
                    { "MAWT", "Mawson Station Time", "+05" },
                    { "MDT", "Mountain Daylight Time (North America)", "-06" },
                    { "MEST", "Middle European Summer Time Same zone as CEST", "+02" },
                    { "MET", "Middle European Time Same zone as CET", "+01" },
                    { "MHT", "Marshall Islands", "+12" },
                    { "MIST", "Macquarie Island Station Time", "+11" },
                    { "MIT", "Marquesas Islands Time", "-09:30" },
                    { "MMT", "Myanmar Standard Time", "+06:30" },
                    { "MSK", "Moscow Time", "+03" },
                    { "MST", "Malaysia Standard Time", "+08" },
                    { "MST", "Mountain Standard Time (North America)", "-07" },
                    { "MUT", "Mauritius Time", "+04" },
                    { "MVT", "Maldives Time", "+05" },
                    { "MYT", "Malaysia Time", "+08" },
                    { "NCT", "New Caledonia Time", "+11" },
                    { "NDT", "Newfoundland Daylight Time", "-02:30" },
                    { "NFT", "Norfolk Time", "+11" },
                    { "NPT", "Nepal Time", "+05:45" },
                    { "NST", "Newfoundland Standard Time", "-03:30" },
                    { "NT", "Newfoundland Time", "-03:30" },
                    { "NUT", "Niue Time", "-11" },
                    { "NZDT", "New Zealand Daylight Time", "+13" },
                    { "NZST", "New Zealand Standard Time", "+12" },
                    { "OMST", "Omsk Time", "+06" },
                    { "ORAT", "Oral Time", "+05" },
                    { "PDT", "Pacific Daylight Time (North America)", "-07" },
                    { "PET", "Peru Time", "-05" },
                    { "PETT", "Kamchatka Time", "+12" },
                    { "PGT", "Papua New Guinea Time", "+10" },
                    { "PHOT", "Phoenix Island Time", "+13" },
                    { "PHT", "Philippine Time", "+08" },
                    { "PKT", "Pakistan Standard Time", "+05" },
                    { "PMDT", "Saint Pierre and Miquelon Daylight time", "-02" },
                    { "PMST", "Saint Pierre and Miquelon Standard Time", "-03" },
                    { "PONT", "Pohnpei Standard Time", "+11" },
                    { "PST", "Pacific Standard Time (North America)", "-08" },
                    { "PST", "Philippine Standard Time", "+08" },
                    { "PYST", "Paraguay Summer Time (South America)[7]", "-03" },
                    { "PYT", "Paraguay Time (South America)[8]", "-04" },
                    { "RET", "Réunion Time", "+04" },
                    { "ROTT", "Rothera Research Station Time", "-03" },
                    { "SAKT", "Sakhalin Island time", "+11" },
                    { "SAMT", "Samara Time", "+04" },
                    { "SAST", "South African Standard Time", "+02" },
                    { "SBT", "Solomon Islands Time", "+11" },
                    { "SCT", "Seychelles Time", "+04" },
                    { "SGT", "Singapore Time", "+08" },
                    { "SLST", "Sri Lanka Standard Time", "+05:30" },
                    { "SRET", "Srednekolymsk Time", "+11" },
                    { "SRT", "Suriname Time", "-03" },
                    { "SST", "Samoa Standard Time", "-11" },
                    { "SST", "Singapore Standard Time", "+08" },
                    { "SYOT", "Showa Station Time", "+03" },
                    { "TAHT", "Tahiti Time", "-10" },
                    { "TFT", "Indian/Kerguelen", "+05" },
                    { "THA", "Thailand Standard Time", "+07" },
                    { "TJT", "Tajikistan Time", "+05" },
                    { "TKT", "Tokelau Time", "+13" },
                    { "TLT", "Timor Leste Time", "+09" },
                    { "TMT", "Turkmenistan Time", "+05" },
                    { "TOT", "Tonga Time", "+13" },
                    { "TRT", "Turkey Time", "+03" },
                    { "TVT", "Tuvalu Time", "+12" },
                    { "ULAST", "Ulaanbaatar Summer Time", "+09" },
                    { "ULAT", "Ulaanbaatar Standard Time", "+08" },
                    { "USZ1", "Kaliningrad Time", "+02" },
                    { "UYST", "Uruguay Summer Time", "-02" },
                    { "UYT", "Uruguay Standard Time", "-03" },
                    { "UZT", "Uzbekistan Time", "+05" },
                    { "VET", "Venezuelan Standard Time", "-04" },
                    { "VLAT", "Vladivostok Time", "+10" },
                    { "VOLT", "Volgograd Time", "+04" },
                    { "VOST", "Vostok Station Time", "+06" },
                    { "VUT", "Vanuatu Time", "+11" },
                    { "WAKT", "Wake Island Time", "+12" },
                    { "WAST", "West Africa Summer Time", "+02" },
                    { "WAT", "West Africa Time", "+01" },
                    { "WEST", "Western European Summer Time", "+01" },
                    { "WET", "Western European Time", "±00" },
                    { "WIT", "Western Indonesian Time", "+07" },
                    { "WST", "Western Standard Time", "+08" },
                    { "YAKT", "Yakutsk Time", "+09" },
                    { "YEKT", "Yekaterinburg Time", "+05" }
                });

            migrationBuilder.InsertData(
                table: "CountryTimezone",
                columns: new[] { "Iso2", "TimezoneCode", "TimezoneName" },
                values: new object[,]
                {
                    { "US", "AKST", "Alaska Standard Time" },
                    { "US", "CHST", "Chamorro Standard Time" },
                    { "US", "CST", "Central Standard Time (North America)" },
                    { "US", "EST", "Eastern Standard Time (North America)" },
                    { "US", "HADT", "Hawaii-Aleutian Daylight Time" },
                    { "US", "HAST", "Hawaii-Aleutian Standard Time" },
                    { "US", "MST", "Mountain Standard Time (North America)" },
                    { "US", "PST", "Pacific Standard Time (North America)" },
                    { "US", "SST", "Samoa Standard Time" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryTimezone_TimezoneCode_TimezoneName",
                table: "CountryTimezone",
                columns: new[] { "TimezoneCode", "TimezoneName" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryTimezone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone");

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "", "Coordinated Universal Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACDT", "Australian Central Daylight Savings Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACDT", "Central Summer Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACST", "Australian Central Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACST", "Central Standard Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACT", "Acre Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ACT", "ASEAN Common Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ADT", "Atlantic Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEDT", "Australian Eastern Daylight Savings Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEDT", "Eastern Summer Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEST", "Australian Eastern Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AEST", "Eastern Standard Time (Australia)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AFT", "Afghanistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AKDT", "Alaska Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AKST", "Alaska Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMST", "Amazon Summer Time (Brazil)[1]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMT", "Amazon Time (Brazil)[2]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AMT", "Armenia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ART", "Argentina Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AST", "Arabia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AST", "Atlantic Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AWST", "Australian Western Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZOST", "Azores Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZOT", "Azores Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "AZT", "Azerbaijan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BDT", "Brunei Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BIOT", "British Indian Ocean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BIT", "Baker Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BOT", "Bolivia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BRST", "Brasilia Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BRT", "Brasilia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "Bangladesh Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "Bougainville Standard Time[3]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BST", "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "BTT", "Bhutan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CAT", "Central Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CCT", "Cocos Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CDT", "Central Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CDT", "Cuba Daylight Time[4]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CEST", "Central European Summer Time (Cf. HAEC)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CET", "Central European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHADT", "Chatham Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHAST", "Chatham Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHOST", "Choibalsan Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHOT", "Choibalsan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHST", "Chamorro Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CHUT", "Chuuk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CIST", "Clipperton Island Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CIT", "Central Indonesia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CKT", "Cook Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CLST", "Chile Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CLT", "Chile Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "COST", "Colombia Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "COT", "Colombia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "Central Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "China Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CST", "Cuba Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CT", "China time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CVT", "Cape Verde Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CWST", "Central Western Standard Time (Australia) unofficial" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "CXT", "Christmas Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DAVT", "Davis Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DDUT", "Dumont d'Urville Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "DFT", "AIX specific equivalent of Central European Time[5]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EASST", "Easter Island Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EAST", "Easter Island Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EAT", "East Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ECT", "Eastern Caribbean Time (does not recognise DST)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ECT", "Ecuador Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EDT", "Eastern Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EEST", "Eastern European Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EET", "Eastern European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EGST", "Eastern Greenland Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EGT", "Eastern Greenland Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EIT", "Eastern Indonesian Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "EST", "Eastern Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FET", "Further-eastern European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FJT", "Fiji Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FKST", "Falkland Islands Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FKT", "Falkland Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "FNT", "Fernando de Noronha Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GALT", "Galapagos Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GAMT", "Gambier Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GET", "Georgia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GFT", "French Guiana Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GILT", "Gilbert Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GIT", "Gambier Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GMT", "Greenwich Mean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GST", "Gulf Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GST", "South Georgia and the South Sandwich Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "GYT", "Guyana Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HADT", "Hawaii-Aleutian Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HAEC", "Heure Avancée d'Europe Centrale francised name for CEST" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HAST", "Hawaii-Aleutian Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HKT", "Hong Kong Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HMT", "Heard and McDonald Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HOVST", "Khovd Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "HOVT", "Khovd Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ICT", "Indochina Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IDT", "Israel Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IOT", "Indian Ocean Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRDT", "Iran Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRKT", "Irkutsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IRST", "Iran Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Indian Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Irish Standard Time[6]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "IST", "Israel Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "JST", "Japan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KGT", "Kyrgyzstan time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KOST", "Kosrae Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KRAT", "Krasnoyarsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "KST", "Korea Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LHST", "Lord Howe Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LHST", "Lord Howe Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "LINT", "Line Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MAGT", "Magadan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MART", "Marquesas Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MAWT", "Mawson Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MDT", "Mountain Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MEST", "Middle European Summer Time Same zone as CEST" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MET", "Middle European Time Same zone as CET" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MHT", "Marshall Islands" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MIST", "Macquarie Island Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MIT", "Marquesas Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MMT", "Myanmar Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MSK", "Moscow Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MST", "Malaysia Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MST", "Mountain Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MUT", "Mauritius Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MVT", "Maldives Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "MYT", "Malaysia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NCT", "New Caledonia Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NDT", "Newfoundland Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NFT", "Norfolk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NPT", "Nepal Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NST", "Newfoundland Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NT", "Newfoundland Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NUT", "Niue Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NZDT", "New Zealand Daylight Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "NZST", "New Zealand Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "OMST", "Omsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ORAT", "Oral Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PDT", "Pacific Daylight Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PET", "Peru Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PETT", "Kamchatka Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PGT", "Papua New Guinea Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PHOT", "Phoenix Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PHT", "Philippine Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PKT", "Pakistan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PMDT", "Saint Pierre and Miquelon Daylight time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PMST", "Saint Pierre and Miquelon Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PONT", "Pohnpei Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PST", "Pacific Standard Time (North America)" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PST", "Philippine Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PYST", "Paraguay Summer Time (South America)[7]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "PYT", "Paraguay Time (South America)[8]" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "RET", "Réunion Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ROTT", "Rothera Research Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAKT", "Sakhalin Island time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAMT", "Samara Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SAST", "South African Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SBT", "Solomon Islands Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SCT", "Seychelles Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SGT", "Singapore Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SLST", "Sri Lanka Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SRET", "Srednekolymsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SRT", "Suriname Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SST", "Samoa Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SST", "Singapore Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "SYOT", "Showa Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TAHT", "Tahiti Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TFT", "Indian/Kerguelen" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "THA", "Thailand Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TJT", "Tajikistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TKT", "Tokelau Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TLT", "Timor Leste Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TMT", "Turkmenistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TOT", "Tonga Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TRT", "Turkey Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "TVT", "Tuvalu Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ULAST", "Ulaanbaatar Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "ULAT", "Ulaanbaatar Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "USZ1", "Kaliningrad Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UYST", "Uruguay Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UYT", "Uruguay Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "UZT", "Uzbekistan Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VET", "Venezuelan Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VLAT", "Vladivostok Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VOLT", "Volgograd Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VOST", "Vostok Station Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "VUT", "Vanuatu Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAKT", "Wake Island Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAST", "West Africa Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WAT", "West Africa Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WEST", "Western European Summer Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WET", "Western European Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WIT", "Western Indonesian Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "WST", "Western Standard Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "YAKT", "Yakutsk Time" });

            migrationBuilder.DeleteData(
                table: "Timezone",
                keyColumns: new[] { "Code", "Name" },
                keyValues: new object[] { "YEKT", "Yekaterinburg Time" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone",
                columns: new[] { "Name", "Code" });

            migrationBuilder.UpdateData(
                schema: "IdentityServer",
                table: "ApiScope",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 29, 21, 31, 38, 427, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.InsertData(
                table: "Timezone",
                columns: new[] { "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "ACT", "Acre Time", "-05" },
                    { "AFT", "Afghanistan Time", "+04:30" },
                    { "DFT", "AIX specific equivalent of Central European Time[5]", "+01" },
                    { "AKDT", "Alaska Daylight Time", "-08" },
                    { "AKST", "Alaska Standard Time", "-09" },
                    { "AMST", "Amazon Summer Time (Brazil)[1]", "-03" },
                    { "AMT", "Amazon Time (Brazil)[2]", "-04" },
                    { "AST", "Arabia Standard Time", "+03" },
                    { "ART", "Argentina Time", "-03" },
                    { "AMT", "Armenia Time", "+04" },
                    { "ACT", "ASEAN Common Time", "+06:30 - +09" },
                    { "ADT", "Atlantic Daylight Time", "-03" },
                    { "AST", "Atlantic Standard Time", "-04" },
                    { "ACDT", "Australian Central Daylight Savings Time", "+10:30" },
                    { "ACST", "Australian Central Standard Time", "+09:30" },
                    { "AEDT", "Australian Eastern Daylight Savings Time", "+11" },
                    { "AEST", "Australian Eastern Standard Time", "+10" },
                    { "AWST", "Australian Western Standard Time", "+08" },
                    { "AZT", "Azerbaijan Time", "+04" },
                    { "AZOT", "Azores Standard Time", "-01" },
                    { "AZOST", "Azores Summer Time", "±00" },
                    { "BIT", "Baker Island Time", "-12" },
                    { "BST", "Bangladesh Standard Time", "+06" },
                    { "BTT", "Bhutan Time", "+06" },
                    { "BOT", "Bolivia Time", "-04" },
                    { "BST", "Bougainville Standard Time[3]", "+11" },
                    { "BRST", "Brasilia Summer Time", "-02" },
                    { "BRT", "Brasilia Time", "-03" },
                    { "BIOT", "British Indian Ocean Time", "+06" },
                    { "BST", "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)", "+01" },
                    { "BDT", "Brunei Time", "+08" },
                    { "CVT", "Cape Verde Time", "-01" },
                    { "CAT", "Central Africa Time", "+02" },
                    { "CDT", "Central Daylight Time (North America)", "-05" },
                    { "CEST", "Central European Summer Time (Cf. HAEC)", "+02" },
                    { "CET", "Central European Time", "+01" },
                    { "CIT", "Central Indonesia Time", "+08" },
                    { "ACST", "Central Standard Time (Australia)", "+09:30" },
                    { "CST", "Central Standard Time (North America)", "-06" },
                    { "ACDT", "Central Summer Time (Australia)", "+10:30" },
                    { "CWST", "Central Western Standard Time (Australia) unofficial", "+08:45" },
                    { "CHST", "Chamorro Standard Time", "+10" },
                    { "CHADT", "Chatham Daylight Time", "+13:45" },
                    { "CHAST", "Chatham Standard Time", "+12:45" },
                    { "CLT", "Chile Standard Time", "-04" },
                    { "CLST", "Chile Summer Time", "-03" },
                    { "CST", "China Standard Time", "+08" },
                    { "CT", "China time", "+08" },
                    { "CHOT", "Choibalsan Standard Time", "+08" },
                    { "CHOST", "Choibalsan Summer Time", "+09" },
                    { "CXT", "Christmas Island Time", "+07" },
                    { "CHUT", "Chuuk Time", "+10" },
                    { "CIST", "Clipperton Island Standard Time", "-08" },
                    { "CCT", "Cocos Islands Time", "+06:30" },
                    { "COST", "Colombia Summer Time", "-04" },
                    { "COT", "Colombia Time", "-05" },
                    { "CKT", "Cook Island Time", "-10" },
                    { "", "Coordinated Universal Time", "±00" },
                    { "CDT", "Cuba Daylight Time[4]", "-04" },
                    { "CST", "Cuba Standard Time", "-05" },
                    { "DAVT", "Davis Time", "+07" },
                    { "DDUT", "Dumont d'Urville Time", "+10" },
                    { "EAT", "East Africa Time", "+03" },
                    { "EAST", "Easter Island Standard Time", "-06" },
                    { "EASST", "Easter Island Summer Time", "-05" },
                    { "ECT", "Eastern Caribbean Time (does not recognise DST)", "-04" },
                    { "EDT", "Eastern Daylight Time (North America)", "-04" },
                    { "EEST", "Eastern European Summer Time", "+03" },
                    { "EET", "Eastern European Time", "+02" },
                    { "EGST", "Eastern Greenland Summer Time", "±00" },
                    { "EGT", "Eastern Greenland Time", "-01" },
                    { "EIT", "Eastern Indonesian Time", "+09" },
                    { "AEST", "Eastern Standard Time (Australia)", "+10" },
                    { "EST", "Eastern Standard Time (North America)", "-05" },
                    { "AEDT", "Eastern Summer Time (Australia)", "+11" },
                    { "ECT", "Ecuador Time", "-05" },
                    { "FKST", "Falkland Islands Summer Time", "-03" },
                    { "FKT", "Falkland Islands Time", "-04" },
                    { "FNT", "Fernando de Noronha Time", "-02" },
                    { "FJT", "Fiji Time", "+12" },
                    { "GFT", "French Guiana Time", "-03" },
                    { "FET", "Further-eastern European Time", "+03" },
                    { "GALT", "Galapagos Time", "-06" },
                    { "GIT", "Gambier Island Time", "-09" },
                    { "GAMT", "Gambier Islands", "-09" },
                    { "GET", "Georgia Standard Time", "+04" },
                    { "GILT", "Gilbert Island Time", "+12" },
                    { "GMT", "Greenwich Mean Time", "±00" },
                    { "GST", "Gulf Standard Time", "+04" },
                    { "GYT", "Guyana Time", "-04" },
                    { "HADT", "Hawaii-Aleutian Daylight Time", "-09" },
                    { "HAST", "Hawaii-Aleutian Standard Time", "-10" },
                    { "HMT", "Heard and McDonald Islands Time", "+05" },
                    { "HAEC", "Heure Avancée d'Europe Centrale francised name for CEST", "+02" },
                    { "HKT", "Hong Kong Time", "+08" },
                    { "IOT", "Indian Ocean Time", "+03" },
                    { "IST", "Indian Standard Time", "+05:30" },
                    { "TFT", "Indian/Kerguelen", "+05" },
                    { "ICT", "Indochina Time", "+07" },
                    { "IRDT", "Iran Daylight Time", "+04:30" },
                    { "IRST", "Iran Standard Time", "+03:30" },
                    { "IST", "Irish Standard Time[6]", "+01" },
                    { "IRKT", "Irkutsk Time", "+08" },
                    { "IDT", "Israel Daylight Time", "+03" },
                    { "IST", "Israel Standard Time", "+02" },
                    { "JST", "Japan Standard Time", "+09" },
                    { "USZ1", "Kaliningrad Time", "+02" },
                    { "PETT", "Kamchatka Time", "+12" },
                    { "HOVT", "Khovd Standard Time", "+07" },
                    { "HOVST", "Khovd Summer Time", "+08" },
                    { "KST", "Korea Standard Time", "+09" },
                    { "KOST", "Kosrae Time", "+11" },
                    { "KRAT", "Krasnoyarsk Time", "+07" },
                    { "KGT", "Kyrgyzstan time", "+06" },
                    { "LINT", "Line Islands Time", "+14" },
                    { "LHST", "Lord Howe Standard Time", "+10:30" },
                    { "LHST", "Lord Howe Summer Time", "+11" },
                    { "MIST", "Macquarie Island Station Time", "+11" },
                    { "MAGT", "Magadan Time", "+12" },
                    { "MST", "Malaysia Standard Time", "+08" },
                    { "MYT", "Malaysia Time", "+08" },
                    { "MVT", "Maldives Time", "+05" },
                    { "MART", "Marquesas Islands Time", "-09:30" },
                    { "MIT", "Marquesas Islands Time", "-09:30" },
                    { "MHT", "Marshall Islands", "+12" },
                    { "MUT", "Mauritius Time", "+04" },
                    { "MAWT", "Mawson Station Time", "+05" },
                    { "MEST", "Middle European Summer Time Same zone as CEST", "+02" },
                    { "MET", "Middle European Time Same zone as CET", "+01" },
                    { "MSK", "Moscow Time", "+03" },
                    { "MDT", "Mountain Daylight Time (North America)", "-06" },
                    { "MST", "Mountain Standard Time (North America)", "-07" },
                    { "MMT", "Myanmar Standard Time", "+06:30" },
                    { "NPT", "Nepal Time", "+05:45" },
                    { "NCT", "New Caledonia Time", "+11" },
                    { "NZDT", "New Zealand Daylight Time", "+13" },
                    { "NZST", "New Zealand Standard Time", "+12" },
                    { "NDT", "Newfoundland Daylight Time", "-02:30" },
                    { "NST", "Newfoundland Standard Time", "-03:30" },
                    { "NT", "Newfoundland Time", "-03:30" },
                    { "NUT", "Niue Time", "-11" },
                    { "NFT", "Norfolk Time", "+11" },
                    { "OMST", "Omsk Time", "+06" },
                    { "ORAT", "Oral Time", "+05" },
                    { "PDT", "Pacific Daylight Time (North America)", "-07" },
                    { "PST", "Pacific Standard Time (North America)", "-08" },
                    { "PKT", "Pakistan Standard Time", "+05" },
                    { "PGT", "Papua New Guinea Time", "+10" },
                    { "PYST", "Paraguay Summer Time (South America)[7]", "-03" },
                    { "PYT", "Paraguay Time (South America)[8]", "-04" },
                    { "PET", "Peru Time", "-05" },
                    { "PST", "Philippine Standard Time", "+08" },
                    { "PHT", "Philippine Time", "+08" },
                    { "PHOT", "Phoenix Island Time", "+13" },
                    { "PONT", "Pohnpei Standard Time", "+11" },
                    { "RET", "Réunion Time", "+04" },
                    { "ROTT", "Rothera Research Station Time", "-03" },
                    { "PMDT", "Saint Pierre and Miquelon Daylight time", "-02" },
                    { "PMST", "Saint Pierre and Miquelon Standard Time", "-03" },
                    { "SAKT", "Sakhalin Island time", "+11" },
                    { "SAMT", "Samara Time", "+04" },
                    { "SST", "Samoa Standard Time", "-11" },
                    { "SCT", "Seychelles Time", "+04" },
                    { "SYOT", "Showa Station Time", "+03" },
                    { "SST", "Singapore Standard Time", "+08" },
                    { "SGT", "Singapore Time", "+08" },
                    { "SBT", "Solomon Islands Time", "+11" },
                    { "SAST", "South African Standard Time", "+02" },
                    { "GST", "South Georgia and the South Sandwich Islands", "-02" },
                    { "SRET", "Srednekolymsk Time", "+11" },
                    { "SLST", "Sri Lanka Standard Time", "+05:30" },
                    { "SRT", "Suriname Time", "-03" },
                    { "TAHT", "Tahiti Time", "-10" },
                    { "TJT", "Tajikistan Time", "+05" },
                    { "THA", "Thailand Standard Time", "+07" },
                    { "TLT", "Timor Leste Time", "+09" },
                    { "TKT", "Tokelau Time", "+13" },
                    { "TOT", "Tonga Time", "+13" },
                    { "TRT", "Turkey Time", "+03" },
                    { "TMT", "Turkmenistan Time", "+05" },
                    { "TVT", "Tuvalu Time", "+12" },
                    { "ULAT", "Ulaanbaatar Standard Time", "+08" },
                    { "ULAST", "Ulaanbaatar Summer Time", "+09" },
                    { "UYT", "Uruguay Standard Time", "-03" },
                    { "UYST", "Uruguay Summer Time", "-02" },
                    { "UZT", "Uzbekistan Time", "+05" },
                    { "VUT", "Vanuatu Time", "+11" },
                    { "VET", "Venezuelan Standard Time", "-04" },
                    { "VLAT", "Vladivostok Time", "+10" },
                    { "VOLT", "Volgograd Time", "+04" },
                    { "VOST", "Vostok Station Time", "+06" },
                    { "WAKT", "Wake Island Time", "+12" },
                    { "WAST", "West Africa Summer Time", "+02" },
                    { "WAT", "West Africa Time", "+01" },
                    { "WEST", "Western European Summer Time", "+01" },
                    { "WET", "Western European Time", "±00" },
                    { "WIT", "Western Indonesian Time", "+07" },
                    { "WST", "Western Standard Time", "+08" },
                    { "YAKT", "Yakutsk Time", "+09" },
                    { "YEKT", "Yekaterinburg Time", "+05" }
                });
        }
    }
}
