using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksManagament.Data.Migrations
{
    public partial class RemoveVMTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVM");

            migrationBuilder.DropTable(
                name: "PalletVM");

            migrationBuilder.DropTable(
                name: "ProductsByPalletVM");

            migrationBuilder.DropTable(
                name: "ProductTypeVM");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "3d75ebdd-f9cb-4811-92cc-c168fa704b45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "71353f2d-e162-4784-a723-60c2267ccff4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beb7b855-37f2-47c7-b0a4-b73787489c93", "AQAAAAEAACcQAAAAEG4aFMrlNP7ovE6x/m9/fAEORtAB4iw7/WGKNzCIeKw8xPiy1rmy6e+pV8y1fT8BqA==", "62cf74a2-4640-4d3d-b13f-6aaeb1456225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "065c8f64-569c-4fbc-a583-46e12bb646ed", "AQAAAAEAACcQAAAAEEsF/UyJdRMMlRbCmU0OXOFhxDewprtvv2AfmePrtHRlqP9h9Rt9CeoGAzoQyf3NgA==", "6eb3600e-8ebd-462a-ba36-285a14904163" });

            migrationBuilder.UpdateData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 21, 33, 46, 754, DateTimeKind.Utc).AddTicks(3902), new DateTime(2023, 5, 26, 21, 33, 46, 754, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 21, 33, 46, 754, DateTimeKind.Utc).AddTicks(3903), new DateTime(2023, 5, 26, 21, 33, 46, 754, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3852), new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3853), new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "ProductsByPallets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 5, 26, 16, 33, 46, 754, DateTimeKind.Local).AddTicks(3941) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PalletVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalletVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsByPalletVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalletId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsByPalletVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalletId = table.Column<int>(type: "int", nullable: false),
                    ProductsByPalletId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceForOne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceForStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVM_PalletVM_PalletId",
                        column: x => x.PalletId,
                        principalTable: "PalletVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVM_ProductsByPalletVM_ProductsByPalletId",
                        column: x => x.ProductsByPalletId,
                        principalTable: "ProductsByPalletVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVM_ProductTypeVM_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypeVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "37555715-9d35-4d2d-8043-b13a3852ae44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "ba25dae0-1fcb-43d1-bd5d-3fe339cb8644");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c64b5f1-e050-486e-a9f6-88a772e47acc", "AQAAAAEAACcQAAAAEJ2zW3Gmf/gDRZiOrr2UOwBcPmz9rg/2Cq69wYy1UtOOydokBKJ/S4PX7Tiz8+FhJA==", "4f2a8533-7188-4735-9843-4f9385b99b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72738d26-456c-47b2-9e34-66511b31028d", "AQAAAAEAACcQAAAAEGymcWHyfb3ygMf6FWiRwrtB30gAZV2iZKaPMvRo6051Zy1r7BPR28OojaRpuXJpQg==", "99970ac6-9361-4572-b681-aa47e4a04ee3" });

            migrationBuilder.UpdateData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 20, 18, 33, 156, DateTimeKind.Utc).AddTicks(5543), new DateTime(2023, 5, 26, 20, 18, 33, 156, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 20, 18, 33, 156, DateTimeKind.Utc).AddTicks(5545), new DateTime(2023, 5, 26, 20, 18, 33, 156, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5481), new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5291), new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "ProductsByPallets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 5, 26, 15, 18, 33, 156, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVM_PalletId",
                table: "ProductVM",
                column: "PalletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVM_ProductsByPalletId",
                table: "ProductVM",
                column: "ProductsByPalletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVM_ProductTypeId",
                table: "ProductVM",
                column: "ProductTypeId");
        }
    }
}
