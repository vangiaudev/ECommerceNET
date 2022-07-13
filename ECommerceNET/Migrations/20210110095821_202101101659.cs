using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101101659 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "giamGia",
                table: "ChiTietDonHang");

            migrationBuilder.DropColumn(
                name: "thuocTinhSP",
                table: "ChiTietDonHang");

            migrationBuilder.AddColumn<int>(
                name: "thanhTien",
                table: "ChiTietDonHang",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "thanhTien",
                table: "ChiTietDonHang");

            migrationBuilder.AddColumn<int>(
                name: "giamGia",
                table: "ChiTietDonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "thuocTinhSP",
                table: "ChiTietDonHang",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
