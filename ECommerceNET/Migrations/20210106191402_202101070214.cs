using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101070214 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanDo");

            migrationBuilder.DropTable(
                name: "LuotThich");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BanDo",
                columns: table => new
                {
                    idBanDo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenBanDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "LuotThich",
                columns: table => new
                {
                    idLuotThich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSP = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanDo_idUser",
                table: "BanDo",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_LuotThich_idSP",
                table: "LuotThich",
                column: "idSP");

            migrationBuilder.CreateIndex(
                name: "IX_LuotThich_idUser",
                table: "LuotThich",
                column: "idUser");
        }
    }
}
