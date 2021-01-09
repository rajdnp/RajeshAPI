using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RajeshAPI.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Vehicles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Models",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Makes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Makes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Features",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_VehicleId",
                table: "ContactDetails",
                column: "VehicleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Features");
        }
    }
}
