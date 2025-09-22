using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCore_Maktab135.Migrations
{
    /// <inheritdoc />
    public partial class addproductseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "CreateAt", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Black", new DateTime(2025, 9, 22, 22, 51, 19, 502, DateTimeKind.Local).AddTicks(4576), "Iphone 16", 9000000 },
                    { 2, 1, "Silver", new DateTime(2025, 9, 22, 22, 51, 19, 502, DateTimeKind.Local).AddTicks(8747), "Iphone 10", 2000000 },
                    { 3, 3, "Black", new DateTime(2025, 9, 22, 22, 51, 19, 502, DateTimeKind.Local).AddTicks(8753), "Asus N510", 3500000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
