using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class debug_addiion_function_ScoresB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5de7e50-3a72-44d4-b16c-90d60058cd4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c2805cd-f0f8-4430-bb80-234a0f35973a", "974cd93a-e8b3-4482-afc3-bd54496282be", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c2805cd-f0f8-4430-bb80-234a0f35973a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5de7e50-3a72-44d4-b16c-90d60058cd4a", "019220ec-8856-439d-a03b-d9b7f1106955", "Judge", "JUDGE" });
        }
    }
}
