﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantApp.Database;

namespace RestaurantApp.Migrations
{
    [DbContext(typeof(RestaurantAppDbContext))]
    [Migration("20210111204546_11.01")]
    partial class _1101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantApp.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnName("CustomerName");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnName("DeliveryAddress");

                    b.Property<string>("EmailAdress")
                        .HasColumnName("EmailAdress");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new { CustomerId = 1, CustomerName = "Kamil Cichocki", DeliveryAddress = "ul. Warszawska 10/14, Poznań", EmailAdress = "kamil.cichocki@domena.pl", PhoneNumber = "999-888-777" }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DishId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasMaxLength(255);

                    b.Property<string>("DishName")
                        .HasColumnName("DishName");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("ImageUrl");

                    b.Property<int>("TypeId")
                        .HasColumnName("TypeId");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new { DishId = 1, Description = "sos, ser, szynka, pieczarki", DishName = "Capriciosa", ImageUrl = "https://foodish-api.herokuapp.com/images/pizza/pizza70.jpg", TypeId = 1 },
                        new { DishId = 2, Description = "sos, ser", DishName = "Margarita", ImageUrl = "https://foodish-api.herokuapp.com/images/pizza/pizza60.jpg", TypeId = 1 },
                        new { DishId = 3, Description = "Jabłka, cynamon, syrop klonowy", DishName = "Naleśniki", ImageUrl = "https://foodish-api.herokuapp.com/images/dosa/dosa63.jpg", TypeId = 2 },
                        new { DishId = 4, Description = "Beef, Lettuce, Tomato, Mayo", DishName = "Burger", ImageUrl = "https://foodish-api.herokuapp.com/images/burger/burger8.jpg", TypeId = 3 }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.DishSize", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateFrom")
                        .HasColumnName("DateFrom");

                    b.Property<string>("DateTo")
                        .HasColumnName("DateTo");

                    b.Property<int>("DishId")
                        .HasColumnName("DishId");

                    b.Property<double>("Price")
                        .HasColumnName("Price");

                    b.Property<int>("SizeId")
                        .HasColumnName("SizeId");

                    b.HasKey("ProductId");

                    b.HasIndex("DishId");

                    b.ToTable("Products");

                    b.HasData(
                        new { ProductId = 1, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 1, Price = 20.99, SizeId = 1 },
                        new { ProductId = 2, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 1, Price = 30.99, SizeId = 2 },
                        new { ProductId = 3, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 1, Price = 40.99, SizeId = 3 },
                        new { ProductId = 4, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 2, Price = 19.99, SizeId = 1 },
                        new { ProductId = 5, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 2, Price = 29.99, SizeId = 2 },
                        new { ProductId = 6, DateFrom = "2020.12.13", DateTo = "2021.12.13", DishId = 2, Price = 39.99, SizeId = 3 }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.DishType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnName("TypeName");

                    b.HasKey("TypeId");

                    b.ToTable("TypesDishes");

                    b.HasData(
                        new { TypeId = 1, TypeName = "Pizza" },
                        new { TypeId = 2, TypeName = "Dania obiadowe" },
                        new { TypeId = 3, TypeName = "Fast food" },
                        new { TypeId = 4, TypeName = "Zupy" }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<string>("Notes")
                        .HasColumnName("Notes");

                    b.Property<int>("StatusId")
                        .HasColumnName("StatusId");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { OrderId = 1, CustomerId = 1, Notes = "Nie działa domofon proszę dzwonić", StatusId = 1 }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.OrderDetails", b =>
                {
                    b.Property<int>("DetailOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DetailOrderId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderId");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.HasKey("DetailOrderId");

                    b.ToTable("DetailsOrder");

                    b.HasData(
                        new { DetailOrderId = 1, OrderId = 1, ProductId = 1 },
                        new { DetailOrderId = 2, OrderId = 1, ProductId = 3 },
                        new { DetailOrderId = 3, OrderId = 1, ProductId = 6 }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.SizeType", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SizeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnName("SizeName");

                    b.Property<string>("Unit")
                        .HasColumnName("Unit");

                    b.HasKey("SizeId");

                    b.ToTable("TypesSizes");

                    b.HasData(
                        new { SizeId = 1, SizeName = "30", Unit = "cm" },
                        new { SizeId = 2, SizeName = "40", Unit = "cm" },
                        new { SizeId = 3, SizeName = "50", Unit = "cm" }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StatusId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnName("StatusName");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new { StatusId = 1, StatusName = "Przyjęto do realizacji" },
                        new { StatusId = 2, StatusName = "W przygotowaniu" },
                        new { StatusId = 3, StatusName = "W trakcie dostawy" },
                        new { StatusId = 4, StatusName = "Dostarczone" },
                        new { StatusId = 5, StatusName = "Anulowane" }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.DishSize", b =>
                {
                    b.HasOne("RestaurantApp.Model.Dish")
                        .WithMany("DishSizes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
