using Microsoft.EntityFrameworkCore.Migrations;

namespace BarTown.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblConfig",
                columns: table => new
                {
                    pkConfig = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkPosition = table.Column<int>(nullable: true),
                    ConfigDesc1 = table.Column<string>(maxLength: 1000, nullable: true),
                    ConfigDesc2 = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblConfig", x => x.pkConfig);
                });

            migrationBuilder.CreateTable(
                name: "tblLocation",
                columns: table => new
                {
                    pkLocation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(maxLength: 50, nullable: false),
                    Latitude = table.Column<string>(maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(maxLength: 50, nullable: true),
                    fkTehranRegion = table.Column<int>(nullable: true),
                    fkLocationType = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLocation", x => x.pkLocation);
                });

            migrationBuilder.CreateTable(
                name: "tblShippingCost",
                columns: table => new
                {
                    pkShippingCost = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkOriginLocation = table.Column<int>(nullable: false),
                    fkDestinationLocation = table.Column<int>(nullable: false),
                    fkTruckType = table.Column<int>(nullable: false),
                    ShippingCost = table.Column<int>(nullable: false),
                    ShippingCostDesc = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblShippingCost", x => x.pkShippingCost);
                });

            migrationBuilder.CreateTable(
                name: "tblTruckService",
                columns: table => new
                {
                    pkTruckService = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkTruckType = table.Column<int>(nullable: false),
                    LoadingTime = table.Column<int>(nullable: false),
                    UnLoadingTime = table.Column<int>(nullable: false),
                    OverLoadCost = table.Column<int>(nullable: false),
                    TruckServiceDesc = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTruckService", x => x.pkTruckService);
                });

            migrationBuilder.CreateTable(
                name: "tblTruckType",
                columns: table => new
                {
                    pkTruckType = table.Column<int>(nullable: false),
                    TruckTypeName = table.Column<string>(maxLength: 50, nullable: false),
                    TruckTypeDesc = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTruckType", x => x.pkTruckType);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblLocation",
                table: "tblLocation",
                column: "LocationName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblConfig");

            migrationBuilder.DropTable(
                name: "tblLocation");

            migrationBuilder.DropTable(
                name: "tblShippingCost");

            migrationBuilder.DropTable(
                name: "tblTruckService");

            migrationBuilder.DropTable(
                name: "tblTruckType");
        }
    }
}
