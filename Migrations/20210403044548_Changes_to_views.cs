using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class Changes_to_views : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "389bfa46-7451-4e48-8e9c-897243c6ee4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52ebd0b9-b095-42f6-bdcc-03f57da182f3", "23c88185-b941-4e57-bbef-baef6222c702", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ebd0b9-b095-42f6-bdcc-03f57da182f3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "389bfa46-7451-4e48-8e9c-897243c6ee4a", "6c782375-806c-4843-b584-fe7155e4fdb0", "Judge", "JUDGE" });
        }
    }
}
