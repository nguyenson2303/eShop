using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 10, 11, 38, 23, 569, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d9ae47a4-e703-444e-8f6a-d4a9a119a61a");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b888a1de-8a68-4bc8-85da-9e465b2eb3ab", "AQAAAAEAACcQAAAAEOcJYRXDRCX7hNosS+Kh5kPmr4qmaPDOliFEAPhoINnvAwTLfSygtXCHvhEMVm2reQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 11, 21, 7, 44, 236, DateTimeKind.Local).AddTicks(56));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 10, 11, 38, 23, 569, DateTimeKind.Local).AddTicks(2812),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "737206a2-697f-4576-8915-fb0d196985b6");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49e2f721-d059-40a8-a51c-4ebadd9a5215", "AQAAAAEAACcQAAAAEPpU8KI0Z04YW7D2NBXnb4yFgs6A1/6/dYK10h3nZfnhKmIsftWXi4XOqV89BA0ogg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 10, 11, 38, 23, 593, DateTimeKind.Local).AddTicks(3926));
        }
    }
}
