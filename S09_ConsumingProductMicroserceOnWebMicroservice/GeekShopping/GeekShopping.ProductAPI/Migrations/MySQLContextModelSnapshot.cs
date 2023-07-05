﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "DESCRIPTION RANDON",
                            ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                            Name = "Camiseta Dragon Ball",
                            Price = 4.43497054235638m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "DESCRIPTION RANDON",
                            ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg",
                            Name = "Camiseta Elon Musck Sapcex",
                            Price = 76.4343530996706m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt",
                            Description = "DESCRIPTION RANDON",
                            ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg",
                            Name = "Camiseta GNU Linux",
                            Price = 14.3897763189883m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "DESCRIPTION RANDON",
                            ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg",
                            Name = "Camista Mars",
                            Price = 30.1453785911202m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "DESCRIPTION RANDON",
                            ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg",
                            Name = "Camiseta Gamer",
                            Price = 75.0869692488494m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
