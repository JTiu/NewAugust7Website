using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class AdjustScorecardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e15792-aabf-4de7-82a8-fcb82f83cf60");

            migrationBuilder.AddColumn<string>(
                name: "Boxer1",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Boxer2",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R1",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R10",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R11",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R12",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R2",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R3",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R4",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R5",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R6",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R7",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R8",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeterminateFactor_R9",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstNameOnCard",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastNameOnCard",
                table: "ScoreCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf244cb0-528b-4626-a3c8-e30dfd007173", "851efe3e-d167-4f54-8946-45874cceec43", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf244cb0-528b-4626-a3c8-e30dfd007173");

            migrationBuilder.DropColumn(
                name: "Boxer1",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Boxer2",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R1",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R10",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R11",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R12",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R2",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R3",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R4",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R5",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R6",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R7",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R8",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "DeterminateFactor_R9",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FirstNameOnCard",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "LastNameOnCard",
                table: "ScoreCards");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e15792-aabf-4de7-82a8-fcb82f83cf60", "90ab5815-0b9b-4f5e-b916-965cf1233c95", "Judge", "JUDGE" });
        }
    }
}
