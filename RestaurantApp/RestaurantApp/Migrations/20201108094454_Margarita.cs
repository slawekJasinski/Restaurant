using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class Margarita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "id", "availibility", "CustomerId", "description", "imageUrl", "name", "price" },
                values: new object[] { 6, false, null, "sos pomidorowy z ziołami, ser", "", "Margarita", 27.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
