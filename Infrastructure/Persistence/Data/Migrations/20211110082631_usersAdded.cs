using Microsoft.EntityFrameworkCore.Migrations;

namespace Pictoload.Data.Migrations
{
    public partial class usersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagPhotoId",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TagPhotoId",
                table: "Photos",
                column: "TagPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_TagPhotos_TagPhotoId",
                table: "Photos",
                column: "TagPhotoId",
                principalTable: "TagPhotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_TagPhotos_TagPhotoId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_TagPhotoId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "TagPhotoId",
                table: "Photos");
        }
    }
}
