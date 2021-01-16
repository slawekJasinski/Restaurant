using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class _1001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "DishName",
                value: "Margarita 11111");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DishId",
                table: "Products",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Dishes_DishId",
                table: "Products",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Dishes_DishId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DishId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "DishName",
                value: "Margarita");
        }
    }
}
