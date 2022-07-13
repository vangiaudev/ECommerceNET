using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202012252315 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSP_idLoaiSP",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idLoaiSP",
                table: "SanPham");

            migrationBuilder.AddColumn<int>(
                name: "idLoaiSPcon",
                table: "SanPham",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idLoaiSPcon",
                table: "SanPham",
                column: "idLoaiSPcon");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSPcon_idLoaiSPcon",
                table: "SanPham",
                column: "idLoaiSPcon",
                principalTable: "LoaiSPcon",
                principalColumn: "idLoaiSPcon",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSPcon_idLoaiSPcon",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_idLoaiSPcon",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "idLoaiSPcon",
                table: "SanPham");

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
    }
}
