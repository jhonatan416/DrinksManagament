using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksManagament.Data.Migrations
{
    public partial class AddAditionalSeedsForTheOtherTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 26, 10, 45, 0, 905, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 5, 26, 10, 45, 0, 905, DateTimeKind.Local).AddTicks(2317) });
        }
    }
}
