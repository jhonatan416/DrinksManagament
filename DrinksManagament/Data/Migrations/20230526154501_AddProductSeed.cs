using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksManagament.Data.Migrations
{
    public partial class AddProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "c11eafa2-82b5-47f9-ba7f-b738ca2d36cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "cbe41762-8b91-401e-a7b2-7b36c2041381");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dfd54f3-7e7c-4e06-817b-942986d5cae9", "AQAAAAEAACcQAAAAEDUG12m0jmv2202gvwD7oqZUuVebMbtZg+juMGUI63UbYFM9AybxsYBSTIc3Rd/4mQ==", "347b1507-8116-4b82-beef-0a95291198f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbcc66ef-153d-4404-a7e5-2bbf8de82cf3", "AQAAAAEAACcQAAAAEAakSJiGsS9tMPC77SdlrizhAt5ulEgXoQNiO4z4Uy7EO5oSevAfmxjL4QXG8tEwJw==", "743b6b0f-cfa4-439e-bdd9-0ab1c644a131" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "Name", "PriceForOne", "PriceForStock", "ProductTypeId" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 10, 45, 0, 905, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 5, 26, 10, 45, 0, 905, DateTimeKind.Local).AddTicks(2317), "Coca Cola 350 ML", "Coca Cola", 1500m, 1200m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                column: "ConcurrencyStamp",
                value: "9f81265e-6e71-4eb7-969b-e3dbbeb0a4bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                column: "ConcurrencyStamp",
                value: "458d02bd-5e32-4416-9216-1d34172d6dc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e0074e1-cad0-47b6-9785-2dff1fe5e334", "AQAAAAEAACcQAAAAECTcox/5BOk2aS2Qcj1jU6FvpjS96Tut6wE2llM/US7ZqbW9QUda/5TyCx6wN+uJqA==", "d45a2e0f-6266-4b1d-b060-925a9a5fc50d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5bd703c-5f7a-48db-b511-89fd2e14be20", "AQAAAAEAACcQAAAAEDUQlXpgkR+4wrhT6fedien8UBtK2pL0007O/5PTdY/6f35NhPbAOk6OyBopXlpwhw==", "ed356bc2-5f03-4115-a9f9-36d8d8b4daa8" });
        }
    }
}
