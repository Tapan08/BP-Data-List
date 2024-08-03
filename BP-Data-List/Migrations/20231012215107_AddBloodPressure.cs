using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TPAssignment_1.Migrations
{
    /// <inheritdoc />
    public partial class AddBloodPressure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "PositionId",
               table: "Position",
               type: "nvarchar(450)",
               nullable: false,
               defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "BloodPressures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    systolic = table.Column<int>(type: "int", nullable: false),
                    diastolicValues = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodPressures_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "Name" },
                values: new object[,]
                {
                    { "L", "Lying Down" },
                    { "S", "Standing" },
                    { "S1", "Siting" }
                });

            migrationBuilder.InsertData(
                table: "BloodPressures",
                columns: new[] { "Id", "DateCreated", "PositionId", "diastolicValues", "systolic" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1212), "S", 80, 120 },
                    { 2, new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1214), "S1", 60, 100 },
                    { 3, new DateTime(2023, 10, 12, 21, 51, 6, 975, DateTimeKind.Utc).AddTicks(1215), "L", 100, 140 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodPressures_PositionId",
                table: "BloodPressures",
                column: "PositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodPressures");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
