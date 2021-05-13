using Microsoft.EntityFrameworkCore.Migrations;

namespace TenantsAss.DataAccess.Migrations
{
    public partial class Mm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Apartment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Apartment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Apartment");
        }
    }
}
