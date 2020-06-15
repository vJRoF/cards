using Microsoft.EntityFrameworkCore.Migrations;

namespace Cards.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeckName = table.Column<string>(nullable: true),
                    PictureUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckName", "PictureUri" },
                values: new object[] { 1, "Sample", "https://drive.google.com/uc?export=view&id=1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
