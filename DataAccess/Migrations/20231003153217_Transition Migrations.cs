using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TransitionMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TicketOrders");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                table: "TicketOrders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TicketOrders");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "TicketOrders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TicketOrders");

            migrationBuilder.RenameColumn(
                name: "OrderInformationId",
                table: "Tickets",
                newName: "OrderInformationCode");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_OrderInformationId",
                table: "Tickets",
                newName: "IX_Tickets_OrderInformationCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TicketOrders",
                newName: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationCode",
                table: "Tickets",
                column: "OrderInformationCode",
                principalTable: "TicketOrders",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationCode",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "OrderInformationCode",
                table: "Tickets",
                newName: "OrderInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_OrderInformationCode",
                table: "Tickets",
                newName: "IX_Tickets_OrderInformationId");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "TicketOrders",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "TicketOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                table: "TicketOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TicketOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "TicketOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "TicketOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketOrders_OrderInformationId",
                table: "Tickets",
                column: "OrderInformationId",
                principalTable: "TicketOrders",
                principalColumn: "Id");
        }
    }
}
