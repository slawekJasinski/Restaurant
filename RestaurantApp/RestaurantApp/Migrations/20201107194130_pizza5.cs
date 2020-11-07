using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class pizza5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "id", "availibility", "CustomerId", "description", "imageUrl", "name", "price" },
                values: new object[] { 5, true, null, "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek", "", "Broccoli", 47.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
