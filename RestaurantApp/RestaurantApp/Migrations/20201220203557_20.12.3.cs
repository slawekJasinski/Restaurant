using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class _20123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "DishName", "ImageUrl", "TypeId" },
                values: new object[] { 4, "Beef, Lettuce, Tomato, Mayo", "Burger", "https://foodish-api.herokuapp.com/images/burger/burger8.jpg", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);
        }
    }
}
