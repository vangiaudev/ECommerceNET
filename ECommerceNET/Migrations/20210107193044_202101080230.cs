using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101080230 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idNVCSKH",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "idNVShip",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "ipMayKhach",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "maGiamGiaShip",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "phiShip",
                table: "DonHang");

            migrationBuilder.AlterColumn<int>(
                name: "idUser",
                table: "DonHang",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "idUser",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "idNVCSKH",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idNVShip",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ipMayKhach",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maGiamGiaShip",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "phiShip",
                table: "DonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
