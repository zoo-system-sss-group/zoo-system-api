using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BinhNt_AddKeyRelationTo_CreatedAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Accounts_CreatedAccountId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedAccountId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedAccountId",
                table: "News");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "News",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedBy",
                table: "News",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Accounts_CreatedBy",
                table: "News",
                column: "CreatedBy",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Accounts_CreatedBy",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedBy",
                table: "News");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "News",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AddColumn<int>(
                name: "CreatedAccountId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedAccountId",
                table: "News",
                column: "CreatedAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Accounts_CreatedAccountId",
                table: "News",
                column: "CreatedAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
