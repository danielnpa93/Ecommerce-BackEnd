using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeliveryTeam",
                columns: new[] { "Id", "Description", "Name", "VehicleIdentifier" },
                values: new object[,]
                {
                    { new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790"), "Equipe 01 Descriçao", "Equipe 01", "123abc" },
                    { new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1"), "Equipe 02 Descriçao", "Equipe 02", "345qwe" },
                    { new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8"), "Equipe 03 Descriçao", "Equipe 03", "123cat" },
                    { new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74"), "Equipe 04 Descriçao", "Equipe 04", "123ftg" },
                    { new Guid("47842e3b-a2d2-4339-beb4-b5db975a501d"), "Equipe 05 Descriçao", "Equipe 05", "175hdg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Money", "Name" },
                values: new object[,]
                {
                    { new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a"), "Produto 10 descrição", 500.0, "Produto 10" },
                    { new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"), "Produto 9 descrição", 110.8, "Produto 9" },
                    { new Guid("b3f132eb-be54-4e87-ac12-991177d88b01"), "Produto 8 descrição", 180.40000000000001, "Produto 8" },
                    { new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"), "Produto 7 descrição", 40.0, "Produto 7" },
                    { new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"), "Produto 6 descrição", 1200.0, "Produto 6" },
                    { new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9"), "Produto 4 descrição", 200.0, "Produto 4" },
                    { new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318"), "Produto 11 descrição", 300.0, "Produto 11" },
                    { new Guid("317ce3fa-d33d-4242-988d-0384fe90c988"), "PRoduto 3 descrição", 10.0, "Produto 3" },
                    { new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"), "Produto 2 descrição", 90.0, "Produto 2" },
                    { new Guid("f6041995-a731-408d-a2e9-27e3ca768944"), "Produto 1 descrição", 120.0, "Produto 1" },
                    { new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"), "Produto 5 descrição", 100.0, "Produto 5" },
                    { new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57"), "Produto 12 descrição", 170.0, "Produto 12" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Adress", "CreatedAt", "DeliveryDate", "DeliveryTeamId" },
                values: new object[,]
                {
                    { new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4"), "Rua 03", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790") },
                    { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), "Rua 05", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1") },
                    { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), "Rua 10", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1") },
                    { new Guid("22934202-edcd-404b-9486-52b569052ef2"), "Rua 11", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1") },
                    { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), "Rua 01", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), "Rua 02", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0"), "Rua 04", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("b96220de-ae27-4d4a-b790-912453b80c71"), "Rua 06", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), "Rua 07", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9"), "Rua 09", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744"), "Rua 13", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8") },
                    { new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0"), "Rua 08", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74") },
                    { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), "Rua 12", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74") },
                    { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), "Rua 14", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74") },
                    { new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083"), "Rua 15", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74") }
                });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4"), new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8") },
                    { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9") },
                    { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") },
                    { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") },
                    { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") },
                    { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("f6041995-a731-408d-a2e9-27e3ca768944") },
                    { new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0"), new Guid("317ce3fa-d33d-4242-988d-0384fe90c988") },
                    { new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") },
                    { new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") },
                    { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("317ce3fa-d33d-4242-988d-0384fe90c988") },
                    { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") },
                    { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") },
                    { new Guid("b96220de-ae27-4d4a-b790-912453b80c71"), new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8") },
                    { new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") },
                    { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") },
                    { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") },
                    { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76") },
                    { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57") },
                    { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") },
                    { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") },
                    { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") },
                    { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") },
                    { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") },
                    { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") },
                    { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") },
                    { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") },
                    { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") },
                    { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("f6041995-a731-408d-a2e9-27e3ca768944") },
                    { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") },
                    { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9") },
                    { new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryTeam",
                keyColumn: "Id",
                keyValue: new Guid("47842e3b-a2d2-4339-beb4-b5db975a501d"));

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("2688f2d8-b439-4fe0-8388-610991fe3816") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0"), new Guid("317ce3fa-d33d-4242-988d-0384fe90c988") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("317ce3fa-d33d-4242-988d-0384fe90c988") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"), new Guid("4d9c8060-a384-421d-90dd-17af1fd40402") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083"), new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b96220de-ae27-4d4a-b790-912453b80c71"), new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4"), new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("22934202-edcd-404b-9486-52b569052ef2"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"), new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("b3f132eb-be54-4e87-ac12-991177d88b01") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"), new Guid("f6041995-a731-408d-a2e9-27e3ca768944") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"), new Guid("f6041995-a731-408d-a2e9-27e3ca768944") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0b2efdf6-30e8-483a-90f0-26f0442a2c60"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("22934202-edcd-404b-9486-52b569052ef2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27185e0e-3534-4227-b4b3-2838cb441a3e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("31bbf9f3-38a6-413f-97d3-41d82e4c67c0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("409c3e1c-df57-4489-9309-fb0e9f0b9744"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("651bcf21-975a-4128-98b9-6f3a12a6c0b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("79767867-a0e8-48dd-bba6-debd0ced1edc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b2dbb6c3-85bc-4cda-bb1c-93aff18a3083"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b96220de-ae27-4d4a-b790-912453b80c71"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bf572803-8af0-4ea4-b3f3-aa04412e96f4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cc9b3193-f53d-45d4-bfa9-c2a1277b1472"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d3169f25-6343-4d06-94a5-4d3cf6943f52"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e0aba787-0daa-46b2-bfbd-b635138156c9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e39c6929-be21-4674-a362-aeb3171dcc3a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ed88b5e7-3703-4b32-975f-85413f3d8947"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2688f2d8-b439-4fe0-8388-610991fe3816"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("317ce3fa-d33d-4242-988d-0384fe90c988"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c338ba8-da85-441b-b66d-b4d0c6daaa57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d9c8060-a384-421d-90dd-17af1fd40402"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53fc47c3-2f6b-4236-88fb-8b32cb89f318"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b1f3d93-b995-4b5a-be18-d35bb390cde9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e5bbafd-5b15-416b-a607-c8b4070c2b3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bc829fe-8a5c-4e56-9f22-5b9ba96af5b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bfb66bc-4b48-4f37-a38d-fc10bc195dfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e35b4e6-cc0b-4984-b102-f81047c1ef76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3f132eb-be54-4e87-ac12-991177d88b01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6041995-a731-408d-a2e9-27e3ca768944"));

            migrationBuilder.DeleteData(
                table: "DeliveryTeam",
                keyColumn: "Id",
                keyValue: new Guid("05a1ca87-3f54-4b2f-bc35-f9a4544e1790"));

            migrationBuilder.DeleteData(
                table: "DeliveryTeam",
                keyColumn: "Id",
                keyValue: new Guid("43f4147e-2bd2-4ea3-84ec-f9238024a2b8"));

            migrationBuilder.DeleteData(
                table: "DeliveryTeam",
                keyColumn: "Id",
                keyValue: new Guid("4bc930e4-eea3-4edb-8985-23d25fbedf74"));

            migrationBuilder.DeleteData(
                table: "DeliveryTeam",
                keyColumn: "Id",
                keyValue: new Guid("9ffb1fde-fa00-4af8-a740-7e3011e7b0e1"));
        }
    }
}
