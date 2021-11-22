using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PhotoShare2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos");

            migrationBuilder.AddForeignKey(
                name: "FK_SharePhotos_Photos_PhotoId",
                table: "SharePhotos",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharePhotos_Photos_PhotoId",
                table: "SharePhotos");

            migrationBuilder.AddForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos",
                column: "PhotoId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
