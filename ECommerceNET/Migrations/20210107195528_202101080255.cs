using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101080255 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "giamGiaSP",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "metaTitle",
                table: "SanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "giamGiaSP",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "metaTitle",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
