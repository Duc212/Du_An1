using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aa_DAL.Migrations
{
    /// <inheritdoc />
    public partial class create_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HinhThucThanhToans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHinhThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucThanhToans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    SoDienThoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.SoDienThoai);
                });

            migrationBuilder.CreateTable(
                name: "Nhanviens",
                columns: table => new
                {
                    TaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaitro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanviens", x => x.TaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percent = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TienGiam = table.Column<long>(type: "bigint", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<long>(type: "bigint", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhams_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DienThoaiKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<long>(type: "bigint", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhachHangSoDienThoai = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangSoDienThoai",
                        column: x => x.KhachHangSoDienThoai,
                        principalTable: "KhachHangs",
                        principalColumn: "SoDienThoai");
                    table.ForeignKey(
                        name: "FK_HoaDons_Nhanviens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "Nhanviens",
                        principalColumn: "TaiKhoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HDCTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<long>(type: "bigint", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDCTs_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDCTs_SanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuThanhToans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HinhThucThanhToanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTien = table.Column<long>(type: "bigint", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuThanhToans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichSuThanhToans_HinhThucThanhToans_HinhThucThanhToanId",
                        column: x => x.HinhThucThanhToanId,
                        principalTable: "HinhThucThanhToans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuThanhToans_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HDCTs_HoaDonId",
                table: "HDCTs",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_HDCTs_SanPhamId",
                table: "HDCTs",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangSoDienThoai",
                table: "HoaDons",
                column: "KhachHangSoDienThoai");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_VoucherId",
                table: "HoaDons",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuThanhToans_HinhThucThanhToanId",
                table: "LichSuThanhToans",
                column: "HinhThucThanhToanId");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuThanhToans_HoaDonId",
                table: "LichSuThanhToans",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_SaleId",
                table: "SanPhams",
                column: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDCTs");

            migrationBuilder.DropTable(
                name: "LichSuThanhToans");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "HinhThucThanhToans");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Nhanviens");

            migrationBuilder.DropTable(
                name: "Vouchers");
        }
    }
}
