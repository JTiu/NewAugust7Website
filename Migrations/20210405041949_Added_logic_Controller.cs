using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class Added_logic_Controller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c15c6525-ec1e-4bd5-849d-17d42496e795");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5de7e50-3a72-44d4-b16c-90d60058cd4a", "019220ec-8856-439d-a03b-d9b7f1106955", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5de7e50-3a72-44d4-b16c-90d60058cd4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c15c6525-ec1e-4bd5-849d-17d42496e795", "fcc07f49-7340-4693-af7a-c4f73714830b", "Judge", "JUDGE" });
        }
    }
}
