using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class ChngedToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad012fda-bbd2-4266-ba78-41b7505bf10d");

            migrationBuilder.DropColumn(
                name: "FightId",
                table: "ScoreCards");

            migrationBuilder.AddColumn<string>(
                name: "FightName",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f885feb2-bf28-4e40-9547-e165142186f5", "36c70c7b-ba11-4c65-8dab-057acd1c2f28", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f885feb2-bf28-4e40-9547-e165142186f5");

            migrationBuilder.DropColumn(
                name: "FightName",
                table: "ScoreCards");

            migrationBuilder.AddColumn<int>(
                name: "FightId",
                table: "ScoreCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad012fda-bbd2-4266-ba78-41b7505bf10d", "95a3631d-2f0a-4b58-bcc4-fca3faa1225b", "Judge", "JUDGE" });
        }
    }
}
