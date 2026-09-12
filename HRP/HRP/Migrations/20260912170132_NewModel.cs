using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRP.Migrations
{
    /// <inheritdoc />
    public partial class NewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedLifespanDays",
                table: "PhysDataRec");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClosedLifespanDays",
                table: "PhysDataRec",
                type: "INTEGER",
                nullable: true);
        }
    }
}
