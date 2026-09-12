using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRP.Migrations
{
    /// <inheritdoc />
    public partial class Restructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isExpirable",
                table: "PhysDataRec",
                newName: "IsExpirable");

            migrationBuilder.RenameColumn(
                name: "Perishable",
                table: "PhysDataRec",
                newName: "OpenLifespanDays");

            migrationBuilder.RenameColumn(
                name: "LifespanDays",
                table: "PhysDataRec",
                newName: "ClosedLifespanDays");

            migrationBuilder.AddColumn<float>(
                name: "QuantityConsumed",
                table: "FoodBatches",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityConsumed",
                table: "FoodBatches");

            migrationBuilder.RenameColumn(
                name: "IsExpirable",
                table: "PhysDataRec",
                newName: "isExpirable");

            migrationBuilder.RenameColumn(
                name: "OpenLifespanDays",
                table: "PhysDataRec",
                newName: "Perishable");

            migrationBuilder.RenameColumn(
                name: "ClosedLifespanDays",
                table: "PhysDataRec",
                newName: "LifespanDays");
        }
    }
}
