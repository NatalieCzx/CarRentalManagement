using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9152), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9187), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9190), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9190), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9452), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9453), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9455), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9456), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9576), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9577), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9579), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9581), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9582), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9584), new DateTime(2025, 12, 2, 11, 0, 57, 942, DateTimeKind.Local).AddTicks(9584), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
