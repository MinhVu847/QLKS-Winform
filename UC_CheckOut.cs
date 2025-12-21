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
                                where MaKH = @MaKH and MaPhong = @MaPhong";//truy vấn để lấy Mã đặt phòng
            MaPhong = dgvCustomer.CurrentRow.Cells["MaPhong"].Value.ToString();
            MaKH = dgvCustomer.CurrentRow.Cells["MaKH"].Value.ToString();// lấy mã khách hàng
            try
            {
                int giaPhong = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["GiaPhong"].Value);

                // 2. Tính khoảng cách thời gian
                TimeSpan kcach = dtCheckOut.Value - Convert.ToDateTime(dgvCustomer.CurrentRow.Cells["NgayDat"].Value);

                // 3. Lấy tổng số ngày dưới dạng số thực
                double soNgayThucTe = kcach.TotalDays;

                //Làm tròn và ép sang kiểu nguyên
                int soNgayTinhTien = (int)Math.Ceiling(soNgayThucTe);

                // Đảm bảo tối thiểu là 1 ngày
                if (soNgayTinhTien <= 0)
                {
                    soNgayTinhTien = 1;
                }

                // 5. Tính tổng tiền
                TongTien = soNgayTinhTien * giaPhong;

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKH", MaKH),
                    new SqlParameter("@MaPhong", MaPhong)
                };
                DataTable dt = DataProvider.ExcuteQuery(query, parameters);
                MaDP = dt.Rows[0][0].ToString();//gán MaDp cho MaDP
            }
            catch (Exception) { }
        }
        void CheckIn()
        {
            string MaHD = AutoID.nextID("HoaDon", "MaHD", "HD", 3);//lấy mã hóa đơn lớn nhất rồi cộng thêm 1
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
                new SqlParameter("@MaNV", ConnectionString.MaNV),
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TongTien", TongTien)
            };
            DataProvider.ExcuteNonQuery(Query.GetCustomerForCheckoutQuery, parameters);
            loadData();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDP) || string.IsNullOrEmpty(MaKH))//ktra xem mã khách hàng được gán chưa
            {
                MessageBox.Show("Vui lòng chọn khách hàng cụ thể từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"SELECT COUNT(MaDP) FROM DatPhong
                            WHERE MaDP = @MaDP AND NgayTra IS NOT NULL";
            SqlParameter parameters = new SqlParameter("@MaDP", MaDP);
            int count = (int)DataProvider.ExcuteScalar(query, parameters);//ktra xem phòng đấy được trả chưa
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

        private void UC_CheckOut_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)//load lại data khi visible = true trên Index
            {
                cboCustomerStatus.SelectedIndex = 0;
                loadData();
            }
        }
    }
}
