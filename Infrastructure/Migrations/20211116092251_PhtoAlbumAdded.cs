using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PhtoAlbumAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoAlbumId",
                table: "Photos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoAlbumId",
                table: "Albums",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PhotoAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoAlbums_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotoAlbums_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PhotoAlbumId",
                table: "Photos",
                column: "PhotoAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_PhotoAlbumId",
                table: "Albums",
                column: "PhotoAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoAlbums_AlbumId",
                table: "PhotoAlbums",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoAlbums_PhotoId",
                table: "PhotoAlbums",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_PhotoAlbums_PhotoAlbumId",
                table: "Albums",
                column: "PhotoAlbumId",
                principalTable: "PhotoAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_PhotoAlbums_PhotoAlbumId",
                table: "Photos",
                column: "PhotoAlbumId",
                principalTable: "PhotoAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_PhotoAlbums_PhotoAlbumId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_PhotoAlbums_PhotoAlbumId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "PhotoAlbums");

            migrationBuilder.DropIndex(
                name: "IX_Photos_PhotoAlbumId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Albums_PhotoAlbumId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "PhotoAlbumId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PhotoAlbumId",
                table: "Albums");
        }
    }
}
