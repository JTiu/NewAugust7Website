using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class MigrateScorecard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce80c97a-2176-4446-95e8-3106db799f2c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e15792-aabf-4de7-82a8-fcb82f83cf60", "90ab5815-0b9b-4f5e-b916-965cf1233c95", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e15792-aabf-4de7-82a8-fcb82f83cf60");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce80c97a-2176-4446-95e8-3106db799f2c", "525a0905-78ed-43aa-a305-eda3b9808712", "Judge", "JUDGE" });
        }
    }
}
