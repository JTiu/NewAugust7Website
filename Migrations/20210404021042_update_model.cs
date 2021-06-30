using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_Themis_Capstone.Migrations
{
    public partial class update_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6f22802-99fc-4974-ac1b-d318c4a93aa4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "140d8460-1c38-49d2-a5c3-f230fb85b4d1", "3fa9e6b9-3766-447b-a1ed-f901f90e8d19", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "140d8460-1c38-49d2-a5c3-f230fb85b4d1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6f22802-99fc-4974-ac1b-d318c4a93aa4", "ff65f0a8-221b-4703-9dcf-7b76ce8ce5d0", "Judge", "JUDGE" });
        }
    }
}
