using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YahyaFarms.Web.Migrations
{
    /// <inheritdoc />
    public partial class ItemsImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemsImages",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsMainImage = table.Column<bool>(type: "bit", nullable: false),
                    IsMainThumbnailImage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsImages", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_ItemsImages_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImages_ItemID",
                table: "ItemsImages",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsImages");
        }
    }
}
