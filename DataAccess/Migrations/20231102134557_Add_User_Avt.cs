using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_User_Avt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/be/85/2f/be852fd4ad1cb76b83ce962f618895bd.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 587, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 11, 2, 20, 45, 56, 587, DateTimeKind.Local).AddTicks(5469), "CbwkezcrryrXlRTF5EgkhsMUPmIPBb32WnYMuzAE6ZplN1be" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/ed/de/aa/eddeaaf250c19489e25bd0a2dd3e7756.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 591, DateTimeKind.Local).AddTicks(746), new DateTime(2023, 11, 2, 20, 45, 56, 591, DateTimeKind.Local).AddTicks(756), "lTNOnDLEaWhDuvOKcdopG60WR23i1FfAKlSnqWUycaBqhtFc" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/14/b0/3b/14b03bdcab41f458dd15c9f5669cef2d.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 594, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 11, 2, 20, 45, 56, 594, DateTimeKind.Local).AddTicks(3655), "p8vA2cgpP+loBPrWzWa2hcPTRHUsp3Zhofc9jcKdzt/x64Un" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/6c/a3/4b/6ca34beddfbd279418c915d2258d698b.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 597, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 11, 2, 20, 45, 56, 597, DateTimeKind.Local).AddTicks(7481), "fD82wz2HtTYzH3BfDsNBZ3L0eTyQ9vYtx4Jxp7dd8Rnswkl0" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/736x/81/3c/57/813c57fcb969d58fac1672594da05532.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 601, DateTimeKind.Local).AddTicks(1349), new DateTime(2023, 11, 2, 20, 45, 56, 601, DateTimeKind.Local).AddTicks(1353), "hE7taR9VHKgaHnVEmvR//nEdvwnghJNrakZsxZfofdtah24M" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/7d/cd/61/7dcd61988b0add83b5ba9a656512593e.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 604, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 11, 2, 20, 45, 56, 604, DateTimeKind.Local).AddTicks(5291), "0RqyblE9qlcrcE+BxYaPlC8cRMIAmfxjCSatE0v4na6irafl" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/0e/4b/7a/0e4b7aef4834bfc646775d8fd3705825.jpg", new DateTime(2023, 11, 2, 20, 45, 56, 607, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 11, 2, 20, 45, 56, 607, DateTimeKind.Local).AddTicks(8078), "/2dmzVH+fgkN1WKCigYpkP1u0ljf9iBwY84vJ+xgQtMaTJ0P" });

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
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4242), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 11, 2, 20, 45, 56, 612, DateTimeKind.Local).AddTicks(4249) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 475, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 11, 2, 16, 51, 25, 475, DateTimeKind.Local).AddTicks(4158), "kK/bveedKbrJs3Hml2bmFM1LUD5RzrB1tn6aONTER6CBjPHO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 479, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 11, 2, 16, 51, 25, 479, DateTimeKind.Local).AddTicks(3325), "mTGMRWTNJkL2RDOTAKYmSljdr0aIVc7r/adEOlyPuFwwfB1Z" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 483, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 11, 2, 16, 51, 25, 483, DateTimeKind.Local).AddTicks(1371), "N1myHZyC4uj/B3zSCfFfUmmitaxFCCzthuI84uHP/EQBpSNr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 486, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 11, 2, 16, 51, 25, 486, DateTimeKind.Local).AddTicks(9384), "unbznzIO1tz82f8kzoI8kyzqBmfcewwA9FNqJZwRsCOZGoF/" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 490, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 11, 2, 16, 51, 25, 490, DateTimeKind.Local).AddTicks(9768), "4ULiUqZ0MPsLWvWnC3QXD1DQwxXCIkRbbQtovJ/uCI6IDFYR" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 494, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 2, 16, 51, 25, 494, DateTimeKind.Local).AddTicks(8944), "xcXq9AgHqIhRsnZ90/rnBoHmjMclSAwe58xFT08Knlqe17rr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 11, 2, 16, 51, 25, 498, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 11, 2, 16, 51, 25, 498, DateTimeKind.Local).AddTicks(7455), "LE0NaCGIDDpI5NQZM+QbfF6vAyODJWUG8BspSfkp4d/HTR/F" });

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
        }
    }
}
