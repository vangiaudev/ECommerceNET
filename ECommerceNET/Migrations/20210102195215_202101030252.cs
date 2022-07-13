using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceNET.Migrations
{
    public partial class _202101030252 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnhSP_HinhAnh_idHinhAnh",
                table: "AnhSP");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropIndex(
                name: "IX_AnhSP_idHinhAnh",
                table: "AnhSP");

            migrationBuilder.DropColumn(
                name: "idHinhAnh",
                table: "AnhSP");

            migrationBuilder.AddColumn<int>(
                name: "linkAnh",
                table: "AnhSP",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "linkAnh",
                table: "AnhSP");

            migrationBuilder.AddColumn<int>(
                name: "idHinhAnh",
                table: "AnhSP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    idHinhAnh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    kichThuoc = table.Column<double>(type: "float", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AnhSP_idHinhAnh",
                table: "AnhSP",
                column: "idHinhAnh");

            migrationBuilder.CreateIndex(
                name: "IX_HinhAnh_idUser",
                table: "HinhAnh",
                column: "idUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AnhSP_HinhAnh_idHinhAnh",
                table: "AnhSP",
                column: "idHinhAnh",
                principalTable: "HinhAnh",
                principalColumn: "idHinhAnh",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
