using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class DataSeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "id", "availibility", "CustomerId", "description", "imageUrl", "name", "price" },
                values: new object[,]
                {
                    { 1, true, null, "sos, ser, szynka, pieczarki", "", "Capriciosa", 39.5 },
                    { 2, true, null, "sos, ser, salami pepperoni", "", "Pepperoni", 36.5 },
                    { 3, true, null, "sos, ser, pieczarki", "", "Funghi", 36.5 },
                    { 4, true, null, "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki", "", "Carbonara", 45.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
