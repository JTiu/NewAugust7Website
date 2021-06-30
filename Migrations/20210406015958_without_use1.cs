using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class without_use1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a965b5fe-39f6-4cbf-bf74-459cc58bf0b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "babaa072-72fd-46e1-99d9-fca80c8a73aa", "9117e63a-b943-461d-9492-a955100b6c7e", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "babaa072-72fd-46e1-99d9-fca80c8a73aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a965b5fe-39f6-4cbf-bf74-459cc58bf0b5", "d40bdaa7-2a03-4dde-8fee-cb46273ddd3b", "Judge", "JUDGE" });
        }
    }
}
