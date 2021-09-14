﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cosmetic_hub__e_shopping_system_.Models;

namespace cosmetic_hub__e_shopping_system_.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210831222414_newDatabase")]
    partial class newDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPreferredProduct")
                        .HasColumnType("bit");

                    b.Property<string>("LongProductDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ShortProductDetails")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductCategoryDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductOrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ProductOrderTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductOrderId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ProductOrderDetail", b =>
                {
                    b.Property<int>("ProductOrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductOrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ProductOrderDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductOrderId");

                    b.ToTable("ProductOrderDetails");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ShoppingCartId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ShoppingCartItems", b =>
                {
                    b.Property<int>("ShoppingCartItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.Product", b =>
                {
                    b.HasOne("cosmetic_hub__e_shopping_system_.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ProductOrderDetail", b =>
                {
                    b.HasOne("cosmetic_hub__e_shopping_system_.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cosmetic_hub__e_shopping_system_.Models.ProductOrder", "ProductOrder")
                        .WithMany("ProductOrderLines")
                        .HasForeignKey("ProductOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cosmetic_hub__e_shopping_system_.Models.ShoppingCartItems", b =>
                {
                    b.HasOne("cosmetic_hub__e_shopping_system_.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("cosmetic_hub__e_shopping_system_.Models.ShoppingCart", null)
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId");
                });
#pragma warning restore 612, 618
        }
    }
}
