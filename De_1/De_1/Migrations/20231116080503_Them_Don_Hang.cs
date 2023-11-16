using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace De_1.Migrations
{
    /// <inheritdoc />
    public partial class Them_Don_Hang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiDat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDh);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaCthd = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.MaCthd);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_DonHang_MaDh",
                        column: x => x.MaDh,
                        principalTable: "DonHang",
                        principalColumn: "MaDh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HangHoa_MaHh",
                        column: x => x.MaHh,
                        principalTable: "HangHoa",
                        principalColumn: "MaHh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaDh",
                table: "ChiTietHoaDon",
                column: "MaDh");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaHh",
                table: "ChiTietHoaDon",
                column: "MaHh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "DonHang");
        }
    }
}
