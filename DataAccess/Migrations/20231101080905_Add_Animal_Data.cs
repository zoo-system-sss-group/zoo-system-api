using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Animal_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 875, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 11, 1, 15, 9, 4, 875, DateTimeKind.Local).AddTicks(2726), "DNQkxEhqxl8YdNZv65qcD+AoHZuNwfs/LZm6OQAmnDzq/ARW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 880, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 11, 1, 15, 9, 4, 880, DateTimeKind.Local).AddTicks(1346), "ljh9AEpjxyBiuZR3CTRmlOwlI5BLH3HXDUw3hbuzRhMvbQMm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 884, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 11, 1, 15, 9, 4, 884, DateTimeKind.Local).AddTicks(4484), "nr+N+ibPMHPe/98QqnYB/g7OcHgppE4ys35IgmHTUs7TF+Qr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 888, DateTimeKind.Local).AddTicks(707), new DateTime(2023, 11, 1, 15, 9, 4, 888, DateTimeKind.Local).AddTicks(711), "zASbpYm3HLTkgoBqQTMG/qDCBV0+sHTb0sv99jW2E/f+mUda" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 892, DateTimeKind.Local).AddTicks(3090), new DateTime(2023, 11, 1, 15, 9, 4, 892, DateTimeKind.Local).AddTicks(3102), "Z7DyPhmZfgBnAndY1ChR4/rHfWIJwGwh1rsBvsDB27JheVtN" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 896, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 11, 1, 15, 9, 4, 896, DateTimeKind.Local).AddTicks(8759), "HZMzAv9Au0Ys4XNbb7gCrWfaKy50bMykyafTmSxk8+LEAvZp" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(5982), "https://i.pinimg.com/564x/db/40/00/db40008ec6c5e2d789834f67359eee44.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6168), "https://i.pinimg.com/564x/1c/d5/9d/1cd59d96db28e0cbf5e88270bac8fb34.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6188), "https://i.pinimg.com/564x/fb/b9/fb/fbb9fb9a5f8f9f2d4244ad7c2bb1b6fe.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6198), "https://i.pinimg.com/564x/9c/ee/58/9cee58f97470496aa9b99ac613125a5c.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6212), "https://i.pinimg.com/564x/ae/3c/24/ae3c24f7dbd9e9ba721a3b76fec1c32b.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6224), "https://i.pinimg.com/564x/5a/4c/15/5a4c15238fce3e4e1c5405965c1a7237.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6234), "https://i.pinimg.com/564x/7a/51/b9/7a51b95ffc4d7cbac381c30cc5fbe077.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6246), "https://i.pinimg.com/564x/0c/6c/eb/0c6ceb9b063baff86c11b7e1f696bf04.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6259), "https://i.pinimg.com/564x/52/91/cf/5291cf756d15a62f4b8b717e154ca37e.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6271), "https://i.pinimg.com/564x/99/bf/a4/99bfa449a463241b88739980663738d0.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6282), "https://i.pinimg.com/564x/4e/26/37/4e26371ca9dfefc559fff95d041d911b.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6291), "https://i.pinimg.com/564x/77/f9/6c/77f96c07e4682b864bd8c1815da37aa7.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6358), "https://i.pinimg.com/564x/bb/81/9e/bb819e828e69a7b74d0efec858df28ff.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6370), "https://i.pinimg.com/564x/a1/af/f6/a1aff62d5b61c8ff2d9fd1128f4ae8c7.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6381), "https://i.pinimg.com/564x/5b/a3/b2/5ba3b2ac8ca269f8c111255b03ee2224.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6393), "https://i.pinimg.com/736x/cb/86/34/cb8634141686341ac17d6a99b0ec4d5d.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6403), "https://i.pinimg.com/564x/25/10/b7/2510b768ba2867870004f6a05f3a8484.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6414), "https://i.pinimg.com/564x/05/b5/41/05b541cd74e53a88bc086a841727cf92.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6425), "https://i.pinimg.com/564x/ea/b4/67/eab467dd41563c6658fec4a730f78e90.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6435), "https://i.pinimg.com/564x/86/e0/33/86e03347fd80983cc6a19bfe75d49620.jpg", new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9237), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9249), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9252), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9253), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9259), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9266), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9272), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9276), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9278), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9285), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9285), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9288), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4908), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4917), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4921), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4925), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4933), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 11, 1, 15, 9, 4, 904, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7678), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7689), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7694), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7699), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7709), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7713), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7726), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2728), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2749), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 11, 1, 15, 9, 4, 905, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2416), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2446), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 11, 1, 15, 9, 4, 907, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3295), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3296), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3300), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3308), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3342), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 11, 1, 15, 9, 4, 909, DateTimeKind.Local).AddTicks(3422) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 4, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 10, 31, 17, 14, 58, 4, DateTimeKind.Local).AddTicks(7561), "GAfOe0DXd8CtbgRYdXodoaqoE8it7+v+lc+N5eNIZjpzyjo/" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 8, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 10, 31, 17, 14, 58, 8, DateTimeKind.Local).AddTicks(2773), "p1HmMQgkWeeAIOmJqx+W3FPbplb4Jp5uV7l8PVv/OrVQfhJQ" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 11, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 10, 31, 17, 14, 58, 11, DateTimeKind.Local).AddTicks(7086), "j+sBa04XdxJEKjU58QoHwOQPC5Ud+AQ0R+rg1IScgQfNkeSp" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 15, DateTimeKind.Local).AddTicks(975), new DateTime(2023, 10, 31, 17, 14, 58, 15, DateTimeKind.Local).AddTicks(982), "dq+lEEyqM0Vn0YNLS8h3tePyaTqnv6RIUXwpN+SzdSCQSBOd" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 18, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 10, 31, 17, 14, 58, 18, DateTimeKind.Local).AddTicks(6805), "SiLD9no18oGmI8eKLntGL67YJRq/4QaVcGWI/W08vBt0mgib" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 21, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 10, 31, 17, 14, 58, 21, DateTimeKind.Local).AddTicks(9526), "Junr5IHgOH9JktCE+n23mkTN8sEpPrSo8fm0tetmjy90ad87" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8389), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8490), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8498), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8504), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8513), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8519), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8525), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8531), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8537), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8542), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8548), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8553), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8560), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8565), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8570), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8576), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8581), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8587), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8593), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8598), null, new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5318), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5324), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5327), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5340), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5340), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5342), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5342), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5343), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5344), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5345), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5347), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5349), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5352), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2489), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2491), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(422), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7792), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7795), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7808), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7812), new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6959), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6961), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6962), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6964), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6965), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6967), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6968), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6999), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6999), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7001), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7001), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7003), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7004), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7005), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7006), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7007), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7009), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7014), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7014), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7016), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7016), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7018), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7018), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7019), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7020), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7022), new DateTime(2023, 10, 31, 17, 14, 58, 28, DateTimeKind.Local).AddTicks(7021) });
        }
    }
}
