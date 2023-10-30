using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AnimalInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4313), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4405), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4414), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4491), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4500), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4506), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4506), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4512), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4519), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4527), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4534), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4540), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4546), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4553), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4559), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4566), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4572), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4578), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4584), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4591), 1 });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 10, 30, 21, 47, 5, 731, DateTimeKind.Local).AddTicks(4597), 1 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AnimalInformations");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 34, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 10, 26, 19, 37, 8, 34, DateTimeKind.Local).AddTicks(3764), "nFJU23RQARg1LMfTngQ+XMqrZg47sjTnSCRA8GmJqYzQXC2S" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 38, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 10, 26, 19, 37, 8, 38, DateTimeKind.Local).AddTicks(5014), "5VzDcLOApdpTWewVF3fb3+iDsURuDehDAPnffCm/8eUiRjqU" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 42, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 10, 26, 19, 37, 8, 42, DateTimeKind.Local).AddTicks(6313), "8SRRAOvw1X6TU4BN1i8CyMVsHIWoWW9S/jw02Qnz+hFWTlUr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 46, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 10, 26, 19, 37, 8, 46, DateTimeKind.Local).AddTicks(7457), "h1DZMa8Je49M8HKcd5IuVl7pNT9auAWuGnc1QD3M5+9ikE+X" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 51, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 10, 26, 19, 37, 8, 51, DateTimeKind.Local).AddTicks(2793), "cEhy3uXNgMWIdZfxxJIRRz6M/blDtEiqErfM7h1P3yOZ2fIP" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 55, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 10, 26, 19, 37, 8, 55, DateTimeKind.Local).AddTicks(3982), "HDiFoYJ1qA36rIvTbyxW4s80ifPs2OzuDjyVDI4barjHLbZD" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7852), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7887), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4293), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7990) });
        }
    }
}
