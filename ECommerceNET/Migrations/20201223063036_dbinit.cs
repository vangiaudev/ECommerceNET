using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangKyNhanThongBao",
                columns: table => new
                {
                    idDKNTB = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eMail = table.Column<string>(maxLength: 200, nullable: false),
                    ngayDK = table.Column<DateTime>(nullable: false),
                    trangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKyNhanThongBao", x => x.idDKNTB);
                });

            migrationBuilder.CreateTable(
                name: "LienHe",
                columns: table => new
                {
                    idLH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoTen = table.Column<string>(maxLength: 50, nullable: false),
                    eMail = table.Column<string>(maxLength: 200, nullable: false),
                    tieuDe = table.Column<string>(nullable: false),
                    noiDung = table.Column<string>(nullable: false),
                    ngayGui = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    trangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHe", x => x.idLH);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    idUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoUser = table.Column<string>(maxLength: 10, nullable: false),
                    tenUser = table.Column<string>(maxLength: 50, nullable: false),
                    sdtUser = table.Column<string>(maxLength: 10, nullable: false),
                    emailUser = table.Column<string>(maxLength: 200, nullable: false),
                    matKhau = table.Column<string>(nullable: false),
                    gioiTinh = table.Column<int>(nullable: false),
                    ngaySinh = table.Column<DateTime>(nullable: false),
                    diaChi = table.Column<string>(nullable: true),
                    hinhAVT = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    hoatDongLanCuoi = table.Column<DateTime>(nullable: false),
                    trangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "BanDo",
                columns: table => new
                {
                    idBanDo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenBanDo = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    moTa = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanDo", x => x.idBanDo);
                    table.ForeignKey(
                        name: "FK_BanDo_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    idBanner = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hinhAnh = table.Column<string>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayBatDau = table.Column<DateTime>(nullable: false),
                    ngayKetThuc = table.Column<DateTime>(nullable: false),
                    url = table.Column<string>(maxLength: 5000, nullable: true),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.idBanner);
                    table.ForeignKey(
                        name: "FK_Banner_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChinhSachGiaoHang",
                columns: table => new
                {
                    idChinhSachGiaoHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChinhSachGiaoHang", x => x.idChinhSachGiaoHang);
                    table.ForeignKey(
                        name: "FK_ChinhSachGiaoHang_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChinhSachQuyenRiengTu",
                columns: table => new
                {
                    idChinhSachQRT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
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
                    idChinhSachTraHangVaHoanTien = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
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
                name: "DieuKhoanDichVu",
                columns: table => new
                {
                    idDieuKhoanDV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieuKhoanDichVu", x => x.idDieuKhoanDV);
                    table.ForeignKey(
                        name: "FK_DieuKhoanDichVu_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioiThieu",
                columns: table => new
                {
                    idGioiThieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<int>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioiThieu", x => x.idGioiThieu);
                    table.ForeignKey(
                        name: "FK_GioiThieu_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    idHinhAnh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHinhAnh = table.Column<string>(nullable: true),
                    kichThuoc = table.Column<double>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.idHinhAnh);
                    table.ForeignKey(
                        name: "FK_HinhAnh_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPuser",
                columns: table => new
                {
                    idIPuser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(nullable: false),
                    diachiip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPuser", x => x.idIPuser);
                    table.ForeignKey(
                        name: "FK_IPuser_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    idLoaiSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiSP = table.Column<string>(maxLength: 50, nullable: false),
                    hinhAnh = table.Column<string>(nullable: false),
                    metaTitle = table.Column<string>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.idLoaiSP);
                    table.ForeignKey(
                        name: "FK_LoaiSP_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaGiamGia",
                columns: table => new
                {
                    codeMGG = table.Column<string>(nullable: false),
                    tenMGG = table.Column<string>(nullable: true),
                    giaTri = table.Column<int>(nullable: false),
                    loaiMGG = table.Column<int>(nullable: false),
                    soLuong = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaGiamGia", x => x.codeMGG);
                    table.ForeignKey(
                        name: "FK_MaGiamGia_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaXacNhan",
                columns: table => new
                {
                    idMaXacNhan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(nullable: false),
                    code = table.Column<int>(nullable: false),
                    ngayGui = table.Column<DateTime>(nullable: false),
                    ngayXacNhan = table.Column<DateTime>(nullable: false),
                    loai = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaXacNhan", x => x.idMaXacNhan);
                    table.ForeignKey(
                        name: "FK_MaXacNhan_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    idNV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(nullable: false),
                    loaiNV = table.Column<int>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.idNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuanTri",
                columns: table => new
                {
                    idQT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanTri", x => x.idQT);
                    table.ForeignKey(
                        name: "FK_QuanTri_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuyDinhChung",
                columns: table => new
                {
                    idQuyDinhChung = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(nullable: true),
                    noiDung = table.Column<string>(nullable: true),
                    hinhAnh = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDinhChung", x => x.idQuyDinhChung);
                    table.ForeignKey(
                        name: "FK_QuyDinhChung_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    idThuongHieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenThuongHieu = table.Column<string>(maxLength: 100, nullable: false),
                    hinhLogo = table.Column<string>(nullable: false),
                    sdtThuongHieu = table.Column<string>(nullable: true),
                    emailThuongHieu = table.Column<string>(maxLength: 200, nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.idThuongHieu);
                    table.ForeignKey(
                        name: "FK_ThuongHieu_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    idDH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayDat = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    hoDH = table.Column<string>(maxLength: 10, nullable: false),
                    tenDH = table.Column<string>(maxLength: 50, nullable: false),
                    diaChi = table.Column<string>(maxLength: 200, nullable: false),
                    eMail = table.Column<string>(maxLength: 200, nullable: false),
                    sdtDH = table.Column<string>(maxLength: 10, nullable: false),
                    ipMayKhach = table.Column<string>(nullable: true),
                    ghiChu = table.Column<string>(nullable: true),
                    tongTienHang = table.Column<int>(nullable: false),
                    maGiamGiaDH = table.Column<string>(nullable: true),
                    maGiamGiaShip = table.Column<string>(nullable: true),
                    phiShip = table.Column<int>(nullable: false),
                    tongSoTien = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    idUser = table.Column<string>(nullable: true),
                    idNVCSKH = table.Column<string>(nullable: true),
                    idNVShip = table.Column<string>(nullable: true),
                    UseridUser = table.Column<int>(nullable: true),
                    MaGiamGiacodeMGG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.idDH);
                    table.ForeignKey(
                        name: "FK_DonHang_MaGiamGia_MaGiamGiacodeMGG",
                        column: x => x.MaGiamGiacodeMGG,
                        principalTable: "MaGiamGia",
                        principalColumn: "codeMGG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHang_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    idSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenSP = table.Column<string>(maxLength: 100, nullable: false),
                    giaSP = table.Column<int>(nullable: false),
                    giamGiaSP = table.Column<int>(nullable: false),
                    hinhAnh = table.Column<string>(nullable: false),
                    metaTitle = table.Column<string>(nullable: false),
                    luotXem = table.Column<int>(nullable: false),
                    soLuongKho = table.Column<int>(nullable: false),
                    moTa = table.Column<string>(nullable: false),
                    idLoaiSP = table.Column<int>(nullable: false),
                    idThuongHieu = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.idSP);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_idLoaiSP",
                        column: x => x.idLoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "idLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_ThuongHieu_idThuongHieu",
                        column: x => x.idThuongHieu,
                        principalTable: "ThuongHieu",
                        principalColumn: "idThuongHieu");
                    table.ForeignKey(
                        name: "FK_SanPham_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    idCTDH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDH = table.Column<int>(nullable: false),
                    tenSP = table.Column<string>(nullable: true),
                    thuocTinhSP = table.Column<string>(nullable: true),
                    hinhSP = table.Column<string>(nullable: true),
                    donGia = table.Column<int>(nullable: false),
                    giamGia = table.Column<int>(nullable: false),
                    soLuong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.idCTDH);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang_idDH",
                        column: x => x.idDH,
                        principalTable: "DonHang",
                        principalColumn: "idDH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnhSP",
                columns: table => new
                {
                    idAnhSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idHinhAnh = table.Column<int>(nullable: false),
                    idSP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSP", x => x.idAnhSP);
                    table.ForeignKey(
                        name: "FK_AnhSP_HinhAnh_idHinhAnh",
                        column: x => x.idHinhAnh,
                        principalTable: "HinhAnh",
                        principalColumn: "idHinhAnh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnhSP_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP");
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaSP",
                columns: table => new
                {
                    idDGSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noiDung = table.Column<string>(maxLength: 500, nullable: false),
                    ngayDG = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    diemSo = table.Column<int>(nullable: false),
                    idSP = table.Column<int>(nullable: false),
                    idUser = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaSP", x => x.idDGSP);
                    table.ForeignKey(
                        name: "FK_DanhGiaSP_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGiaSP_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    idGioHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(nullable: false),
                    hinhSP = table.Column<string>(nullable: true),
                    tenSP = table.Column<string>(nullable: true),
                    soLuong = table.Column<int>(nullable: false),
                    phanLoai = table.Column<string>(nullable: true),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.idGioHang);
                    table.ForeignKey(
                        name: "FK_GioHang_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "LuotMua",
                columns: table => new
                {
                    idLuotMua = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuotMua", x => x.idLuotMua);
                    table.ForeignKey(
                        name: "FK_LuotMua_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuotMua_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "LuotThich",
                columns: table => new
                {
                    idLuotThich = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuotThich", x => x.idLuotThich);
                    table.ForeignKey(
                        name: "FK_LuotThich_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LuotThich_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "ThuocTinhSP",
                columns: table => new
                {
                    idTTSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTTSP = table.Column<string>(nullable: false),
                    idSP = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuocTinhSP", x => x.idTTSP);
                    table.ForeignKey(
                        name: "FK_ThuocTinhSP_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuocTinhSP_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateTable(
                name: "TraHang",
                columns: table => new
                {
                    idTraHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDH = table.Column<int>(nullable: false),
                    idSP = table.Column<int>(nullable: false),
                    lyDoTraHang = table.Column<string>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayYeuCauTraHang = table.Column<DateTime>(nullable: false),
                    ngayHoanTien = table.Column<DateTime>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ChiTietTTSP",
                columns: table => new
                {
                    idCTTTSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenCTTTSP = table.Column<string>(nullable: true),
                    idTTSP = table.Column<int>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTTSP", x => x.idCTTTSP);
                    table.ForeignKey(
                        name: "FK_ChiTietTTSP_ThuocTinhSP_idTTSP",
                        column: x => x.idTTSP,
                        principalTable: "ThuocTinhSP",
                        principalColumn: "idTTSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietTTSP_User_idUser",
                        column: x => x.idUser,
                        principalTable: "User",
                        principalColumn: "idUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSP_idHinhAnh",
                table: "AnhSP",
                column: "idHinhAnh");

            migrationBuilder.CreateIndex(
                name: "IX_AnhSP_idSP",
                table: "AnhSP",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_BanDo_idUser",
                table: "BanDo",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Banner_idUser",
                table: "Banner",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachGiaoHang_idUser",
                table: "ChinhSachGiaoHang",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachQuyenRiengTu_idUser",
                table: "ChinhSachQuyenRiengTu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChinhSachTraHangVaHoanTien_idUser",
                table: "ChinhSachTraHangVaHoanTien",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_idDH",
                table: "ChiTietDonHang",
                column: "idDH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTTSP_idTTSP",
                table: "ChiTietTTSP",
                column: "idTTSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTTSP_idUser",
                table: "ChiTietTTSP",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaSP_idSP",
                table: "DanhGiaSP",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaSP_idUser",
                table: "DanhGiaSP",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_DieuKhoanDichVu_idUser",
                table: "DieuKhoanDichVu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaGiamGiacodeMGG",
                table: "DonHang",
                column: "MaGiamGiacodeMGG");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_UseridUser",
                table: "DonHang",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_idSP",
                table: "GioHang",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_idUser",
                table: "GioHang",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_GioiThieu_idUser",
                table: "GioiThieu",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_HinhAnh_idUser",
                table: "HinhAnh",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_IPuser_idUser",
                table: "IPuser",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiSP_idUser",
                table: "LoaiSP",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_LuotMua_idSP",
                table: "LuotMua",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_LuotMua_idUser",
                table: "LuotMua",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_LuotThich_idSP",
                table: "LuotThich",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_LuotThich_idUser",
                table: "LuotThich",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaGiamGia_idUser",
                table: "MaGiamGia",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaXacNhan_idUser",
                table: "MaXacNhan",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_idUser",
                table: "NhanVien",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_QuanTri_idUser",
                table: "QuanTri",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_QuyDinhChung_idUser",
                table: "QuyDinhChung",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idLoaiSP",
                table: "SanPham",
                column: "idLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idThuongHieu",
                table: "SanPham",
                column: "idThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idUser",
                table: "SanPham",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ThuocTinhSP_idSP",
                table: "ThuocTinhSP",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_ThuocTinhSP_idUser",
                table: "ThuocTinhSP",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongHieu_idUser",
                table: "ThuongHieu",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnhSP");

            migrationBuilder.DropTable(
                name: "BanDo");

            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "ChinhSachGiaoHang");

            migrationBuilder.DropTable(
                name: "ChinhSachQuyenRiengTu");

            migrationBuilder.DropTable(
                name: "ChinhSachTraHangVaHoanTien");

            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "ChiTietTTSP");

            migrationBuilder.DropTable(
                name: "DangKyNhanThongBao");

            migrationBuilder.DropTable(
                name: "DanhGiaSP");

            migrationBuilder.DropTable(
                name: "DieuKhoanDichVu");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "GioiThieu");

            migrationBuilder.DropTable(
                name: "IPuser");

            migrationBuilder.DropTable(
                name: "LienHe");

            migrationBuilder.DropTable(
                name: "LuotMua");

            migrationBuilder.DropTable(
                name: "LuotThich");

            migrationBuilder.DropTable(
                name: "MaXacNhan");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "QuanTri");

            migrationBuilder.DropTable(
                name: "QuyDinhChung");

            migrationBuilder.DropTable(
                name: "TraHang");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "ThuocTinhSP");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "MaGiamGia");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
