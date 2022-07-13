using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101070313 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banner_User_idUser",
                table: "Banner");

            migrationBuilder.DropForeignKey(
                name: "FK_ChinhSachGiaoHang_User_idUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DieuKhoanDichVu_User_idUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHang_SanPham_idSP",
                table: "GioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_GioiThieu_User_idUser",
                table: "GioiThieu");

            migrationBuilder.DropForeignKey(
                name: "FK_MaGiamGia_User_idUser",
                table: "MaGiamGia");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyDinhChung_User_idUser",
                table: "QuyDinhChung");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_ThuongHieu_idThuongHieu",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_User_idUser",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idThuongHieu",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idUser",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_QuyDinhChung_idUser",
                table: "QuyDinhChung");

            migrationBuilder.DropIndex(
                name: "IX_MaGiamGia_idUser",
                table: "MaGiamGia");

            migrationBuilder.DropIndex(
                name: "IX_GioiThieu_idUser",
                table: "GioiThieu");

            migrationBuilder.DropIndex(
                name: "IX_GioHang_idSP",
                table: "GioHang");

            migrationBuilder.DropIndex(
                name: "IX_DieuKhoanDichVu_idUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropIndex(
                name: "IX_ChinhSachGiaoHang_idUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropIndex(
                name: "IX_Banner_idUser",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "idThuongHieu",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "QuyDinhChung");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "MaGiamGia");

            migrationBuilder.DropColumn(
                name: "loaiMGG",
                table: "MaGiamGia");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "GioiThieu");

            migrationBuilder.DropColumn(
                name: "hinhSP",
                table: "GioHang");

            migrationBuilder.DropColumn(
                name: "phanLoai",
                table: "GioHang");

            migrationBuilder.DropColumn(
                name: "tenSP",
                table: "GioHang");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "Banner");

            migrationBuilder.AddColumn<int>(
                name: "ThuongHieuidThuongHieu",
                table: "SanPham",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "SanPham",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "QuyDinhChung",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "MaGiamGia",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "GioiThieu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SanPhamidSP",
                table: "GioHang",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "DieuKhoanDichVu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "ChinhSachGiaoHang",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "Banner",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ThuongHieuidThuongHieu",
                table: "SanPham",
                column: "ThuongHieuidThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_UseridUser",
                table: "SanPham",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_QuyDinhChung_UseridUser",
                table: "QuyDinhChung",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaGiamGia_UseridUser",
                table: "MaGiamGia",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioiThieu_UseridUser",
                table: "GioiThieu",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_SanPhamidSP",
                table: "GioHang",
                column: "SanPhamidSP");

            migrationBuilder.CreateIndex(
                name: "IX_DieuKhoanDichVu_UseridUser",
                table: "DieuKhoanDichVu",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachGiaoHang_UseridUser",
                table: "ChinhSachGiaoHang",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_Banner_UseridUser",
                table: "Banner",
                column: "UseridUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Banner_User_UseridUser",
                table: "Banner",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChinhSachGiaoHang_User_UseridUser",
                table: "ChinhSachGiaoHang",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DieuKhoanDichVu_User_UseridUser",
                table: "DieuKhoanDichVu",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GioHang_SanPham_SanPhamidSP",
                table: "GioHang",
                column: "SanPhamidSP",
                principalTable: "SanPham",
                principalColumn: "idSP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GioiThieu_User_UseridUser",
                table: "GioiThieu",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaGiamGia_User_UseridUser",
                table: "MaGiamGia",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyDinhChung_User_UseridUser",
                table: "QuyDinhChung",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_ThuongHieu_ThuongHieuidThuongHieu",
                table: "SanPham",
                column: "ThuongHieuidThuongHieu",
                principalTable: "ThuongHieu",
                principalColumn: "idThuongHieu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_User_UseridUser",
                table: "SanPham",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banner_User_UseridUser",
                table: "Banner");

            migrationBuilder.DropForeignKey(
                name: "FK_ChinhSachGiaoHang_User_UseridUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DieuKhoanDichVu_User_UseridUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHang_SanPham_SanPhamidSP",
                table: "GioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_GioiThieu_User_UseridUser",
                table: "GioiThieu");

            migrationBuilder.DropForeignKey(
                name: "FK_MaGiamGia_User_UseridUser",
                table: "MaGiamGia");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyDinhChung_User_UseridUser",
                table: "QuyDinhChung");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_ThuongHieu_ThuongHieuidThuongHieu",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_User_UseridUser",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_ThuongHieuidThuongHieu",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_UseridUser",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_QuyDinhChung_UseridUser",
                table: "QuyDinhChung");

            migrationBuilder.DropIndex(
                name: "IX_MaGiamGia_UseridUser",
                table: "MaGiamGia");

            migrationBuilder.DropIndex(
                name: "IX_GioiThieu_UseridUser",
                table: "GioiThieu");

            migrationBuilder.DropIndex(
                name: "IX_GioHang_SanPhamidSP",
                table: "GioHang");

            migrationBuilder.DropIndex(
                name: "IX_DieuKhoanDichVu_UseridUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropIndex(
                name: "IX_ChinhSachGiaoHang_UseridUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropIndex(
                name: "IX_Banner_UseridUser",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "ThuongHieuidThuongHieu",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "QuyDinhChung");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "MaGiamGia");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "GioiThieu");

            migrationBuilder.DropColumn(
                name: "SanPhamidSP",
                table: "GioHang");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "DieuKhoanDichVu");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "ChinhSachGiaoHang");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "Banner");

            migrationBuilder.AddColumn<int>(
                name: "idThuongHieu",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "QuyDinhChung",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "MaGiamGia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "loaiMGG",
                table: "MaGiamGia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "GioiThieu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "hinhSP",
                table: "GioHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phanLoai",
                table: "GioHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tenSP",
                table: "GioHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "DieuKhoanDichVu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "ChinhSachGiaoHang",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "Banner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idThuongHieu",
                table: "SanPham",
                column: "idThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idUser",
                table: "SanPham",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_QuyDinhChung_idUser",
                table: "QuyDinhChung",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaGiamGia_idUser",
                table: "MaGiamGia",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioiThieu_idUser",
                table: "GioiThieu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_idSP",
                table: "GioHang",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_DieuKhoanDichVu_idUser",
                table: "DieuKhoanDichVu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachGiaoHang_idUser",
                table: "ChinhSachGiaoHang",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Banner_idUser",
                table: "Banner",
                column: "idUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Banner_User_idUser",
                table: "Banner",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChinhSachGiaoHang_User_idUser",
                table: "ChinhSachGiaoHang",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DieuKhoanDichVu_User_idUser",
                table: "DieuKhoanDichVu",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GioHang_SanPham_idSP",
                table: "GioHang",
                column: "idSP",
                principalTable: "SanPham",
                principalColumn: "idSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GioiThieu_User_idUser",
                table: "GioiThieu",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaGiamGia_User_idUser",
                table: "MaGiamGia",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyDinhChung_User_idUser",
                table: "QuyDinhChung",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_ThuongHieu_idThuongHieu",
                table: "SanPham",
                column: "idThuongHieu",
                principalTable: "ThuongHieu",
                principalColumn: "idThuongHieu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_User_idUser",
                table: "SanPham",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
