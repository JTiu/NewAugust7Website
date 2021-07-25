using Microsoft.EntityFrameworkCore.Migrations;

namespace August7thWebsiteVS.Migrations
{
    public partial class AddedScoreCadTleToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb782ea-26ea-4f17-aded-0cc0f7f9df3a");

            migrationBuilder.CreateTable(
                name: "ScoreCards",
                columns: table => new
                {
                    ScoreCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round_1_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_1_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_2_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_2_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_3_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_3_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_4_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_4_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_5_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_5_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_6_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_6_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_7_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_7_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_8_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_8_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_9_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_9_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_10_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_10_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_11_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_11_B2 = table.Column<int>(type: "int", nullable: false),
                    Round_12_B1 = table.Column<int>(type: "int", nullable: false),
                    Round_12_B2 = table.Column<int>(type: "int", nullable: false),
                    Total_B1 = table.Column<int>(type: "int", nullable: false),
                    Total_B2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreCards", x => x.ScoreCardId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce80c97a-2176-4446-95e8-3106db799f2c", "525a0905-78ed-43aa-a305-eda3b9808712", "Judge", "JUDGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreCards");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce80c97a-2176-4446-95e8-3106db799f2c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdb782ea-26ea-4f17-aded-0cc0f7f9df3a", "96ae2893-88ff-4fe8-94a9-40e8959726fd", "Judge", "JUDGE" });
        }
    }
}
