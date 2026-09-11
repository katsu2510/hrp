using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysDataRec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Perishable = table.Column<bool>(type: "INTEGER", nullable: true),
                    LifespanDays = table.Column<int>(type: "INTEGER", nullable: true),
                    isExpirable = table.Column<bool>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysDataRec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodBatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhysDataRecId = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<float>(type: "REAL", nullable: false),
                    isOpen = table.Column<bool>(type: "INTEGER", nullable: false),
                    OpenedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodBatches_PhysDataRec_FoodId",
                        column: x => x.FoodId,
                        principalTable: "PhysDataRec",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodBatches_PhysDataRec_PhysDataRecId",
                        column: x => x.PhysDataRecId,
                        principalTable: "PhysDataRec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodBatches_FoodId",
                table: "FoodBatches",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBatches_PhysDataRecId",
                table: "FoodBatches",
                column: "PhysDataRecId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodBatches");

            migrationBuilder.DropTable(
                name: "PhysDataRec");
        }
    }
}
