using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class debug_score : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c2805cd-f0f8-4430-bb80-234a0f35973a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a965b5fe-39f6-4cbf-bf74-459cc58bf0b5", "d40bdaa7-2a03-4dde-8fee-cb46273ddd3b", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a965b5fe-39f6-4cbf-bf74-459cc58bf0b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c2805cd-f0f8-4430-bb80-234a0f35973a", "974cd93a-e8b3-4482-afc3-bd54496282be", "Judge", "JUDGE" });
        }
    }
}
