using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_News : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 82, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 11, 5, 20, 59, 12, 82, DateTimeKind.Local).AddTicks(2547), "BOyachXZhQ4bx3hCZLniVHKgI55J0T47K5R3WmAMgcaz+c2Y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 89, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 11, 5, 20, 59, 12, 89, DateTimeKind.Local).AddTicks(4021), "ts40slVCjDW6BD3KK8zZxbv9D4zoTQjgUq2uHHGJS9EYizcU" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 96, DateTimeKind.Local).AddTicks(1273), new DateTime(2023, 11, 5, 20, 59, 12, 96, DateTimeKind.Local).AddTicks(1287), "bP04WoiDSKpOM0P+S4QTOcgfYB7bdSFCAq1gjAmFvIR0wY1i" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 102, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 5, 20, 59, 12, 102, DateTimeKind.Local).AddTicks(2713), "swW5P79EYn3NpjVQsEi4ao5qzkgtkkHsHCuq7zrtf0O/kv9I" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 107, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 11, 5, 20, 59, 12, 107, DateTimeKind.Local).AddTicks(4964), "AxXZKp8lq5ZHyBxX/qVKdECMUS0cVpSFKBUfJl8Gv2JTFkZc" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 112, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 11, 5, 20, 59, 12, 112, DateTimeKind.Local).AddTicks(6865), "HAkRh7WdQzSFg1v9W1c1P3i1aPSapINzQoxYMwa98nIzWptI" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 119, DateTimeKind.Local).AddTicks(5254), new DateTime(2023, 11, 5, 20, 59, 12, 119, DateTimeKind.Local).AddTicks(5270), "P2WU04vN6T+aQFc6OliNJ5Fae0s3QVEvyp6ZOby837KZ/eSC" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5418), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5431), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5489), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5501), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5511), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5642), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 11, 5, 20, 59, 12, 127, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1027), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8885), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3851), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3906), new DateTime(2023, 11, 5, 20, 59, 12, 128, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7015), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7016), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7024), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7025), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7032), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7036), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7037), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7041), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7046), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7047), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7051), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7052), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7056), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7057), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7072), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7083), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7093), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7098), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7108), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7117), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7118), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2927), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 11, 5, 20, 59, 12, 129, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "CreationDate", "DeletionDate", "ModificationDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, "<p>Get ready to embark on a thrilling adventure as we unveil the most spectacular addition to our zoo - the \"Wild Wonders of the World\" exhibit! This weekend marks the grand opening, and it's an event you won't want to miss. If you have a passion for animals and a love for nature, you're in for a treat that will leave you in awe.</p> <p>The \"Wild Wonders of the World\" exhibit is a testament to the breathtaking diversity of wildlife that inhabits our planet. Step into a realm where the roar of majestic lions resonates, the waddling of playful penguins charms, and the vibrant plumage of colorful parrots dazzles your senses. It's a global journey right here in our own backyard!</p> <p>But there's more to this exhibit than meets the eye. We've designed it to be an immersive and educational experience. As you wander through this extraordinary world, you'll not only witness these amazing creatures up close but also gain insights into their natural habitats, behaviors, and the vital conservation efforts in place to protect them. Discover the stories of resilience and survival that each of these species represents.</p> <p>The excitement doesn't stop there. We've added interactive elements that will bring you closer to the action than ever before. Ever dreamed of feeding a gentle giraffe or having a starfish gently brush against your fingers? It's all possible at \"Wild Wonders of the World.\" Marvel at the agility of monkeys as they swing from tree to tree, and for a truly unforgettable experience, take a ride on a friendly camel. These interactive opportunities will leave you with unforgettable memories to cherish.</p> <p>This isn't just an adventure for individuals &ndash; it's an extraordinary experience that the whole family can enjoy. \"Wild Wonders of the World\" is not only fun but also an excellent educational opportunity for children and adults alike. It's a chance to inspire a love for wildlife and nurture a sense of responsibility towards the natural world.</p> <p>So, mark your calendars and be sure to join us this weekend for the grand opening of the \"Wild Wonders of the World\" exhibit. It's a celebration of the extraordinary beauty and diversity of our planet's wildlife, and we can't wait to share it with you. Your zoo adventure awaits, and it's going to be truly wild and wonderful! See you there!</p>", new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9575), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F05018fb2-b513-4fea-bb21-8f0a1b516349?alt=media&token=b0009275-c21e-414b-a3fa-a95e294902fa", "New Exhibit Unveiling" },
                    { 2, "<p>Looking for a fantastic way to make the most of this season? Look no further, because our zoo has a lineup of exciting events and activities that promise to be a perfect addition to your calendar. Whether you're an animal enthusiast, an advocate for conservation, or simply seeking a fresh and enjoyable experience, there's something here for everyone. Here's a sneak peek at what's coming your way:</p> <p><strong>Animal Shows that Wow:</strong> Step into a world of wonder as our incredible animals take center stage in daily shows that will leave you in awe. Marvel at the artistic prowess of our elephants as they put paint to canvas, witness the graceful balance of our sea lions, and listen in amazement as our talented parrots talk their way into your hearts. Beyond the entertainment, our expert trainers will reveal the secrets of our animals' natural behaviors, habitats, and conservation status. Grab your camera and ensure you capture these unforgettable moments!</p> <p><strong>Educational Programs that Enlighten:</strong> Knowledge is power, and our educational programs are here to empower you. Delve deeper into the animal kingdom and the environment with interactive and informative sessions. Choose from an array of topics that intrigue you, whether it's the remarkable adaptations of animals, the plight of endangered species, the impact of climate change, and so much more. And the best part? You'll get to meet some of our beloved animal ambassadors up close and personal. These programs cater to all ages and levels of interest, making learning a joy for everyone.</p> <p><strong>Festive Fun for the Holidays:</strong> Get into the holiday spirit and celebrate with us! Enjoy a host of special holiday-themed activities that are bound to make your season bright. Decorate cookies alongside our adorable animal friends, craft your own ornaments, and partake in our creative projects. If you're feeling adventurous, join our festive scavenger hunt for a chance to win delightful prizes. And of course, what's the holiday season without a visit from Santa Claus and his trusty reindeer? Get your cameras ready for a magical photo opportunity at our winter wonderland. Please note that these holiday activities are available on select dates, so be sure to visit our website for all the details.</p> <p>We're eager to share these incredible experiences with you, so mark your calendars and plan a visit to our zoo soon. To make the most of your time and budget, be sure to book your tickets online. We can't wait to see you and create unforgettable memories together. See you soon at our zoo!</p>", new DateTime(1960, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9565), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F06984d8f-d83d-4720-9a2b-c952de1f026c?alt=media&token=a1e39c44-45eb-4f70-a391-15dcbf40cab2", "Upcoming Events" },
                    { 3, "<p>At our zoo, we hold a deep commitment to safeguarding the magnificent creatures that grace our grounds and the ecosystems they call home. We understand that the responsibility of conservation extends far beyond our walls, and that's why we've forged partnerships with esteemed local and international organizations to champion critical conservation projects. Together, we work tirelessly to ensure the survival and prosperity of countless species facing threats like climate change, poaching, and habitat loss.</p> <p>Here are some of the remarkable organizations we collaborate with:</p> <ul> <li> <p><strong>The World Wildlife Fund (WWF):</strong> WWF is a global force dedicated to conserving biodiversity and combatting the challenges that imperil our planet. Their focus on preserving ecosystems, preventing habitat destruction, and fighting climate change resonates deeply with our mission.</p> </li> <li> <p><strong>The International Union for Conservation of Nature (IUCN):</strong> IUCN is at the forefront of assessing the status of species and ecosystems. They offer invaluable guidance on the most effective conservation actions required to protect the natural world's wonders.</p> </li> <li> <p><strong>The Association of Zoos and Aquariums (AZA):</strong> AZA sets rigorous standards for animal welfare, education, research, and conservation. By adhering to their accreditation, we ensure that our practices meet the highest ethical and moral standards.</p> </li> <li> <p><strong>The Species Survival Plan (SSP):</strong> SSP plays a crucial role in coordinating breeding programs for endangered species in zoos and aquariums. This coordinated effort helps maintain genetic diversity and safeguards against the specter of extinction.</p> </li> </ul> <p>As a cherished visitor, you too can play a pivotal role in bolstering our conservation endeavors. Here's how you can support our initiatives:</p> <ul> <li> <p><strong>Adopt an Animal:</strong> Embark on a journey of compassion by adopting one of our remarkable animals. Choose from a range of species, and in return, receive a certificate, a captivating photo, and regular updates on your adopted friend. Your adoption fee directly contributes to the care, nourishment, and preservation projects that we champion.</p> </li> <li> <p><strong>Donate to our Conservation Fund:</strong> Your contribution can be a lifeline for the preservation of wildlife. Whether it's a one-time donation or a recurring pledge, your support fuels our ongoing collaborative work with partner organizations. Additionally, we welcome physical donations such as blankets, toys, and enrichment items to enhance the lives of our animal residents.</p> </li> <li> <p><strong>Join our Volunteer Program:</strong> Are you passionate about making a difference? Consider becoming a valued member of our volunteer team. You can assist with vital tasks including animal care, educational outreach, and fundraising. If you're eager to do more, our Conservation Club organizes events and activities to raise awareness and funds for worthy conservation causes.</p> </li> <li> <p><strong>Visit Regularly:</strong> By gracing our zoo with your presence, you are already making a significant contribution to our mission. Your visits support our mission of connecting people with nature and inspire a sense of responsibility for wildlife. While you're here, dive deeper into the animal world by attending our keeper talks, animal encounters, and engaging exhibits to better understand the conservation status of our beloved residents.</p> </li> </ul> <p>We extend our heartfelt gratitude for your support, and we hope your visit to our zoo is not only entertaining but also educational and inspiring. Together, we can ensure that the beauty of the natural world and its incredible inhabitants endure for generations to come. Thank you for being a part of our conservation journey.</p>", new DateTime(1965, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9555), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F06c2acb7-ac5d-4679-bc92-8c25f0816d11?alt=media&token=d98e6adc-4fdf-4a7a-8c4b-e04fd0d73675", "Conservation Efforts: Protecting Wildlife Together" },
                    { 4, "<p>If you've strolled through our zoo, you've probably noticed a lively group of small, furry creatures with a perpetual air of alertness about them. These are the endearing meerkats, among the most sociable and captivating residents of our zoo. In this blog post, we invite you to get to know some of our meerkats and gain insight into their captivating lives in the wild.</p> <p>Meerkats, a part of the mongoose family, hail from the southern regions of Africa. Their lives revolve around close-knit communities known as \"mobs,\" which can comprise up to 50 individuals. Within each mob, a dominant pair takes on the roles of breeding and leading, while other members play vital roles in raising offspring, foraging for sustenance, and guarding the territory.</p> <p>Communication is key in the meerkat world. They employ an array of vocalizations, gestures, and body postures to convey their thoughts and intentions. These tiny creatures exhibit a complex social structure, complete with distinct roles and responsibilities. For instance, some meerkats serve as sentries, diligently scanning the horizon for potential threats and swiftly alerting their comrades with alarm calls. Others engage in the crucial task of digging burrows, providing shelter and protection for the mob. Meerkats also engage in communal grooming, frolic together, and generously share their meals.</p> <p>Perhaps the most remarkable aspect of meerkats is their ability to thrive in challenging environments. They are well-suited to arid and semi-arid regions where water and vegetation are in short supply. Meerkats are highly adaptable to high temperatures and low oxygen levels. Their distinct dark patches around the eyes serve to reduce sun glare, and their elongated claws make them expert diggers, enabling them to unearth insects, their primary source of nourishment.</p> <p>While meerkats are not currently endangered, they do confront looming threats such as habitat loss, human-wildlife conflicts, and the impacts of climate change. At our zoo, we actively participate in conservation endeavors designed to safeguard meerkats and the habitats they call home. Additionally, we lend our support to research projects aimed at unraveling the mysteries of their behavior, ecology, and genetics.</p> <p>We trust that you've enjoyed this delightful glimpse into the world of our meerkats. During your next visit to our zoo, be sure to make a stop at their exhibit, and don't hesitate to introduce yourself. Meerkats are known for their warm reception to new faces and their enthusiasm for engaging with our visitors. For those who wish to take their support a step further, consider adopting a meerkat through our sponsorship program. Your contribution goes a long way in ensuring that our meerkats receive the best possible care. We extend our heartfelt thanks for your enduring interest and support for our remarkable animal residents.</p>", new DateTime(1970, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9542), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Fa138710d-46ca-49ee-9318-8efd79b5b3cd?alt=media&token=632aa54d-356b-4a9b-a71c-04a4852fa059", "Animal Spotlights: Meet the Meerkats – The Social Wonders of Southern Africa" },
                    { 5, "<p>Ever wondered what it's like to feed a hippo? Join us on this exclusive journey behind the scenes of our hippo habitat, where we reveal the secrets to keeping our massive friend happy and healthy.</p> <p>Hippos, despite their fearsome reputation, are herbivores, meaning they have a plant-based diet. But don't be fooled by their imposing size &ndash; they're not nibbling on a few leaves here and there. In fact, they can chow down on a staggering 150 pounds of food daily. That's a whole lot of salad!</p> <p>To ensure our hippo's well-being, we start each day by meticulously preparing a specialized mix of hay, alfalfa, fruits, and vegetables. The produce is expertly chopped into bite-sized morsels and placed into a sizeable bucket. We also incorporate vitamins and supplements to guarantee that he receives all the essential nutrients his body demands.</p> <p>Maintaining a healthy weight is crucial for hippos, as excess pounds can lead to health complications. Regular weigh-ins are part of our routine, allowing us to fine-tune his diet as needed. Currently, our male hippo tips the scales at around 3,000 pounds, which is perfectly normal for his kind.</p> <p>Once the meal is ready, we head over to the hippo's enclosure and call out his name. He's usually quick to respond, eagerly anticipating feeding time. He's a sociable and inquisitive fellow, often greeting us with a comical yawn, which reveals his colossal teeth and jaw capable of crushing a watermelon in a single bite!</p> <p>The food is gently tossed into the water where he prefers to eat. He lowers his head beneath the surface, using his lips like a conveyor belt to scoop up the delicious morsels. Remarkably, he can hold his breath for up to five minutes, so he doesn't need to surface frequently. While dining, he can make some amusing noises, including grunts and snorts, and occasionally, a distinctive burp!</p> <p>Feeding a hippo is no small task, but it's undeniably rewarding. Witnessing his delight as he enjoys his meal and observing his growth and vitality is a source of immense joy for us. He's truly one of our beloved zoo residents, and we eagerly await your visit to meet this incredible creature up close. Come and see him soon!</p>", new DateTime(1975, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9532), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F5d156179-6351-4750-ad53-49b8afce2cd4?alt=media&token=1de7c042-83ff-4844-82de-4d0d6e049e95", "Behind-the-Scenes: A Hippo's Daily Feast" },
                    { 6, "<p>Greetings, fellow animal enthusiasts! Welcome to another captivating blog post from your beloved zoo. Today, we're excited to share some of the ways in which our zoo actively engages with and makes a meaningful difference in the local community, leaving a positive imprint on the lives of people and animals alike.</p> <p><strong>Educational Partnerships with Local Schools: Fostering Young Minds</strong></p> <p>One of our most cherished endeavors is our partnership with schools in the area. We extend a warm welcome to students of all ages, ranging from preschool to college. Our educational programs are thoughtfully designed to immerse them in the realm of wildlife conservation, animal behavior, and the captivating world of zoo careers. We offer enriching field trips, hands-on workshops, and immersive camps that provide young learners with an up-close experience of our animals and dedicated staff. Witnessing their curiosity and awe as they uncover the marvels of the natural world is a source of immense joy for us.</p> <p><strong>Supporting Charitable Causes: Nurturing Compassion and Generosity</strong></p> <p>Our commitment to the community extends to supporting various charitable causes. We wholeheartedly engage in fundraisers, make generous donations, and lend our time and energy to volunteer activities that directly benefit local organizations, including food banks, shelters, and hospitals. Beyond our local efforts, we sponsor events and initiatives that raise awareness and vital funds for pressing global concerns such as climate change, habitat loss, and the devastating effects of poaching. We firmly believe that our zoo holds a profound responsibility to assist those in need, whether human or animal.</p> <p><strong>Join Us in Our Mission: Make a Difference Today!</strong></p> <p>We trust that this glimpse into our community involvement has inspired you to consider joining us in our mission. Whether you decide to pay a visit to our zoo, extend a helping hand by contributing to our worthy causes, or simply spread the word about our work, you are actively participating in creating a positive impact. We are profoundly grateful for your support, and we eagerly await your presence at our zoo, where every visit helps us fulfill our mission of connecting people with the incredible world of animals. Thank you for being an integral part of our shared journey!</p>", new DateTime(1980, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9522), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Fef920db9-b125-4372-9e8e-896f10dc9950?alt=media&token=645e4956-2560-47f6-8674-22932e5a9c7d", "Community Involvement: How Our Zoo Creates a Positive Impact!" },
                    { 7, "<p>If you're on the lookout for an unforgettable day of fun and learning, a trip to our zoo should be at the top of your list. With over 500 captivating animals from every corner of the globe, including rare and endangered species, there's an adventure waiting for everyone. Get up close, unravel the secrets of their habitats and behaviors, and even partake in interactive exhibits that bring you face to face with the wonders of the animal kingdom. But don't just take our word for it &ndash; here are the stories and reviews from some of our recent visitors who shared their remarkable experiences:</p> <p><strong>Sarah, 35:</strong> \"I had a blast at the zoo with my kids. They loved seeing the lions, tigers, and bears (oh my!). They also enjoyed feeding the giraffes and petting the goats. The staff was very friendly and helpful, and the zoo was clean and well-maintained. I highly recommend this zoo to anyone who loves animals.\"</p> <p><strong>Lisa, 28:</strong> \"My husband and I visited the zoo for our anniversary. We were impressed by the variety and quality of the animals. We especially liked the penguins, who were very cute and playful. We also appreciated the conservation efforts of the zoo, which supports many projects to protect wildlife and habitats around the world. The zoo was a great place to spend a romantic day.\"</p> <p><strong>Jake, 10:</strong> \"I went to the zoo with my school group. We had a lot of fun learning about different animals and their adaptations. We also got to participate in some activities, like making animal masks and playing animal trivia. The zoo was very educational and entertaining. I would love to go back again.\"</p> <p>Our zoo is not just a place to observe animals; it's a platform for exploration, discovery, and shared moments of wonder. Whether you're seeking a family adventure, a romantic day out, or an educational experience for students, our zoo has something to offer. Come and join us for an unforgettable journey into the world of wildlife, and see why these enthusiastic visitors have such fond memories to share. We can't wait to welcome you and create your own unforgettable moments at our zoo!</p>", new DateTime(1985, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9512), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F51c1ed40-2999-40fd-8cc4-a0ee0e9eeb0b?alt=media&token=adee6d94-1c24-48d3-bafe-08d21bc5e14b", "Discover the Magic of Our Zoo: Where Fun and Learning Unite!" },
                    { 8, "<p>If you're passionate about animals and fascinated by their habitats, behaviors, and conservation efforts, then we invite you to join us in celebrating the anniversaries of our beloved zoo!</p> <p>Our zoo boasts a storied history, marked by an unwavering commitment to providing education, entertainment, and vital research opportunities for the public. It all began in 1898 when a dedicated group of animal enthusiasts founded the Zoological Society of London, with a noble mission &ndash; to assemble a collection of living animals for scientific study. In 1902, our doors opened to the public, unveiling an impressive display of over 600 animals from all corners of the world.</p> <p>Over the years, our zoo has blossomed and transformed, embracing new exhibits, state-of-the-art facilities, and innovative programs to meet the ever-evolving needs and interests of our visitors. Let's take a stroll through the pages of our history, highlighting some of our most significant milestones:</p> <ul> <li> <p><strong>1914:</strong> Pioneering the way, our zoo became the world's first to introduce a children's zoo, a place where youngsters could interact with farm animals and learn essential lessons about animal care.</p> </li> <li> <p><strong>1931:</strong> We unveiled our iconic Reptile House, housing a captivating array of snakes, lizards, turtles, and crocodiles. This renowned institution made its mark in popular culture when it served as the setting for a scene in the first Harry Potter movie, where Harry discovered his unique ability to communicate with snakes.</p> </li> <li> <p><strong>1957:</strong> A global sensation, our zoo welcomed its first giant panda, Chi Chi. This charismatic ambassador for wildlife conservation left an indelible mark and even became the symbol of the World Wildlife Fund, with her image gracing their logo.</p> </li> <li> <p><strong>1976:</strong> Our commitment to conservation reached new heights with the establishment of our Conservation Programmes department. This visionary initiative coordinates research and conservation projects worldwide, working hand in hand with local communities and organizations to protect endangered species and their precious habitats, from gorillas in Africa to tigers in Asia and penguins in Antarctica.</p> </li> <li> <p><strong>1999:</strong> We introduced the immersive Rainforest Life exhibit, bringing the magic of the tropical rainforest to our visitors. Here, they can marvel at monkeys, sloths, armadillos, bats, birds, and a vibrant tapestry of insects.</p> </li> <li> <p><strong>2007:</strong> The opening of our Gorilla Kingdom exhibit marked a significant step forward in animal welfare and conservation education. This expansive, naturalistic habitat is home to a group of western lowland gorillas, offering visitors a unique insight into the challenges facing these magnificent creatures in the wild.</p> </li> <li> <p><strong>2016:</strong> Our Land of the Lions exhibit whisked visitors away to India's Gir Forest National Park, where Asiatic lions roam. This exhibit recreates the Indian landscape, complete with a replica Indian village, a train station, a temple ruin, and a high-tech lion lookout.</p> </li> </ul> <p>These are just a few of the captivating moments from our storied history. With each passing year, we remain dedicated to enhancing our standards for animal welfare, visitor experience, and conservation impact. This year, we proudly celebrate our 125th anniversary with an array of special events and activities throughout the year.</p> <p>If you're eager to join us in commemorating our zoo's anniversaries, explore our website for details on upcoming events. You can also contribute to our mission by becoming a member, adopting an animal, or making a donation. We extend our heartfelt thanks for your unwavering interest and support. Together, we'll continue making strides in the name of wildlife preservation and education. Thank you for being part of our journey!</p>", new DateTime(1990, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9499), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2F98f147ca-bb36-4ddb-a685-b981df3df7b2?alt=media&token=98198653-b4b6-46ca-86b1-cb9776f92094", "Zoo Anniversaries: A Journey Through Time" },
                    { 9, "<p>At our zoo, one of our primary missions is to educate the public about the profound significance of wildlife conservation and the welfare of our animal friends. We firmly believe that by providing captivating and informative experiences to our visitors, we can ignite a passion for the natural world and its remarkable inhabitants. In this blog post, we aim to shed light on some of the educational facets of our zoo, from enriching school programs to engaging workshops, and how our institution actively contributes to wildlife education.</p> <p><strong>School Programs: Cultivating Curiosity</strong></p> <p>Our zoo offers an array of meticulously crafted school programs, catering to students of various ages and academic levels. These programs encompass guided tours, intimate animal encounters, hands-on activities, and curriculum-aligned lessons adhering to national educational standards. Our goal is to enhance students' understanding of a multitude of wildlife-related topics, including biodiversity, adaptation, ecology, behavior, and the vital importance of conservation. To further assist educators, we provide pre- and post-visit materials to aid in lesson planning and reinforce the concepts learned during their visit.</p> <p><strong>Workshops: Fostering Lifelong Learning</strong></p> <p>For individuals seeking in-depth knowledge or hands-on experiences, our workshops provide a valuable opportunity to delve deeper into specific animal species or aspects of wildlife. These workshops are led by our expert staff and passionate volunteers, who generously share their wisdom and dedication with participants. Among the diverse range of workshops we offer are:</p> <ul> <li><strong>Animal Care 101:</strong> Gain insights into the comprehensive care provided to the animals at our zoo, encompassing everything from feeding and grooming to the implementation of enrichment activities and training.</li> <li><strong>Wildlife Photography:</strong> Unleash your inner wildlife photographer and discover the art of capturing breathtaking images of animals in their natural environments. Our professional photographers provide valuable tips and techniques.</li> <li><strong>Conservation Action:</strong> Discover ways to make a meaningful impact in the realm of wildlife conservation. Learn about personal actions, ranging from reducing one's environmental footprint to actively supporting local and global initiatives.</li> </ul> <p><strong>Our Zoo's Contribution to Wildlife Education: Making a Difference</strong></p> <p>Beyond offering educational programs and workshops, our zoo plays a vital role in advancing wildlife education through several significant avenues:</p> <ul> <li> <p><strong>Research and Studies:</strong> We actively engage in research projects and studies that expand our understanding of the animals in our care and their counterparts in the wild.</p> </li> <li> <p><strong>Collaboration:</strong> Our zoo collaborates with other like-minded institutions and conservation organizations to share information and best practices regarding animal management and welfare.</p> </li> <li> <p><strong>Conservation Support:</strong> We are committed to supporting conservation efforts worldwide by raising both funds and awareness for endangered species and their fragile habitats.</p> </li> <li> <p><strong>Advocacy:</strong> Our mission extends to advocating for animal rights and welfare. We are dedicated to educating the public about the multifaceted threats and challenges that wildlife faces in today's world.</p> </li> </ul> <p>We trust that this glimpse into our educational initiatives has conveyed our unwavering commitment to inspiring wildlife awareness. We cordially invite you to visit our zoo and experience the magic of these programs firsthand. Your interest and support are deeply valued, and we look forward to welcoming you soon. Thank you for being a part of our mission to protect and educate about the extraordinary creatures with whom we share our planet.</p>", new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9487), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Fcca4472d-5174-4581-968a-0239ce717c7e?alt=media&token=02fa5dd6-a7dd-48d8-b9fe-74b6d31d4bb6", "Education and Learning: Inspiring Wildlife Awareness at Our Zoo" },
                    { 10, "<p>Greetings, fellow animal enthusiasts! Welcome to another captivating blog post from your beloved zoo. Today, we're excited to share some of the ways in which our zoo actively engages with and makes a meaningful difference in the local community, leaving a positive imprint on the lives of people and animals alike.</p> <p><strong>Educational Partnerships with Local Schools: Fostering Young Minds</strong></p> <p>One of our most cherished endeavors is our partnership with schools in the area. We extend a warm welcome to students of all ages, ranging from preschool to college. Our educational programs are thoughtfully designed to immerse them in the realm of wildlife conservation, animal behavior, and the captivating world of zoo careers. We offer enriching field trips, hands-on workshops, and immersive camps that provide young learners with an up-close experience of our animals and dedicated staff. Witnessing their curiosity and awe as they uncover the marvels of the natural world is a source of immense joy for us.</p> <p><strong>Supporting Charitable Causes: Nurturing Compassion and Generosity</strong></p> <p>Our commitment to the community extends to supporting various charitable causes. We wholeheartedly engage in fundraisers, make generous donations, and lend our time and energy to volunteer activities that directly benefit local organizations, including food banks, shelters, and hospitals. Beyond our local efforts, we sponsor events and initiatives that raise awareness and vital funds for pressing global concerns such as climate change, habitat loss, and the devastating effects of poaching. We firmly believe that our zoo holds a profound responsibility to assist those in need, whether human or animal.</p> <p><strong>Join Us in Our Mission: Make a Difference Today!</strong></p> <p>We trust that this glimpse into our community involvement has inspired you to consider joining us in our mission. Whether you decide to pay a visit to our zoo, extend a helping hand by contributing to our worthy causes, or simply spread the word about our work, you are actively participating in creating a positive impact. We are profoundly grateful for your support, and we eagerly await your presence at our zoo, where every visit helps us fulfill our mission of connecting people with the incredible world of animals. Thank you for being an integral part of our shared journey!</p>", new DateTime(2000, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9475), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Fef920db9-b125-4372-9e8e-896f10dc9950?alt=media&token=645e4956-2560-47f6-8674-22932e5a9c7d", "Community Involvement: How Our Zoo Creates a Positive Impact!" },
                    { 11, "<p>Greetings, fellow animal enthusiasts! We're delighted to share some thrilling news with you today. Over the past month, our zoo has been graced by the arrival of some delightful and charming new additions to our animal family, and we can hardly contain our excitement. It's time for you to meet them and share in the joy!</p> <p><strong>Baby Otter Twins: A Splash of Playfulness</strong></p> <p>First and foremost, let us introduce you to the newest members of our otter family. Born on October 15th, these two adorable baby otters are the offspring of our beloved resident otters, Ollie and Olive, who have been a part of our zoo since 2019. These little ones are healthy, full of life, and absolutely enchanting. They can often be spotted indulging in their favorite activities, such as swimming and cuddling with their doting parents. While they haven't been named yet, we're giving you the chance to participate in a naming contest for the otter twins. Share your suggestions on our website or social media pages, and the lucky winners will be rewarded with a free family pass to the zoo and an unforgettable opportunity to meet these otterly charming little creatures up close.</p> <p><strong>Pogo the Penguin: A Survivor's Tale</strong></p> <p>Our penguin colony has welcomed a remarkable new member &ndash; Pogo, a four-year-old king penguin with an inspiring story. Pogo was rescued from a fishing net in the icy waters of Antarctica and brought to our zoo by a team of dedicated wildlife experts who nursed him back to health. This friendly and inquisitive penguin has already forged bonds with his fellow penguins and enjoys engaging with our visitors. You can catch Pogo at the Penguin Plaza every day at 10 am and 2 pm, where he eagerly awaits his favorite fish during feeding time.</p> <p><strong>Gigi the Giraffe: A Graceful Guest</strong></p> <p>Joining us for the next six months is a very special guest, Gigi, a three-year-old giraffe hailing from a zoo in South Africa. Gigi's visit is part of an exchange program that aims to promote genetic diversity and the conservation of giraffes in captivity. She is a magnificent sight, tall and graceful, with a distinctive pattern of spots on her coat. Gigi is known for her gentle nature and her love for feasting on leaves from the trees. You can pay her a visit at the Giraffe Garden, where she will be sharing her enclosure with our resident giraffes, Gary and Grace.</p> <p>We hope that you share our enthusiasm for these recent animal births and adoptions. They underscore our unwavering commitment to providing a safe and enriching environment for our animals, while simultaneously serving as a source of education and inspiration for our visitors in the realm of wildlife conservation. We warmly invite you to come and witness these incredible additions firsthand and celebrate their arrival with us. Additionally, we have a host of special events lined up for the upcoming weeks, including engaging animal talks, creative crafts, entertaining games, and much more. For further details, please refer to our website or newsletter. Your support is invaluable, and we eagerly await your visit to the zoo. Thank you for being an essential part of our journey!</p>", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9459), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Faf050a82-5903-4439-bfc8-e8546e8de35d?alt=media&token=99edc690-8cc7-418c-81a6-25216cbd48ed", "Exciting Additions to Our Zoo Family: Meet Our New Animal Friends!" },
                    { 12, "<p>Hello, fellow zoo enthusiasts! We're thrilled to share some extraordinary news with you today. Our zoo has been showered with accolades from esteemed organizations, recognizing our exceptional contributions in animal care, conservation, education, and research. Here's a glimpse of the awards and acknowledgments we've recently received and what they signify for our beloved zoo.</p> <ul> <li><strong>AZA Accreditation: The Gold Standard</strong></li> </ul> <p>We're immensely proud to announce that we have earned accreditation from the Association of Zoos and Aquariums (AZA), which stands as the gold standard for zoos and aquariums in North America. This prestigious recognition signifies that we consistently meet or surpass the highest benchmarks in animal welfare, veterinary care, conservation efforts, education programs, and safety standards. Notably, only 10% of zoos and aquariums in the United States bear the AZA accreditation, and we are privileged to be among this distinguished group.</p> <ul> <li><strong>Humane Certified&trade; Seal: A Commitment to Ethical Treatment</strong></li> </ul> <p>Our zoo has been bestowed with the Humane Certified&trade; seal by American Humane, the nation's foremost humane organization. This esteemed recognition underscores our unwavering dedication to providing humane and ethical treatment of our cherished animals. To earn this seal, we successfully navigated rigorous third-party audits that validated our commitment to upholding the highest ethical standards in animal care. Remarkably, we are among just 80 zoos and aquariums globally that have earned this prestigious certification.</p> <ul> <li><strong>Conservation Partner with WWF: A Global Commitment</strong></li> </ul> <p>We are thrilled to be named a Conservation Partner by the World Wildlife Fund (WWF), the premier global conservation organization. This recognition highlights our steadfast support for WWF's worldwide endeavors to safeguard endangered species and their habitats. Additionally, it underscores our commitment to actively engage our visitors and community in conservation initiatives. We are one of the exclusive 30 zoos and aquariums in the United States to have the privilege of this partnership.</p> <ul> <li><strong>Excellence in Education Award from ASTC: Inspiring Curiosity</strong></li> </ul> <p>Our dedication to education and inspiring curiosity has been acknowledged with the prestigious Excellence in Education Award by the Association of Science-Technology Centers (ASTC), the largest global organization of science centers and museums. This recognition underscores our commitment to offering top-notch educational programs and experiences that ignite curiosity, promote discovery, and facilitate learning about science and the wonders of nature. Impressively, we are one of only 10 science centers and museums in the United States to have received this esteemed award.</p> <p>These awards and recognitions serve as a testament to our unwavering commitment, dedication, and passion for our mission. They are a source of inspiration and motivation for us to continue striving for excellence and innovation in our endeavors. We extend our heartfelt gratitude to our dedicated staff, passionate volunteers, generous donors, loyal members, and enthusiastic visitors, for without your steadfast support, these achievements would not be possible.</p> <p>Thank you for being an integral part of our extended zoo family. We eagerly anticipate your visit, and we hope to see you soon!</p>", new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 20, 59, 12, 130, DateTimeKind.Local).AddTicks(9352), "https://firebasestorage.googleapis.com/v0/b/uploadimage-16a8b.appspot.com/o/news_thumbnail%2Fc35bf782-70f8-447b-b484-81d5b2eb476d?alt=media&token=37a590c8-8157-4a4d-ac3e-539e497af8c0", "Celebrating Excellence: Our Zoo's Recent Awards and Recognitions" }
                });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2022), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2045), new DateTime(2023, 11, 5, 20, 59, 12, 131, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7502), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7503), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7524), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7527), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7528), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7535), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7535), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7538), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7543), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7547), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7554), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7557), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7558), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7561), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7562), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7565), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7566), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7568), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7569), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7572), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 11, 5, 20, 59, 12, 132, DateTimeKind.Local).AddTicks(7571) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12);

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
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8163), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8181), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 11, 2, 21, 4, 37, 54, DateTimeKind.Local).AddTicks(8184) });

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
    }
}
