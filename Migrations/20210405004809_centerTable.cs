using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class centerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21f9af2-8695-46af-aa9b-f52bc1dbaf82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c15c6525-ec1e-4bd5-849d-17d42496e795", "fcc07f49-7340-4693-af7a-c4f73714830b", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c15c6525-ec1e-4bd5-849d-17d42496e795");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d21f9af2-8695-46af-aa9b-f52bc1dbaf82", "49436f22-8928-4362-9818-20b7b6ac60d0", "Judge", "JUDGE" });
        }
    }
}
