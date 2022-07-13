using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101061650 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnhSP");

            migrationBuilder.DropTable(
                name: "ChiTietTTSP");

            migrationBuilder.DropTable(
                name: "DanhGiaSP");

            migrationBuilder.DropTable(
                name: "LuotMua");

            migrationBuilder.DropTable(
                name: "ThuocTinhSP");

            migrationBuilder.AlterColumn<string>(
                name: "moTa",
                table: "SanPham",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "luotMua",
                table: "SanPham",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "luotMua",
                table: "SanPham");

            migrationBuilder.AlterColumn<string>(
                name: "moTa",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AnhSP",
                columns: table => new
                {
                    idAnhSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    linkAnh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSP", x => x.idAnhSP);
                    table.ForeignKey(
                        name: "FK_AnhSP_SanPham_idSP",
                        column: x => x.idSP,
                        principalTable: "SanPham",
                        principalColumn: "idSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaSP",
                columns: table => new
                {
                    idDGSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diemSo = table.Column<int>(type: "int", nullable: false),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayDG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noiDung = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuotMua",
                columns: table => new
                {
                    idLuotMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuocTinhSP",
                columns: table => new
                {
                    idTTSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenTTSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTTSP",
                columns: table => new
                {
                    idCTTTSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTTSP = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenCTTTSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSP_idSP",
                table: "AnhSP",
                column: "idSP");

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
                name: "IX_LuotMua_idSP",
                table: "LuotMua",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_LuotMua_idUser",
                table: "LuotMua",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ThuocTinhSP_idSP",
                table: "ThuocTinhSP",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_ThuocTinhSP_idUser",
                table: "ThuocTinhSP",
                column: "idUser");
        }
    }
}
