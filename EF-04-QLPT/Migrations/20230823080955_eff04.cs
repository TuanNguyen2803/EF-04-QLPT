using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_04_QLPT.Migrations
{
    /// <inheritdoc />
    public partial class eff04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiNguyenLieus",
                columns: table => new
                {
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNguyenLieus", x => x.LoainguyenlieuID);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThus",
                columns: table => new
                {
                    PhieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nhanvienlap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thanhtien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThus", x => x.PhieuthuID);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieus",
                columns: table => new
                {
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    Tennguyenlieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giaban = table.Column<double>(type: "float", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluongkho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieus", x => x.NguyenlieuID);
                    table.ForeignKey(
                        name: "FK_NguyenLieus_LoaiNguyenLieus_LoainguyenlieuID",
                        column: x => x.LoainguyenlieuID,
                        principalTable: "LoaiNguyenLieus",
                        principalColumn: "LoainguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuThus",
                columns: table => new
                {
                    ChitietphieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    PhieuthuID = table.Column<int>(type: "int", nullable: false),
                    Soluongban = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuThus", x => x.ChitietphieuthuID);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuThus_NguyenLieus_NguyenlieuID",
                        column: x => x.NguyenlieuID,
                        principalTable: "NguyenLieus",
                        principalColumn: "NguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuThus_PhieuThus_PhieuthuID",
                        column: x => x.PhieuthuID,
                        principalTable: "PhieuThus",
                        principalColumn: "PhieuthuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuThus_NguyenlieuID",
                table: "ChiTietPhieuThus",
                column: "NguyenlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuThus_PhieuthuID",
                table: "ChiTietPhieuThus",
                column: "PhieuthuID");

            migrationBuilder.CreateIndex(
                name: "IX_NguyenLieus_LoainguyenlieuID",
                table: "NguyenLieus",
                column: "LoainguyenlieuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuThus");

            migrationBuilder.DropTable(
                name: "NguyenLieus");

            migrationBuilder.DropTable(
                name: "PhieuThus");

            migrationBuilder.DropTable(
                name: "LoaiNguyenLieus");
        }
    }
}
