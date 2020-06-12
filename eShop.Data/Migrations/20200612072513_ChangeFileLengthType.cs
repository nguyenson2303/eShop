using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1cc9ccf8-38dc-4b51-a238-2013ec4321c8");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c12116ab-2c18-4afb-9fe2-22cd0a142061", "AQAAAAEAACcQAAAAEDQGaDDzVf4J9qu+0JJ9eLwNHr8CK1L/yIXBO/tw1NqeUWe6TtDH8OQfHCwudQ7ctg==" });

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
                value: new DateTime(2020, 6, 12, 14, 25, 12, 465, DateTimeKind.Local).AddTicks(3695));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
