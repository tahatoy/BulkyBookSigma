using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkBook.DataAccess.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CitiesId",
                table: "Districts",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Cities_CitiesId",
                table: "Districts",
                column: "CitiesId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Cities_CitiesId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_CitiesId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "Districts");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId",
                unique: true);
        }
    }
}
