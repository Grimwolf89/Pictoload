using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PhotoShare1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "SharePhotos");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "SharePhotos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos",
                column: "PhotoId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "SharePhotos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "SharePhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SharePhotos_Albums_PhotoId",
                table: "SharePhotos",
                column: "PhotoId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
