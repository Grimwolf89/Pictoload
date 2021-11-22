using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UserAlbums1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserAlbumsId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserAlbumsId",
                table: "Albums",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAlbums_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAlbums_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserAlbumsId",
                table: "AspNetUsers",
                column: "UserAlbumsId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_UserAlbumsId",
                table: "Albums",
                column: "UserAlbumsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAlbums_AlbumId",
                table: "UserAlbums",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAlbums_UserId",
                table: "UserAlbums",
                column: "UserId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_UserAlbums_UserAlbumsId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserAlbums_UserAlbumsId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserAlbums");

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
    }
}
