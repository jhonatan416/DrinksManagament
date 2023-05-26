using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksManagament.Data.Migrations
{
    public partial class AddAditionalSeedsForTheOtherTablesDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "972c53f9-cbf9-4fdb-8a36-c79a640bd639");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "3f62ac59-c938-49ed-942f-7f3b6f296850");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "412649b5-e71a-4c55-8061-3c8741ff85be", "AQAAAAEAACcQAAAAENq9Tbn4Le5X9jwCHPswGN0h+jx41CUQy4xn2a4nKdc0NR+7qyud8omqQ2ZZ4anXKw==", "32297f5b-e70c-42e0-9db0-ffc3646d2d8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d73671b0-4800-4205-89b4-12087852bf14", "AQAAAAEAACcQAAAAEHEMGWhuKzFXsPxc7Pbh7xfE4Z+iGNpYEsVGYBXJ1EK+Zdv3cc9OH6A7lCge5ETyTQ==", "8adf8725-d508-464d-b4be-d0a3a283764b" });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "DateCreated", "DateModified", "PositionCount" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 26, 16, 33, 25, 698, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 5, 26, 16, 33, 25, 698, DateTimeKind.Utc).AddTicks(8558), 50 },
                    { 2, new DateTime(2023, 5, 26, 16, 33, 25, 698, DateTimeKind.Utc).AddTicks(8559), new DateTime(2023, 5, 26, 16, 33, 25, 698, DateTimeKind.Utc).AddTicks(8559), 20 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 11, 33, 25, 698, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 5, 26, 11, 33, 25, 698, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.InsertData(
                table: "ProductsByPallets",
                columns: new[] { "Id", "DateCreated", "DateModified", "PalletId", "ProductId", "Quatity" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 11, 33, 25, 698, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 5, 26, 11, 33, 25, 698, DateTimeKind.Local).AddTicks(8612), 1, 1, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsByPallets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "727c213c-a0ba-400b-b052-826e3e968812");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "addf132f-6d6d-4a94-8756-c9e3ebc5e945");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29146aa5-c628-419d-84ce-4ef86616fd00", "AQAAAAEAACcQAAAAEMx1tzUz1+cDwZboFCuC25977rjn7e2Fxv3FiXt5M9TdlLG7rYGS7+SPDItO7oRPCw==", "c86a6036-77e3-4ade-9d5a-f67aff112f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d74a52b-c47c-427c-ab08-f43f56f9b56b", "AQAAAAEAACcQAAAAEG48lPAFkaKLML+h6QHJjeEotOJkyBYB2VFFITFGsHFjmAuqgSQIhXI3fl1jlA/quQ==", "6d5275a4-3fd4-4fd2-8f77-ff16054bf0f1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 11, 32, 2, 435, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 5, 26, 11, 32, 2, 435, DateTimeKind.Local).AddTicks(5179) });
        }
    }
}
