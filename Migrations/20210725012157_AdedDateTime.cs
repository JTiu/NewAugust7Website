using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class AdedDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf244cb0-528b-4626-a3c8-e30dfd007173");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "ScoreCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad012fda-bbd2-4266-ba78-41b7505bf10d", "95a3631d-2f0a-4b58-bcc4-fca3faa1225b", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad012fda-bbd2-4266-ba78-41b7505bf10d");

            migrationBuilder.AlterColumn<string>(
                name: "DateCreated",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf244cb0-528b-4626-a3c8-e30dfd007173", "851efe3e-d167-4f54-8946-45874cceec43", "Judge", "JUDGE" });
        }
    }
}
