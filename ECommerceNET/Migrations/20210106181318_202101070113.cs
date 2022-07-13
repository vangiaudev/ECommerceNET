using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101070113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSPcon_idLoaiSPcon",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiSPcon");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idLoaiSPcon",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "idLoaiSPcon",
                table: "SanPham");

            migrationBuilder.AddColumn<string>(
                name: "typeLoai",
                table: "LoaiSP",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idLoaiSP",
                table: "SanPham",
                column: "idLoaiSP");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSP_idLoaiSP",
                table: "SanPham",
                column: "idLoaiSP",
                principalTable: "LoaiSP",
                principalColumn: "idLoaiSP",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSP_idLoaiSP",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idLoaiSP",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "typeLoai",
                table: "LoaiSP");

            migrationBuilder.AddColumn<int>(
                name: "idLoaiSPcon",
                table: "SanPham",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoaiSPcon",
                columns: table => new
                {
                    idLoaiSPcon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idLoaiSP = table.Column<int>(type: "int", nullable: false),
                    metaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenLoaiSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPcon", x => x.idLoaiSPcon);
                    table.ForeignKey(
                        name: "FK_LoaiSPcon_LoaiSP_idLoaiSP",
                        column: x => x.idLoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "idLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idLoaiSPcon",
                table: "SanPham",
                column: "idLoaiSPcon");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiSPcon_idLoaiSP",
                table: "LoaiSPcon",
                column: "idLoaiSP");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSPcon_idLoaiSPcon",
                table: "SanPham",
                column: "idLoaiSPcon",
                principalTable: "LoaiSPcon",
                principalColumn: "idLoaiSPcon",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
