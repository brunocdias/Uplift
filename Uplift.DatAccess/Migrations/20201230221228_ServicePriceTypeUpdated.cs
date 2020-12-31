using Microsoft.EntityFrameworkCore.Migrations;

namespace Uplift.DatAccess.Migrations
{
    public partial class ServicePriceTypeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Service",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
