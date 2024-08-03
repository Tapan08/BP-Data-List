using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPAssignment_1.Migrations
{
    /// <inheritdoc />
    public partial class Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 59, 23, 809, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 59, 23, 809, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 59, 23, 809, DateTimeKind.Utc).AddTicks(745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "BloodPressures",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1215));
        }
    }
}
