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
    public partial class UC_CheckOut : UserControl
    {
        public UC_CheckOut()
        {
            InitializeComponent();
            cboCustomerStatus.SelectedIndex = 0;
            loadData();
        }
        string MaDP;
        string MaKH;
        string MaPhong;
        int TongTien;

        void loadData()
        {
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlParameter[] parameters = {
                new SqlParameter("@MaKH", txtCustomerID.Text),
                new SqlParameter("@MaPhong", txtRoomID.Text),
                new SqlParameter("@CustomerStatus", cboCustomerStatus.Text)
            };
            dgvCustomer.DataSource = DataProvider.ExcuteQuery(Query.GetCustomerInfoQuery, parameters);
        }

        private void cboCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtRoomID.Clear();
            cboCustomerStatus.SelectedIndex = 0;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = @"Select MaDP from DatPhong
                                where MaKH = @MaKH and MaPhong = @MaPhong";
            MaPhong = dgvCustomer.CurrentRow.Cells["MaPhong"].Value.ToString();
            MaKH = dgvCustomer.CurrentRow.Cells["MaKH"].Value.ToString();// lấy mã khách hàng
            try
            {
                int giaPhong = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["GiaPhong"].Value);
                double soNgay = (dtCheckOut.Value - Convert.ToDateTime(dgvCustomer.CurrentRow.Cells["NgayDat"].Value)).TotalDays;
                TongTien = (int)(soNgay * giaPhong);
            
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKH", MaKH),
                    new SqlParameter("@MaPhong", MaPhong)
                };
                DataTable dt = DataProvider.ExcuteQuery(query, parameters);
                MaDP = dt.Rows[0][0].ToString();
            }
            catch (Exception) { }
        }
        void CheckIn()
        {
            string MaHD = AutoID.nextID("HoaDon", "MaHD", "HD", 3);
            if(TongTien <= 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ!");
                return;
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@NgayTra", dtCheckOut.Value),
                new SqlParameter("@MaDP", MaDP),
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TongTien", TongTien)
            };
            DataProvider.ExcuteNonQuery(Query.GetCustomerForCheckoutQuery, parameters);
            loadData();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDP) || string.IsNullOrEmpty(MaKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cụ thể từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"select count(MaDP) from DatPhong
                            where MaDP = @MaDP AND NgayTra <> NULL";
            SqlParameter parameters = new SqlParameter("@MaDP", MaDP);
            int count = (int)DataProvider.ExcuteScalar(query, parameters);
            if (count > 0)
            {
                MessageBox.Show("Lượt đặt phòng này đã được thanh toán trước đó!", "Thông báo");
                return;
            }
            DialogResult dr = MessageBox.Show($"Tổng tiền: {TongTien:N0} VNĐ. Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                CheckIn();
                MessageBox.Show("Trả phòng thành công!", "Thông báo");
                MaDP = ""; MaKH = ""; MaPhong = ""; TongTien = 0;
            }
        }
    }
}
