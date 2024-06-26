﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wise_wallet_api.Data;

#nullable disable

namespace wise_wallet_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240328203621_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("wise_wallet_api.Domains.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CardId"));

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<int>("CardStatus")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.HasIndex("ClientId");

                    b.HasIndex("TableId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("ClephoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientCPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("double");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("CardId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TableId"));

                    b.Property<string>("InsideLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<int>("TableStatus")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Card", b =>
                {
                    b.HasOne("wise_wallet_api.Domains.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wise_wallet_api.Domains.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Item", b =>
                {
                    b.HasOne("wise_wallet_api.Domains.Card", null)
                        .WithMany("Itens")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("wise_wallet_api.Domains.Card", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
