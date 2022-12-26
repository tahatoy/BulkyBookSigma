using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkBook.DataAccess.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdCategoriesId",
                table: "Ads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Ads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ads_AdCategoriesId",
                table: "Ads",
                column: "AdCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CategoriesId",
                table: "Ads",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_DeadlineId",
                table: "Ads",
                column: "DeadlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_AdCategories_AdCategoriesId",
                table: "Ads",
                column: "AdCategoriesId",
                principalTable: "AdCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Category_CategoriesId",
                table: "Ads",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Deadlines_DeadlineId",
                table: "Ads",
                column: "DeadlineId",
                principalTable: "Deadlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_AdCategories_AdCategoriesId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Category_CategoriesId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Deadlines_DeadlineId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_AdCategoriesId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_CategoriesId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_DeadlineId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "AdCategoriesId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Ads");
        }
    }
}
