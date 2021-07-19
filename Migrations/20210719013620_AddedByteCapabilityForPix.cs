using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class AddedByteCapabilityForPix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_AspNetUsers_IdentityUserId",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Participants_IdentityUserId",
                table: "Participants");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0912c413-8b10-40f3-bac2-f8b02bad75c3");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Participants");

            migrationBuilder.AddColumn<byte[]>(
                name: "ParticipantPhoto",
                table: "Participants",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdb782ea-26ea-4f17-aded-0cc0f7f9df3a", "96ae2893-88ff-4fe8-94a9-40e8959726fd", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb782ea-26ea-4f17-aded-0cc0f7f9df3a");

            migrationBuilder.DropColumn(
                name: "ParticipantPhoto",
                table: "Participants");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Participants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0912c413-8b10-40f3-bac2-f8b02bad75c3", "75742ba1-99a0-4cc4-ba2f-4e3bb788848e", "Judge", "JUDGE" });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdentityUserId",
                table: "Participants",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_AspNetUsers_IdentityUserId",
                table: "Participants",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
