using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReplacementReminder.Data.Migrations
{
    public partial class AddedReplacementHistoryTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplacementTime",
                table: "ReplacementHistory",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplacementTime",
                table: "ReplacementHistory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
