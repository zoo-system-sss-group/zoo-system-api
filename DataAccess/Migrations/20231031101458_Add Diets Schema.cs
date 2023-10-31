using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDietsSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Diets",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Diets",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Diets",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "DietDetails",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "DietDetails",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "DietDetails",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8537), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8598), new DateTime(2023, 10, 31, 17, 14, 58, 25, DateTimeKind.Local).AddTicks(8599) });

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

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "DietName", "FoodName", "ModificationDate", "Quantity", "TimesPerDay", "Unit" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7744), null, "African Lion - Birth Diet", "Milk", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7748), 0.5, 8, "liters" },
                    { 2, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7750), null, "African Lion - Mature Diet", "Meat and vegetables", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7750), 2.0, 2, "kilograms" },
                    { 3, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7752), null, "African Lion - Pregnant Diet", "Special pregnancy diet", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7752), 2.5, 3, "kilograms" },
                    { 4, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7754), null, "Asian Elephant - Birth Diet", "Milk and Vegetables", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7754), 5.0, 4, "liters" },
                    { 5, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7755), null, "Asian Elephant - Mature Diet", "Grasses, Fruits, Vegetables, and Sugarcane", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7756), 150.0, 3, "kilograms" },
                    { 6, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7757), null, "Asian Elephant - Pregnant Diet", "Special pregnancy diet (Extra Fruits, Vegetables, and Sugarcane)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7758), 150.0, 3, "kilograms" },
                    { 7, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7759), null, "Great White Shark - Birth Diet", "Fish and other small sea creatures", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7760), 10.0, 3, "kilograms" },
                    { 8, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7761), null, "Great White Shark - Mature Diet", "Seals, sea lions, fish, and other sharks", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7762), 30.0, 2, "kilograms" },
                    { 9, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7763), null, "Great White Shark - Pregnant Diet", "Special pregnancy diet (Extra Fish and Sea Creatures)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7764), 40.0, 3, "kilograms" },
                    { 10, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7765), null, "European Red Fox - Birth Diet", "Milk and Small Creatures", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7765), 0.5, 4, "liters" },
                    { 11, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7767), null, "European Red Fox - Mature Diet", "Small mammals, birds, fruits, and insects", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7767), 2.0, 2, "kilograms" },
                    { 12, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7769), null, "European Red Fox - Pregnant Diet", "Special pregnancy diet (Extra Small Creatures and Fruits)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7769), 2.5, 3, "kilograms" },
                    { 13, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7771), null, "Emperor Penguin - Birth Diet", "Milk and Fish", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7771), 0.5, 8, "liters" },
                    { 14, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7773), null, "Emperor Penguin - Mature Diet", "Fish, squid, and krill", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7773), 2.0, 2, "kilograms" },
                    { 15, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7775), null, "Emperor Penguin - Pregnant Diet", "Special pregnancy diet (Extra Fish and Seafood)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7775), 2.5, 3, "kilograms" },
                    { 16, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7776), null, "Kangaroo - Birth Diet", "Milk and Grasses", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7777), 0.5, 8, "liters" },
                    { 17, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7778), null, "Kangaroo - Mature Diet", "Grasses and plants", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7779), 2.0, 2, "kilograms" },
                    { 18, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7780), null, "Kangaroo - Pregnant Diet", "Special pregnancy diet (Extra Grasses and Leaves)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7781), 2.5, 3, "kilograms" },
                    { 19, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7782), null, "Grizzly Bear - Birth Diet", "Milk and Berries", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7783), 2.0, 4, "liters" },
                    { 20, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7784), null, "Grizzly Bear - Mature Diet", "Fish, berries, roots, and small mammals", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7785), 5.0, 3, "kilograms" },
                    { 21, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7786), null, "Grizzly Bear - Pregnant Diet", "Special pregnancy diet (Extra Berries and Small Creatures)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7787), 6.0, 4, "kilograms" },
                    { 22, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7788), null, "Polar Bear - Birth Diet", "Milk and Fish", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7789), 1.0, 6, "liters" },
                    { 23, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7792), null, "Polar Bear - Mature Diet", "Seals and fish", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7792), 4.0, 2, "kilograms" },
                    { 24, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7795), null, "Polar Bear - Pregnant Diet", "Special pregnancy diet (Extra Fish and Seafood)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7796), 5.0, 3, "kilograms" },
                    { 25, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7798), null, "Bengal Tiger - Birth Diet", "Milk and Meat", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7799), 0.5, 8, "liters" },
                    { 26, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7802), null, "Bengal Tiger - Mature Diet", "Deer, wild boar, and other ungulates", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7802), 2.0, 2, "kilograms" },
                    { 27, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7805), null, "Bengal Tiger - Pregnant Diet", "Special pregnancy diet (Extra Meat and Prey)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7806), 2.5, 3, "kilograms" },
                    { 28, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7808), null, "Panda - Birth Diet", "Milk and Bamboo", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7809), 0.5, 8, "liters" },
                    { 29, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7810), null, "Panda - Mature Diet", "Bamboo shoots and leaves", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7811), 2.0, 2, "kilograms" },
                    { 30, new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7812), null, "Panda - Pregnant Diet", "Special pregnancy diet (Extra Bamboo and Vegetation)", new DateTime(2023, 10, 31, 17, 14, 58, 26, DateTimeKind.Local).AddTicks(7812), 2.5, 3, "kilograms" }
                });

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

            migrationBuilder.InsertData(
                table: "DietDetails",
                columns: new[] { "Id", "AnimalId", "CreationDate", "DeletionDate", "DietId", "EndDate", "ModificationDate", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(356), null, 1, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(358) },
                    { 2, 2, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(359), null, 5, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(361) },
                    { 3, 3, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(362), null, 7, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(363) },
                    { 4, 4, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(365), null, 10, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(366) },
                    { 5, 5, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(367), null, 14, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(368) },
                    { 6, 6, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(370), null, 16, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(371) },
                    { 7, 7, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(400), null, 20, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(402) },
                    { 8, 8, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(404), null, 22, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(405) },
                    { 9, 9, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(406), null, 26, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(407) },
                    { 10, 10, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(409), null, 28, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(410) },
                    { 11, 11, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(411), null, 2, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(412) },
                    { 12, 12, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(414), null, 6, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(415) },
                    { 13, 13, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(416), null, 8, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(418) },
                    { 14, 14, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(419), null, 12, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(420) },
                    { 15, 15, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(421), null, 15, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(422), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(423) },
                    { 16, 16, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(424), null, 18, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(425) },
                    { 17, 17, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(426), null, 21, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(428) },
                    { 18, 18, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(429), null, 24, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(430) },
                    { 19, 19, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(431), null, 27, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(433) },
                    { 20, 20, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(434), null, 30, null, new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 10, 31, 17, 14, 58, 27, DateTimeKind.Local).AddTicks(435) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DietDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Diets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Diets",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Diets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "DietDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "DietDetails",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "DietDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 700, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 10, 30, 21, 47, 5, 700, DateTimeKind.Local).AddTicks(2663), "WaAgEP5BIxkAWtYKnswysi09PA86oZN4IaWi9V+F2vCWx3m/" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 706, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 10, 30, 21, 47, 5, 706, DateTimeKind.Local).AddTicks(6548), "Kx2nr+ukOYqlrAPdYKYR19YHz1He0d5Eak9byA+UFqSjtYF0" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 713, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 10, 30, 21, 47, 5, 713, DateTimeKind.Local).AddTicks(2282), "Rh9e4zeu+wq8cEU4O6JviLWB+4scpHsY7CRLT6cQJa7Z1F+v" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 718, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 10, 30, 21, 47, 5, 718, DateTimeKind.Local).AddTicks(5510), "Co/8e0MrrgzoPZl1NbJjSd0y3bZlNRy1JlMaEcf+FwNqqjCb" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 722, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 10, 30, 21, 47, 5, 722, DateTimeKind.Local).AddTicks(5724), "H86XctIrWSLyrqM3ePy2y83DocD2JPedkZ6fqn/9TZlP47Tf" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 726, DateTimeKind.Local).AddTicks(6436), new DateTime(2023, 10, 30, 21, 47, 5, 726, DateTimeKind.Local).AddTicks(6437), "iuQ5AZbt/wbr7Rp3MZu9bEwlXfUeFrypN9mmq1+mqYtEnzm2" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4506), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9037), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 10, 30, 21, 47, 5, 732, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1241), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1242), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1254), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1256), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1256), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1258), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1258), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1261), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1262), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1263), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1264), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1265), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1267), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1267), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1270), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1272), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1273), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1274), new DateTime(2023, 10, 30, 21, 47, 5, 734, DateTimeKind.Local).AddTicks(1273) });
        }
    }
}
