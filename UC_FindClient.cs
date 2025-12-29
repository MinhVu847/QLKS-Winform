using QLKS_Winform.QuerySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_Winform
{
    public partial class UC_FindClient : UserControl
    {
        public UC_FindClient()
        {
            InitializeComponent();
        }
 
        // Hàm dùng chung để thực hiện tìm kiếm
        // cot: Tên cột trong DB (VD: k.MaKH, k.SDT)
        // giaTriTim: Giá trị người dùng nhập vào
        private void SearchData(string cot, string giaTriTim)
        {
            if(string.IsNullOrEmpty(giaTriTim))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //câu truye vấn kết hợp 3 bảng - dùng AS để đỡ phải sửa lại HeaderText
            string query = @"
                SELECT 
                    k.MaKH AS 'ID', 
                    k.HoTen AS 'Name', 
                    k.GioiTinh AS 'Gender', 
                    k.CCCD AS 'National ID', 
                    k.SDT AS 'Phone No', 
                    k.DiaChi AS 'Address',
                    p.LoaiPhong AS 'Room Type', 
                    p.SoGiuong AS 'Beds', 
                    p.TenPhong AS 'Room Name', 
                    p.GiaPhong AS 'Price',
                    d.NgayDat AS 'Check In Date'
                FROM KhachHang k
                JOIN DatPhong d ON k.MaKH = d.MaKH
                JOIN Phong p ON d.MaPhong = p.MaPhong
                WHERE " + cot + " LIKE @keyword";

            // Sử dụng DataProvider 
            // Thêm dấu % để tìm kiếm gần đúng(nhập 1/n ra full data)
            SqlParameter[] param =
            {
                new SqlParameter("@keyword","%"+ giaTriTim +"%")
            };

            DataTable dt = DataProvider.ExcuteQuery(query, param);

            if(dt.Rows.Count > 0)
                dgvResult.DataSource = dt;
            else
            {
                dgvResult.DataSource = null;
                MessageBox.Show("Không tìm thấy khách hàng nào!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

            } 

        }
        //tìm theo mã khách hàng
        private void btnFindID_Click(object sender, EventArgs e)
        {
            SearchData("k.MaKH", txtId.Text.Trim());
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            SearchData("k.HoTen", txtName.Text.Trim());
        }

        private void btnFindPhone_Click(object sender, EventArgs e)
        {
            SearchData("k.SDT", txtPhone.Text.Trim());
        }

        private void btnFindCCCD_Click(object sender, EventArgs e)
        {
            SearchData("k.CCCD", txtCCCD.Text.Trim());
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtCCCD.Clear();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
