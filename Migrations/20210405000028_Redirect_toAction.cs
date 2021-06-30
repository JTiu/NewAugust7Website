using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class Redirect_toAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "140d8460-1c38-49d2-a5c3-f230fb85b4d1");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d21f9af2-8695-46af-aa9b-f52bc1dbaf82", "49436f22-8928-4362-9818-20b7b6ac60d0", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21f9af2-8695-46af-aa9b-f52bc1dbaf82");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ScoreCards");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "140d8460-1c38-49d2-a5c3-f230fb85b4d1", "3fa9e6b9-3766-447b-a1ed-f901f90e8d19", "Judge", "JUDGE" });
        }
    }
}
