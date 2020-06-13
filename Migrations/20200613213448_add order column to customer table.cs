using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingPizza.Migrations
{
    public partial class addordercolumntocustomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Order",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Customers");
        }
    }
}
