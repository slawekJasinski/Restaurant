using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Migrations
{
    public partial class _1412 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "availibility",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Dishes",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Dishes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Dishes",
                newName: "DishId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.AddColumn<string>(
                name: "DishName",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Dishes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAdress",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetailsOrder",
                columns: table => new
                {
                    DetailOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsOrder", x => x.DetailOrderId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DishId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DateFrom = table.Column<string>(nullable: true),
                    DateTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TypesDishes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesDishes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "TypesSizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SizeName = table.Column<string>(nullable: false),
                    Unit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesSizes", x => x.SizeId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerName", "DeliveryAddress", "EmailAdress", "PhoneNumber" },
                values: new object[] { 1, "Kamil Cichocki", "ul. Warszawska 10/14, Poznań", "kamil.cichocki@domena.pl", "999-888-777" });

            migrationBuilder.InsertData(
                table: "DetailsOrder",
                columns: new[] { "DetailOrderId", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1, 6 },
                    { 1, 1, 1 },
                    { 2, 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "DishName", "TypeId" },
                values: new object[] { "Capriciosa", 1 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "Description", "DishName", "TypeId" },
                values: new object[] { "sos, ser", "Margarita", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "Notes", "StatusId" },
                values: new object[] { 1, 1, "Nie działa domofon proszę dzwonić", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateFrom", "DateTo", "DishId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 1, "2020.12.13", "2021.12.13", 1, 20.99, 1 },
                    { 2, "2020.12.13", "2021.12.13", 1, 30.99, 2 },
                    { 3, "2020.12.13", "2021.12.13", 1, 40.99, 3 },
                    { 4, "2020.12.13", "2021.12.13", 2, 19.99, 1 },
                    { 5, "2020.12.13", "2021.12.13", 2, 29.99, 2 },
                    { 6, "2020.12.13", "2021.12.13", 2, 39.99, 3 }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "StatusName" },
                values: new object[,]
                {
                    { 3, "W trakcie dostawy" },
                    { 2, "W przygotowaniu" },
                    { 1, "Przyjęto do realizacji" },
                    { 5, "Anulowane" },
                    { 4, "Dostarczone" }
                });

            migrationBuilder.InsertData(
                table: "TypesDishes",
                columns: new[] { "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 3, "Fast food" },
                    { 2, "Dania obiadowe" },
                    { 1, "Pizza" },
                    { 4, "Zupy" }
                });

            migrationBuilder.InsertData(
                table: "TypesSizes",
                columns: new[] { "SizeId", "SizeName", "Unit" },
                values: new object[,]
                {
                    { 1, "30", "cm" },
                    { 2, "40", "cm" },
                    { 3, "50", "cm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsOrder");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TypesDishes");

            migrationBuilder.DropTable(
                name: "TypesSizes");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DishName",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeliveryAddress",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmailAdress",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Dishes",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Dishes",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "DishId",
                table: "Dishes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "availibility",
                table: "Dishes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Dishes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "availibility", "name" },
                values: new object[] { true, "Capriciosa" });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "availibility", "description", "name" },
                values: new object[] { true, "sos, ser, salami pepperoni", "Pepperoni" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "id", "availibility", "description", "imageUrl", "name" },
                values: new object[,]
                {
                    { 3, true, "sos, ser, pieczarki", "", "Funghi" },
                    { 4, true, "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki", "", "Carbonara" },
                    { 5, true, "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek", "", "Broccoli" },
                    { 6, false, "sos pomidorowy z ziołami, ser", "", "Margarita" }
                });
        }
    }
}
