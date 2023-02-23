using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Patika_Hafta1_Odev.Migrations
{
    public partial class SeedProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2023, 1, 31, 2, 28, 52, 710, DateTimeKind.Local).AddTicks(2068), null, "Bilgisayar", 20000m, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2023, 1, 31, 2, 28, 52, 711, DateTimeKind.Local).AddTicks(7459), null, "Telefon", 12000m, 3200 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2023, 1, 31, 2, 28, 52, 711, DateTimeKind.Local).AddTicks(7485), null, "Klavye", 1000m, 3200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
