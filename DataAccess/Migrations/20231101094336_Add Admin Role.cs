using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Avatar", "CreationDate", "DeletionDate", "Experiences", "Fullname", "ModificationDate", "Password", "Role", "Username" },
                values: new object[] { 7, null, new DateTime(2023, 11, 1, 16, 43, 35, 587, DateTimeKind.Local).AddTicks(8779), null, null, "Quản trị viên", new DateTime(2023, 11, 1, 16, 43, 35, 587, DateTimeKind.Local).AddTicks(8780), "WS1Wcse75SmVLGKXUGeHTe3/pCqJldrH+fJYxstwbQ6t3QZU", 2, "admin" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7);

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
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6188), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6198), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6393), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6403), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 11, 1, 15, 9, 4, 903, DateTimeKind.Local).AddTicks(6436) });

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
    }
}
