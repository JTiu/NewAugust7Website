using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class ChangedParticipantModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ae2458e-e3d2-4604-b413-8c920cd35120");

            migrationBuilder.RenameColumn(
                name: "Full_Name",
                table: "Participants",
                newName: "Wins");

            migrationBuilder.AddColumn<string>(
                name: "Draw",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KnockOuts",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Losses",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ring_Name",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8bb6226-c13d-4708-bd7f-c287b203b95d", "29ea43ba-bd4b-4188-a0da-5686a8b51974", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8bb6226-c13d-4708-bd7f-c287b203b95d");

            migrationBuilder.DropColumn(
                name: "Draw",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "KnockOuts",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Losses",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Ring_Name",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Participants");

            migrationBuilder.RenameColumn(
                name: "Wins",
                table: "Participants",
                newName: "Full_Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ae2458e-e3d2-4604-b413-8c920cd35120", "ba5b6f75-34c4-4237-aa8f-2d7c192084e3", "Judge", "JUDGE" });
        }
    }
}
