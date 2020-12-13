using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class _1212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Dishes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Dishes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 39.5 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 36.5 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 36.5 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 45.5 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 47.5 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Amount", "price" },
                values: new object[] { 100.0, 27.5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "id", "Amount", "name" },
                values: new object[,]
                {
                    { 1, 100.0, "Ser" },
                    { 2, 100.0, "Sos" },
                    { 3, 100.0, "Szynka" },
                    { 4, 100.0, "Pieczarki" },
                    { 5, 100.0, "Salami Pepperoni" },
                    { 6, 100.0, "Cebula" },
                    { 7, 100.0, "Boczek" },
                    { 8, 100.0, "Kurczak" }
                });
        }
    }
}
