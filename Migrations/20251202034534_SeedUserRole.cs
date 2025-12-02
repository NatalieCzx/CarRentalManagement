using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4b4774b6-0863-440e-a8e3-ab9eb93ae0e2", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHHZCQpppDBVkJixhyx973ZvRv6q2MlMk64g0cls7Qel6wOEo/IdJoFIvu5iR6QCfQ==", null, false, "819881f2-0964-42e6-a660-f4fbdb59893f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8344), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8626), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8629), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8732), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8735), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8738), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8740), new DateTime(2025, 12, 2, 11, 45, 32, 315, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3191), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3632), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3827), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3831), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3834), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3836), new DateTime(2025, 12, 2, 11, 25, 24, 337, DateTimeKind.Local).AddTicks(3837) });
        }
    }
}
