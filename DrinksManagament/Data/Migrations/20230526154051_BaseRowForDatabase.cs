using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksManagament.Data.Migrations
{
    public partial class BaseRowForDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a78e54etb-7f01-455b-9f83-fd8cdccc8549", "9f81265e-6e71-4eb7-969b-e3dbbeb0a4bb", "User", "USER" },
                    { "d47e33eb-7f01-455b-9f83-fd5cdccc7884", "458d02bd-5e32-4416-9216-1d34172d6dc6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d47e33eb-7f01-455b-9f76-fd6cdccc1284", 0, "8e0074e1-cad0-47b6-9785-2dff1fe5e334", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECTcox/5BOk2aS2Qcj1jU6FvpjS96Tut6wE2llM/US7ZqbW9QUda/5TyCx6wN+uJqA==", null, false, "d45a2e0f-6266-4b1d-b060-925a9a5fc50d", false, "admin@localhost.com" },
                    { "d47e33eb-7f01-455b-9f76-fd6cdccc8897", 0, "e5bd703c-5f7a-48db-b511-89fd2e14be20", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDUQlXpgkR+4wrhT6fedien8UBtK2pL0007O/5PTdY/6f35NhPbAOk6OyBopXlpwhw==", null, false, "ed356bc2-5f03-4115-a9f9-36d8d8b4daa8", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaseosas" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refrescos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d47e33eb-7f01-455b-9f83-fd5cdccc7884", "d47e33eb-7f01-455b-9f76-fd6cdccc1284" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a78e54etb-7f01-455b-9f83-fd8cdccc8549", "d47e33eb-7f01-455b-9f76-fd6cdccc8897" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d47e33eb-7f01-455b-9f83-fd5cdccc7884", "d47e33eb-7f01-455b-9f76-fd6cdccc1284" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a78e54etb-7f01-455b-9f83-fd8cdccc8549", "d47e33eb-7f01-455b-9f76-fd6cdccc8897" });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78e54etb-7f01-455b-9f83-fd8cdccc8549");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f83-fd5cdccc7884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc1284");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d47e33eb-7f01-455b-9f76-fd6cdccc8897");
        }
    }
}
