using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_Winform.QuerySQL
{
    public static class Query
    {
        public static string LoginCheckQr = "select * from NhanVien where MaNV=@manv and MatKhau =@matkhau";

        //Thêm nhân viên
        public static string AddEmpl = @"INSERT INTO NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, SDT, ChucVu, MatKhau)
                                        VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @SDT, @ChucVu, @MatKhau);";
        
        //tìm kiếm nhân viên theo mã
        public static string SeachEmpl = @"SELECT * FROM NhanVien 
                                           WHERE (@MaNV = '' OR MaNV LIKE '%' + @MaNV + '%')
                                              AND (@HoTen = '' OR HoTen LIKE '%' + @HoTen + '%')
                                              AND (@GioiTinh = '' OR GioiTinh LIKE '%' + @GioiTinh + '%')
                                              AND (@ChucVu = '' OR ChucVu LIKE '%' + @ChucVu + '%')
                                              AND (@SDT = '' OR SDT LIKE '%' + @SDT + '%');";

        //Tìm kiếm thông tin khách hàng
        public static string SeachClient = @"SELECT * FROM KhachHang
                                            WHERE (@MaKH = '' OR MaKH LIKE '%' + @MaKH + '%')
                                              AND (@HoTen = '' OR HoTen LIKE '%' + @HoTen + '%')
                                              AND (@DiaChi = '' OR DiaChi LIKE '%' + @DiaChi + '%')
                                              AND (@CCCD = '' OR CCCD LIKE '%' + @CCCD + '%')
                                              AND (@SDT = '' OR SDT LIKE '%' + @SDT + '%');";
    }
}
