using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Cage_Avt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 28, DateTimeKind.Local).AddTicks(9567), new DateTime(2023, 11, 2, 21, 4, 37, 28, DateTimeKind.Local).AddTicks(9584), "lgNKN9KYohQzzrmdBpyWn8Q5+uUwk3G+xO1ko+OQQ44FpPWn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 32, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 11, 2, 21, 4, 37, 32, DateTimeKind.Local).AddTicks(3755), "P5zHdw81AZGCDGBoLot1dTgoJtGxlf8zLYBH4fCfhViYaNhf" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 35, DateTimeKind.Local).AddTicks(6377), new DateTime(2023, 11, 2, 21, 4, 37, 35, DateTimeKind.Local).AddTicks(6378), "ECYp+eUL2keeF9upt9xLBIbJwW67okM/o0sKgUIcq1LnUWq8" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 39, DateTimeKind.Local).AddTicks(756), new DateTime(2023, 11, 2, 21, 4, 37, 39, DateTimeKind.Local).AddTicks(770), "dhp9XeX0YduSPb7f4yQ5V5uTtq67FmZaSpoIwrjkQ8DmZobE" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 43, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 11, 2, 21, 4, 37, 43, DateTimeKind.Local).AddTicks(3101), "V3x8DpTg1o/+jqp9Drsasb+6e/HLsG9tFVCvVtFRE1tJ0NNw" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 46, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 11, 2, 21, 4, 37, 46, DateTimeKind.Local).AddTicks(7794), "eTPRRQBzqKd7OGE0AY9CGB0DWzhycnPF1gQ6wQSQxUc9m2qY" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 50, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 11, 2, 21, 4, 37, 50, DateTimeKind.Local).AddTicks(3651), "zNiQKIpE00M/Me+nYzwEDT1q6wUCh6NJ86+nZaN7OmV/ofHc" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4067), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4129), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4135), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4140), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4145), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6705), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6708), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6713), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(880), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(882), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(883), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(885), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(885), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(888), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(889), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(893), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(898), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(898), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(902), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(902), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(904), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(904), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(907), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(908), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(914), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8156), "https://i.pinimg.com/736x/7e/90/d7/7e90d7179d7c55a5f8a9f868d00b1b7a.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8163), "https://i.pinimg.com/736x/6c/16/68/6c166887958e66c8e3b01a7e84a425b7.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8166), "https://i.pinimg.com/736x/3e/cb/a3/3ecba328f8dff176289a8d3fd9d81059.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8168), "https://i.pinimg.com/236x/6d/d2/62/6dd26201a3938ca84937edbc98531d66.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8172), "https://i.pinimg.com/736x/b9/c3/d3/b9c3d39666b871e2ab805c71c0747be4.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8174), "https://i.pinimg.com/736x/fe/4b/2a/fe4b2aee3aa2d9339c70e901bb67e4f0.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8176), "https://i.pinimg.com/736x/54/f0/b1/54f0b14281c56c4933a43dbcda2efbbe.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8179), "https://i.pinimg.com/736x/24/93/01/24930132c3e7bb452e2e49cef68f4e56.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8181), "https://i.pinimg.com/736x/18/fd/af/18fdaf68d166b9911cca446adb0f3f58.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8184), "https://i.pinimg.com/736x/4d/af/35/4daf352008585dc28fe1790e4f5245ac.jpg", new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5125), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5139), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 2, 21, 4, 37, 55, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 11, 2, 21, 4, 37, 56, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(119), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(119), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(127), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(127), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(131), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(131), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(134), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(139), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 11, 2, 21, 4, 37, 57, DateTimeKind.Local).AddTicks(153) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 587, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 11, 2, 20, 45, 56, 587, DateTimeKind.Local).AddTicks(5469), "CbwkezcrryrXlRTF5EgkhsMUPmIPBb32WnYMuzAE6ZplN1be" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 591, DateTimeKind.Local).AddTicks(746), new DateTime(2023, 11, 2, 20, 45, 56, 591, DateTimeKind.Local).AddTicks(756), "lTNOnDLEaWhDuvOKcdopG60WR23i1FfAKlSnqWUycaBqhtFc" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 594, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 11, 2, 20, 45, 56, 594, DateTimeKind.Local).AddTicks(3655), "p8vA2cgpP+loBPrWzWa2hcPTRHUsp3Zhofc9jcKdzt/x64Un" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 597, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 11, 2, 20, 45, 56, 597, DateTimeKind.Local).AddTicks(7481), "fD82wz2HtTYzH3BfDsNBZ3L0eTyQ9vYtx4Jxp7dd8Rnswkl0" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 601, DateTimeKind.Local).AddTicks(1349), new DateTime(2023, 11, 2, 20, 45, 56, 601, DateTimeKind.Local).AddTicks(1353), "hE7taR9VHKgaHnVEmvR//nEdvwnghJNrakZsxZfofdtah24M" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 604, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 11, 2, 20, 45, 56, 604, DateTimeKind.Local).AddTicks(5291), "0RqyblE9qlcrcE+BxYaPlC8cRMIAmfxjCSatE0v4na6irafl" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 607, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 11, 2, 20, 45, 56, 607, DateTimeKind.Local).AddTicks(8078), "/2dmzVH+fgkN1WKCigYpkP1u0ljf9iBwY84vJ+xgQtMaTJ0P" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(6933), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7043), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7052), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7058), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7065), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7111), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7116), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7121), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7126), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7132), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7143), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 11, 2, 20, 45, 56, 611, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(598), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(609), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(613), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(615), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8014), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8014), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8016), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8016), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8022), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8023), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8024), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8028), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8029), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8029), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4217), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4229), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4232), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4234), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4237), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4239), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4242), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4244), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4246), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4248), null, new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2880), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(465), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 11, 2, 20, 45, 56, 613, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(331), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(333), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(336), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(341), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7779), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7779), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 11, 2, 20, 45, 56, 614, DateTimeKind.Local).AddTicks(7780) });
        }
    }
}
