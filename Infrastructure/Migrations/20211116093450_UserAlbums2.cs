using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UserAlbums2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_UserAlbums_UserAlbumsId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserAlbums_UserAlbumsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserAlbumsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Albums_UserAlbumsId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "UserAlbumsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserAlbumsId",
                table: "Albums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserAlbumsId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserAlbumsId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserAlbumsId",
                table: "AspNetUsers",
                column: "UserAlbumsId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_UserAlbumsId",
                table: "Albums",
                column: "UserAlbumsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_UserAlbums_UserAlbumsId",
                table: "Albums",
                column: "UserAlbumsId",
                principalTable: "UserAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserAlbums_UserAlbumsId",
                table: "AspNetUsers",
                column: "UserAlbumsId",
                principalTable: "UserAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
