using Microsoft.EntityFrameworkCore.Migrations;

namespace Cards.DataAccess.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeckName", "PictureUri" },
                values: new object[] { "Deck_1", "https://drive.google.com/uc?export=view&id=1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckName", "PictureUri" },
                values: new object[] { 10000, "Sample", "https://drive.google.com/uc?export=view&id=1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckName", "PictureUri" },
                values: new object[] { 2, "Deck_1", "https://drive.google.com/uc?export=view&id=1B-m9CUp43S1ElqrzdnLQFR2rrg4pOzlI" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckName", "PictureUri" },
                values: new object[] { 3, "Deck_1", "https://drive.google.com/uc?export=view&id=1mHeIWMuxQnZ2qifSZxSAmoY3xPU8vV3s" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckName", "PictureUri" },
                values: new object[] { 4, "Deck_1", "https://drive.google.com/uc?export=view&id=1nt2QxOc7Sr5srHbhI1ITKVPOt3vwhYQh" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "MisterVovan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeckName", "PictureUri" },
                values: new object[] { "Sample", "https://drive.google.com/uc?export=view&id=1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy" });
        }
    }
}
