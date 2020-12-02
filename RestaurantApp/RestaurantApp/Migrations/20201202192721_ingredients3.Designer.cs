﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantApp.Database;

namespace RestaurantApp.Migrations
{
    [DbContext(typeof(RestaurantAppDbContext))]
    [Migration("20201202192721_ingredients3")]
    partial class ingredients3
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurantApp.Model.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Availibility")
                        .HasColumnName("availibility");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(255);

                    b.Property<string>("ImageUrl")
                        .HasColumnName("imageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new { Id = 1, Availibility = true, Description = "sos, ser, szynka, pieczarki", ImageUrl = "", Name = "Capriciosa", Price = 39.5 },
                        new { Id = 2, Availibility = true, Description = "sos, ser, salami pepperoni", ImageUrl = "", Name = "Pepperoni", Price = 36.5 },
                        new { Id = 3, Availibility = true, Description = "sos, ser, pieczarki", ImageUrl = "", Name = "Funghi", Price = 36.5 },
                        new { Id = 4, Availibility = true, Description = "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki", ImageUrl = "", Name = "Carbonara", Price = 45.5 },
                        new { Id = 5, Availibility = true, Description = "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek", ImageUrl = "", Name = "Broccoli", Price = 47.5 },
                        new { Id = 6, Availibility = false, Description = "sos pomidorowy z ziołami, ser", ImageUrl = "", Name = "Margarita", Price = 27.5 }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnName("Amount");

                    b.Property<int?>("DishId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new { Id = 1, Amount = 100.0, Name = "Ser" },
                        new { Id = 2, Amount = 100.0, Name = "Sos" },
                        new { Id = 3, Amount = 100.0, Name = "Szynka" },
                        new { Id = 4, Amount = 100.0, Name = "Pieczarki" },
                        new { Id = 5, Amount = 100.0, Name = "Salami Pepperoni" },
                        new { Id = 6, Amount = 100.0, Name = "Cebula" },
                        new { Id = 7, Amount = 100.0, Name = "Boczek" },
                        new { Id = 8, Amount = 100.0, Name = "Kurczak" }
                    );
                });

            modelBuilder.Entity("RestaurantApp.Model.Ingredient", b =>
                {
                    b.HasOne("RestaurantApp.Model.Dish")
                        .WithMany("Ingredients")
                        .HasForeignKey("DishId");
                });
#pragma warning restore 612, 618
        }
    }
}