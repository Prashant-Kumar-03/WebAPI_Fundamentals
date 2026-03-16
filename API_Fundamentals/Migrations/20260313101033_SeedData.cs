using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_Fundamentals.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "contact@techsolutions.com", "Tech Solutions Inc" },
                    { 2, "info@globallogistics.net", "Global Logistics" },
                    { 3, "hello@creativedesigns.io", "Creative Designs" },
                    { 4, "support@healthfirst.org", "HealthFirst Group" },
                    { 5, "sales@modernretail.com", "Modern Retailers" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2026, 3, 2, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4823), 492.219870277506m },
                    { 2, 3, new DateTime(2026, 2, 18, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4834), 481.372226767036m },
                    { 3, 4, new DateTime(2026, 3, 3, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4836), 123.952310683322m },
                    { 4, 5, new DateTime(2026, 3, 2, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4838), 235.652040401718m },
                    { 5, 1, new DateTime(2026, 2, 26, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4839), 264.111623079825m },
                    { 6, 2, new DateTime(2026, 2, 23, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4842), 298.039250810489m },
                    { 7, 3, new DateTime(2026, 2, 21, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4844), 60.1311937855346m },
                    { 8, 4, new DateTime(2026, 2, 21, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4845), 449.068948399257m },
                    { 9, 5, new DateTime(2026, 3, 3, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4847), 142.89739252972m },
                    { 10, 1, new DateTime(2026, 3, 6, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4849), 21.3036805196244m },
                    { 11, 2, new DateTime(2026, 2, 22, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4850), 329.185040417522m },
                    { 12, 3, new DateTime(2026, 2, 23, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4851), 475.088011120991m },
                    { 13, 4, new DateTime(2026, 2, 12, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4852), 33.5244002551214m },
                    { 14, 5, new DateTime(2026, 3, 12, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4853), 199.772996596152m },
                    { 15, 1, new DateTime(2026, 2, 23, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4855), 295.658671538789m },
                    { 16, 2, new DateTime(2026, 3, 8, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4856), 85.5950573997863m },
                    { 17, 3, new DateTime(2026, 2, 13, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4857), 451.220211175506m },
                    { 18, 4, new DateTime(2026, 2, 28, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4912), 201.29849647634m },
                    { 19, 5, new DateTime(2026, 3, 9, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4913), 371.946899715216m },
                    { 20, 1, new DateTime(2026, 3, 7, 10, 10, 33, 344, DateTimeKind.Utc).AddTicks(4915), 218.096809034224m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
