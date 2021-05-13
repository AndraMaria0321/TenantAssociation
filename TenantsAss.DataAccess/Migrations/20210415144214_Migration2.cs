using Microsoft.EntityFrameworkCore.Migrations;

namespace TenantsAss.DataAccess.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Invoice");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Invoice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Invoice");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
