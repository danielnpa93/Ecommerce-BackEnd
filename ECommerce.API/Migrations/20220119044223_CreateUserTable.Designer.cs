﻿// <auto-generated />
using System;
using ECommerce.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.API.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20220119044223_CreateUserTable")]
    partial class CreateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce.API.Models.Entities.DeliveryTeam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryTeam");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790"),
                            Description = "Equipe 01 Descriçao",
                            Name = "Equipe 01",
                            VehicleIdentifier = "123abc"
                        },
                        new
                        {
                            Id = new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1"),
                            Description = "Equipe 02 Descriçao",
                            Name = "Equipe 02",
                            VehicleIdentifier = "345qwe"
                        },
                        new
                        {
                            Id = new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8"),
                            Description = "Equipe 03 Descriçao",
                            Name = "Equipe 03",
                            VehicleIdentifier = "123cat"
                        },
                        new
                        {
                            Id = new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74"),
                            Description = "Equipe 04 Descriçao",
                            Name = "Equipe 04",
                            VehicleIdentifier = "123ftg"
                        },
                        new
                        {
                            Id = new Guid("47842e3b-a2d2-4339-beb4-b5db975a501d"),
                            Description = "Equipe 05 Descriçao",
                            Name = "Equipe 05",
                            VehicleIdentifier = "175hdg"
                        });
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DeliveryTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryTeamId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"),
                            Adress = "Rua 01",
                            CreatedAt = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"),
                            Adress = "Rua 02",
                            CreatedAt = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74")
                        },
                        new
                        {
                            Id = new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4"),
                            Adress = "Rua 03",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74")
                        },
                        new
                        {
                            Id = new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0"),
                            Adress = "Rua 04",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74")
                        },
                        new
                        {
                            Id = new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"),
                            Adress = "Rua 05",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74")
                        },
                        new
                        {
                            Id = new Guid("b96220de-ae27-4d4a-b790-912453b80c71"),
                            Adress = "Rua 06",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"),
                            Adress = "Rua 07",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0"),
                            Adress = "Rua 08",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8")
                        },
                        new
                        {
                            Id = new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9"),
                            Adress = "Rua 09",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8")
                        },
                        new
                        {
                            Id = new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"),
                            Adress = "Rua 10",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("22934202-edcd-404b-9486-52b569052ef2"),
                            Adress = "Rua 11",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1")
                        },
                        new
                        {
                            Id = new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"),
                            Adress = "Rua 12",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744"),
                            Adress = "Rua 13",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1")
                        },
                        new
                        {
                            Id = new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"),
                            Adress = "Rua 14",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790")
                        },
                        new
                        {
                            Id = new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083"),
                            Adress = "Rua 15",
                            CreatedAt = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryDate = new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryTeamId = new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1")
                        });
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.OrderProduct", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersProducts");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"),
                            OrderId = new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472")
                        },
                        new
                        {
                            ProductId = new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"),
                            OrderId = new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472")
                        },
                        new
                        {
                            ProductId = new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"),
                            OrderId = new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4")
                        },
                        new
                        {
                            ProductId = new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"),
                            OrderId = new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4")
                        },
                        new
                        {
                            ProductId = new Guid("317ce3fa-d33d-4242-988d-0384fe90c988"),
                            OrderId = new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0")
                        },
                        new
                        {
                            ProductId = new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"),
                            OrderId = new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0")
                        },
                        new
                        {
                            ProductId = new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"),
                            OrderId = new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0")
                        },
                        new
                        {
                            ProductId = new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a"),
                            OrderId = new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("b96220de-ae27-4d4a-b790-912453b80c71")
                        },
                        new
                        {
                            ProductId = new Guid("b3f132eb-be54-4e87-ac12-991177d88b01"),
                            OrderId = new Guid("b96220de-ae27-4d4a-b790-912453b80c71")
                        },
                        new
                        {
                            ProductId = new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"),
                            OrderId = new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc")
                        },
                        new
                        {
                            ProductId = new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"),
                            OrderId = new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc")
                        },
                        new
                        {
                            ProductId = new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"),
                            OrderId = new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0")
                        },
                        new
                        {
                            ProductId = new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318"),
                            OrderId = new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9")
                        },
                        new
                        {
                            ProductId = new Guid("b3f132eb-be54-4e87-ac12-991177d88b01"),
                            OrderId = new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9")
                        },
                        new
                        {
                            ProductId = new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"),
                            OrderId = new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9")
                        },
                        new
                        {
                            ProductId = new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"),
                            OrderId = new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947")
                        },
                        new
                        {
                            ProductId = new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57"),
                            OrderId = new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947")
                        },
                        new
                        {
                            ProductId = new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a"),
                            OrderId = new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947")
                        },
                        new
                        {
                            ProductId = new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"),
                            OrderId = new Guid("22934202-edcd-404b-9486-52b569052ef2")
                        },
                        new
                        {
                            ProductId = new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9"),
                            OrderId = new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60")
                        },
                        new
                        {
                            ProductId = new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57"),
                            OrderId = new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744")
                        },
                        new
                        {
                            ProductId = new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"),
                            OrderId = new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744")
                        },
                        new
                        {
                            ProductId = new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"),
                            OrderId = new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52")
                        },
                        new
                        {
                            ProductId = new Guid("f6041995-a731-408d-a2e9-27e3ca768944"),
                            OrderId = new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52")
                        },
                        new
                        {
                            ProductId = new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"),
                            OrderId = new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083")
                        },
                        new
                        {
                            ProductId = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            OrderId = new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083")
                        },
                        new
                        {
                            ProductId = new Guid("f6041995-a731-408d-a2e9-27e3ca768944"),
                            OrderId = new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083")
                        });
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Money")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6041995-a731-408d-a2e9-27e3ca768944"),
                            Description = "Produto 1 descrição",
                            Money = 120.0,
                            Name = "Produto 1"
                        },
                        new
                        {
                            Id = new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"),
                            Description = "Produto 2 descrição",
                            Money = 90.0,
                            Name = "Produto 2"
                        },
                        new
                        {
                            Id = new Guid("317ce3fa-d33d-4242-988d-0384fe90c988"),
                            Description = "PRoduto 3 descrição",
                            Money = 10.0,
                            Name = "Produto 3"
                        },
                        new
                        {
                            Id = new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9"),
                            Description = "Produto 4 descrição",
                            Money = 200.0,
                            Name = "Produto 4"
                        },
                        new
                        {
                            Id = new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"),
                            Description = "Produto 5 descrição",
                            Money = 100.0,
                            Name = "Produto 5"
                        },
                        new
                        {
                            Id = new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"),
                            Description = "Produto 6 descrição",
                            Money = 1200.0,
                            Name = "Produto 6"
                        },
                        new
                        {
                            Id = new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"),
                            Description = "Produto 7 descrição",
                            Money = 40.0,
                            Name = "Produto 7"
                        },
                        new
                        {
                            Id = new Guid("b3f132eb-be54-4e87-ac12-991177d88b01"),
                            Description = "Produto 8 descrição",
                            Money = 180.40000000000001,
                            Name = "Produto 8"
                        },
                        new
                        {
                            Id = new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"),
                            Description = "Produto 9 descrição",
                            Money = 110.8,
                            Name = "Produto 9"
                        },
                        new
                        {
                            Id = new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a"),
                            Description = "Produto 10 descrição",
                            Money = 500.0,
                            Name = "Produto 10"
                        },
                        new
                        {
                            Id = new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318"),
                            Description = "Produto 11 descrição",
                            Money = 300.0,
                            Name = "Produto 11"
                        },
                        new
                        {
                            Id = new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57"),
                            Description = "Produto 12 descrição",
                            Money = 170.0,
                            Name = "Produto 12"
                        });
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.Order", b =>
                {
                    b.HasOne("ECommerce.API.Models.Entities.DeliveryTeam", "DeliveryTeam")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryTeam");
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.OrderProduct", b =>
                {
                    b.HasOne("ECommerce.API.Models.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.API.Models.Entities.Product", "Product")
                        .WithMany("OrdersProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.DeliveryTeam", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("ECommerce.API.Models.Entities.Product", b =>
                {
                    b.Navigation("OrdersProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
