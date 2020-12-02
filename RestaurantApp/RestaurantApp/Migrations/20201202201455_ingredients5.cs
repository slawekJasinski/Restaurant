using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class ingredients5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_DishId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Ingredients");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Dishes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 2,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 3,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 4,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 5,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 6,
                column: "Amount",
                value: 100.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Ingredients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_DishId",
                table: "Ingredients",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
