using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class AddedFightIdtomodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ebd0b9-b095-42f6-bdcc-03f57da182f3");

            migrationBuilder.AddColumn<int>(
                name: "FightId",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6f22802-99fc-4974-ac1b-d318c4a93aa4", "ff65f0a8-221b-4703-9dcf-7b76ce8ce5d0", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6f22802-99fc-4974-ac1b-d318c4a93aa4");

            migrationBuilder.DropColumn(
                name: "FightId",
                table: "ScoreCards");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52ebd0b9-b095-42f6-bdcc-03f57da182f3", "23c88185-b941-4e57-bbef-baef6222c702", "Judge", "JUDGE" });
        }
    }
}
