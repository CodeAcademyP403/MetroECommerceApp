using Microsoft.EntityFrameworkCore.Migrations;

namespace MetroEcommerceApp.Migrations
{
    public partial class AddedVisibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "SubCategories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "ProductColors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "Colors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "Brands",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Brands");
        }
    }
}
