using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class _20122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "DishName", "ImageUrl", "TypeId" },
                values: new object[] { 3, "Jabłka, cynamon, syrop klonowy", "Naleśniki", "https://foodish-api.herokuapp.com/images/dosa/dosa63.jpg", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);
        }
    }
}
