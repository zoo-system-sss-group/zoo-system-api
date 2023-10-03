using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditTicketAndTicketOrderSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketTypes_TypeId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "TicketOrders");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TicketTypes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OrderInformationId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TypeCode",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "TicketOrders",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "TicketOrders",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes",
                column: "Code");

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Code", "Name", "Price" },
                values: new object[,]
                {
                    { "A01", "Adult", 100000.0 },
                    { "A02", "VIP Adult", 200000.0 },
                    { "C01", "Child", 60000.0 },
                    { "C02", "VIP Child", 150000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Code",
                table: "Tickets",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TypeCode",
                table: "Tickets",
                column: "TypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets",
                column: "OrderInformationId",
                principalTable: "TicketOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketTypes_TypeCode",
                table: "Tickets",
                column: "TypeCode",
                principalTable: "TicketTypes",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketTypes_TypeCode",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Code",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TypeCode",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "A01");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "A02");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "C01");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "C02");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TicketOrders");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TicketTypes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "TicketTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "TicketTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                table: "TicketTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TicketTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "TicketTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "TicketTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderInformationId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "TicketOrders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "TicketOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets",
                column: "OrderInformationId",
                principalTable: "TicketOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketTypes_TypeId",
                table: "Tickets",
                column: "TypeId",
                principalTable: "TicketTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
