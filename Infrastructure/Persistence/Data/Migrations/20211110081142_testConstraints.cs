using Microsoft.EntityFrameworkCore.Migrations;

namespace Pictoload.Data.Migrations
{
    public partial class testConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "TagPhotos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TagPhotos_TagId",
                table: "TagPhotos",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagPhotos_Tags_TagId",
                table: "TagPhotos",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagPhotos_Tags_TagId",
                table: "TagPhotos");

            migrationBuilder.DropIndex(
                name: "IX_TagPhotos_TagId",
                table: "TagPhotos");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "TagPhotos");
        }
    }
}
