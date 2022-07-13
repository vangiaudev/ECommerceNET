using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202012252300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "LoaiSP");

            migrationBuilder.CreateTable(
                name: "LoaiSPcon",
                columns: table => new
                {
                    idLoaiSPcon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiSP = table.Column<string>(maxLength: 50, nullable: false),
                    hinhAnh = table.Column<string>(nullable: false),
                    metaTitle = table.Column<string>(nullable: false),
                    trangThai = table.Column<string>(nullable: true),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayCapNhat = table.Column<DateTime>(nullable: false),
                    idLoaiSP = table.Column<int>(nullable: false)
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
                name: "IX_LoaiSPcon_idLoaiSP",
                table: "LoaiSPcon",
                column: "idLoaiSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoaiSPcon");

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "LoaiSP",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
