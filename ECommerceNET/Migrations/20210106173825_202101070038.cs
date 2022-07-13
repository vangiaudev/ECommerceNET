using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101070038 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChinhSachQuyenRiengTu");

            migrationBuilder.DropTable(
                name: "ChinhSachTraHangVaHoanTien");

            migrationBuilder.DropTable(
                name: "DangKyNhanThongBao");

            migrationBuilder.DropTable(
                name: "TraHang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChinhSachQuyenRiengTu",
                columns: table => new
                {
                    idChinhSachQRT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChinhSachQuyenRiengTu", x => x.idChinhSachQRT);
                    table.ForeignKey(
                        name: "FK_ChinhSachQuyenRiengTu_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChinhSachTraHangVaHoanTien",
                columns: table => new
                {
                    idChinhSachTraHangVaHoanTien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChinhSachTraHangVaHoanTien", x => x.idChinhSachTraHangVaHoanTien);
                    table.ForeignKey(
                        name: "FK_ChinhSachTraHangVaHoanTien_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DangKyNhanThongBao",
                columns: table => new
                {
                    idDKNTB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eMail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ngayDK = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKyNhanThongBao", x => x.idDKNTB);
                });

            migrationBuilder.CreateTable(
                name: "TraHang",
                columns: table => new
                {
                    idTraHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDH = table.Column<int>(type: "int", nullable: false),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    lyDoTraHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayHoanTien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayYeuCauTraHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraHang", x => x.idTraHang);
                    table.ForeignKey(
                        name: "FK_TraHang_DonHang_idDH",
                        column: x => x.idDH,
                        principalTable: "DonHang",
                        principalColumn: "idDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraHang_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachQuyenRiengTu_idUser",
                table: "ChinhSachQuyenRiengTu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachTraHangVaHoanTien_idUser",
                table: "ChinhSachTraHangVaHoanTien",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_TraHang_idDH",
                table: "TraHang",
                column: "idDH");

            migrationBuilder.CreateIndex(
                name: "IX_TraHang_idSP",
                table: "TraHang",
                column: "idSP");
        }
    }
}
