using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ConnectFeedHistoryDietDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DietId",
                table: "FeedHistories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 475, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 11, 2, 16, 51, 25, 475, DateTimeKind.Local).AddTicks(4158), "kK/bveedKbrJs3Hml2bmFM1LUD5RzrB1tn6aONTER6CBjPHO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 479, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 11, 2, 16, 51, 25, 479, DateTimeKind.Local).AddTicks(3325), "mTGMRWTNJkL2RDOTAKYmSljdr0aIVc7r/adEOlyPuFwwfB1Z" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 483, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 11, 2, 16, 51, 25, 483, DateTimeKind.Local).AddTicks(1371), "N1myHZyC4uj/B3zSCfFfUmmitaxFCCzthuI84uHP/EQBpSNr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 486, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 11, 2, 16, 51, 25, 486, DateTimeKind.Local).AddTicks(9384), "unbznzIO1tz82f8kzoI8kyzqBmfcewwA9FNqJZwRsCOZGoF/" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 490, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 11, 2, 16, 51, 25, 490, DateTimeKind.Local).AddTicks(9768), "4ULiUqZ0MPsLWvWnC3QXD1DQwxXCIkRbbQtovJ/uCI6IDFYR" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 494, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 2, 16, 51, 25, 494, DateTimeKind.Local).AddTicks(8944), "xcXq9AgHqIhRsnZ90/rnBoHmjMclSAwe58xFT08Knlqe17rr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 498, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 11, 2, 16, 51, 25, 498, DateTimeKind.Local).AddTicks(7455), "LE0NaCGIDDpI5NQZM+QbfF6vAyODJWUG8BspSfkp4d/HTR/F" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4952), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4972), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4978), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5010), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5016), new DateTime(2023, 11, 2, 16, 51, 25, 503, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1819), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(523), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(529), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(534), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(542), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(544), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(545), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(551), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(551), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 11, 2, 16, 51, 25, 504, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(209), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(209), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(217), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(227), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 11, 2, 16, 51, 25, 506, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5156), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 2, 16, 51, 25, 505, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 11, 2, 16, 51, 25, 507, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(814), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(820), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(824), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(824), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(827), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(837), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(837), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(840), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(841), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(844), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(846), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(846), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(848), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(848), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(850), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(850), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(852), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(853), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(854), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(855), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(856), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(857), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(858), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(859), new DateTime(2023, 11, 2, 16, 51, 25, 509, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.CreateIndex(
                name: "IX_FeedHistories_DietId",
                table: "FeedHistories",
                column: "DietId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedHistories_Diets_DietId",
                table: "FeedHistories",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedHistories_Diets_DietId",
                table: "FeedHistories");

            migrationBuilder.DropIndex(
                name: "IX_FeedHistories_DietId",
                table: "FeedHistories");

            migrationBuilder.DropColumn(
                name: "DietId",
                table: "FeedHistories");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 567, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 11, 1, 16, 43, 35, 567, DateTimeKind.Local).AddTicks(5889), "IN8jw5GJHXDUIfH9t3JH7j1ce0FvrlexWhOwdW7xi3vXOg5B" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 570, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 11, 1, 16, 43, 35, 570, DateTimeKind.Local).AddTicks(9933), "/xqiJqS6NQd1yvuoPe9Te6Zkqg4DkLkgRA1oV4UhpRekfmwt" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 574, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 11, 1, 16, 43, 35, 574, DateTimeKind.Local).AddTicks(3153), "9iV1sbVi3coPNjejV64/z2YxuxvRHLjYTsESyGP3AeHvgzyN" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 577, DateTimeKind.Local).AddTicks(6412), new DateTime(2023, 11, 1, 16, 43, 35, 577, DateTimeKind.Local).AddTicks(6412), "kYYNpHN6kjjqMlssd04VaGCNwIFKVGxFGXha5I36HaxZd+C/" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 581, DateTimeKind.Local).AddTicks(847), new DateTime(2023, 11, 1, 16, 43, 35, 581, DateTimeKind.Local).AddTicks(848), "sBlD+YgDNWlGHI0u/zO39PvXC3iuIYCstBPP/q0SYEEvVf40" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 584, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 1, 16, 43, 35, 584, DateTimeKind.Local).AddTicks(4904), "bUzoLrNKqUv6KywYgM8R/YD+73xjHKJ7AHGeVyqyu11iAmr4" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 587, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 11, 1, 16, 43, 35, 587, DateTimeKind.Local).AddTicks(8780), "WS1Wcse75SmVLGKXUGeHTe3/pCqJldrH+fJYxstwbQ6t3QZU" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6922), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6927), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6948), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 11, 1, 16, 43, 35, 591, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3461), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3478), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3485), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3486), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3487), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(679), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(683), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(685), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(687), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(689), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(692), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8577), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8586), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8621), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8632), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8633), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5952), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5954), new DateTime(2023, 11, 1, 16, 43, 35, 592, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5432), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5447), new DateTime(2023, 11, 1, 16, 43, 35, 593, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5405), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5409), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5413), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5415), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5417), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5417), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5421), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5421), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5447), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 11, 1, 16, 43, 35, 594, DateTimeKind.Local).AddTicks(5460) });
        }
    }
}
