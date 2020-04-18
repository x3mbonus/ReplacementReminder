using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReplacementReminder.Data.Migrations
{
    public partial class AddedReplacementHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ReplacementItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoFileName = table.Column<string>(nullable: true),
                    PhotoBlob = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReplacementHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    ReplacementActionItemId_ReplacementItemId = table.Column<int>(nullable: true),
                    ReplacementTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    PhotoId = table.Column<int>(nullable: false),
                    ReplacementActionPhotoId_PhotoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplacementHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplacementHistory_ReplacementItems_ReplacementActionItemId_ReplacementItemId",
                        column: x => x.ReplacementActionItemId_ReplacementItemId,
                        principalTable: "ReplacementItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementHistory_Photos_ReplacementActionPhotoId_PhotoId",
                        column: x => x.ReplacementActionPhotoId_PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementHistory_ReplacementActionItemId_ReplacementItemId",
                table: "ReplacementHistory",
                column: "ReplacementActionItemId_ReplacementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementHistory_ReplacementActionPhotoId_PhotoId",
                table: "ReplacementHistory",
                column: "ReplacementActionPhotoId_PhotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplacementHistory");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ReplacementItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
