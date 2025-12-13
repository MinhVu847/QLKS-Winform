using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_Winform.QuerySQL
{
    public static class Query
    {
        public static string LoginCheckQr = "select * from NhanVien where MaNV=@manv and MatKhau =@matkhau";

        //Hiển thị thông tin tất cả nhân viên
        public static string ShowEmpl = @"SELECT * FROM NhanVien";

        //Thêm nhân viên
        public static string AddEmpl = @"INSERT INTO NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, SDT, ChucVu, MatKhau)
                                        VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @SDT, @ChucVu, @MatKhau);";

        //Sửa thông tin nhân viên
        public static string EditEmpl = @"UPDATE NhanVien 
                                        SET 
                                        HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT 
                                        WHERE MaNV = @MaNV";

        //Xóa thông tin nhân viên
        public static string DelEmpl = @"UPDATE NhanVien 
                                        SET 
                                        MatKhau = ''
                                        WHERE MaNV = @MaNV";

        //tìm kiếm nhân viên
        public static string SeachEmpl = @"SELECT * FROM NhanVien 
                                           WHERE (@MaNV = '' OR MaNV LIKE '%' + @MaNV + '%')
                                              AND (@HoTen = '' OR HoTen LIKE '%' + @HoTen + '%')
                                              AND (@SDT = '' OR SDT LIKE '%' + @SDT + '%')
                                              AND (@ChucVu = '' OR ChucVu LIKE '%' + @ChucVu + '%')
                                              AND (@EmployeeStatus = 'All Employees'
                                                  OR (@EmployeeStatus = 'Active Employees' AND MatKhau IS NOT NULL AND MatKhau <> '')
                                                  OR (@EmployeeStatus = 'Terminated Employees' AND (MatKhau IS NULL OR MatKhau = ''))
                                                  );";
        //Thêm khách hàng
        public static string AddCustomer = @"INSERT INTO KhachHang(MaKH, HoTen, GioiTinh, CCCD, SDT, DiaChi)
                                            VALUES (@MaKH, @HoTen, @GioiTinh, @CCCD, @SDT, DiaChi);";

        //Tìm kiếm thông tin khách hàng
        public static string SeachClient = @"SELECT * FROM KhachHang
                                            WHERE (@MaKH = '' OR MaKH LIKE '%' + @MaKH + '%')
                                              AND (@HoTen = '' OR HoTen LIKE '%' + @HoTen + '%')
                                              AND (@DiaChi = '' OR DiaChi LIKE '%' + @DiaChi + '%')
                                              AND (@CCCD = '' OR CCCD LIKE '%' + @CCCD + '%')
                                              AND (@SDT = '' OR SDT LIKE '%' + @SDT + '%');";
    }
}
