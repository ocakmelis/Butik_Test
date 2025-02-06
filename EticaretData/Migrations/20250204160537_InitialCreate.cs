using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EticaretData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 2, 4, 19, 5, 35, 100, DateTimeKind.Local).AddTicks(8958), new Guid("d01b63f9-d6a4-44f5-8873-c4ab7188bfcf") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 4, 19, 5, 35, 104, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 4, 19, 5, 35, 104, DateTimeKind.Local).AddTicks(4754));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 2, 4, 17, 56, 2, 870, DateTimeKind.Local).AddTicks(5935), new Guid("2cd93ae2-6baa-4710-854d-2e675c4964d0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 4, 17, 56, 2, 911, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 4, 17, 56, 2, 911, DateTimeKind.Local).AddTicks(9454));
        }
    }
}
