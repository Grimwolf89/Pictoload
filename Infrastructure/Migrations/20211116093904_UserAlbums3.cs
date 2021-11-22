using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UserAlbums3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_PhotoAlbums_PhotoAlbumId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_PhotoAlbums_PhotoAlbumId",
                table: "Photos");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoAlbumId",
                table: "Photos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoAlbumId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PhotoAlbumId",
                table: "Photos",
                column: "PhotoAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_PhotoAlbumId",
                table: "Albums",
                column: "PhotoAlbumId");

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
    }
}
