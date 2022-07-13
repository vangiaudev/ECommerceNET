using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101101259 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idSP",
                table: "GioHang");

            migrationBuilder.AddColumn<int>(
                name: "giasp",
                table: "GioHang",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tensp",
                table: "GioHang",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "giasp",
                table: "GioHang");

            migrationBuilder.DropColumn(
                name: "tensp",
                table: "GioHang");

            migrationBuilder.AddColumn<int>(
                name: "idSP",
                table: "GioHang",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
