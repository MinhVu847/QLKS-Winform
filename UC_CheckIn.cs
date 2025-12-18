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
    public partial class UC_CheckIn : UserControl
    {
        public UC_CheckIn()
        {
            InitializeComponent();
            loadData();
        }
        string roomID;
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (!IsCustomerIdExists(txtID.Text))
                {
                    checkIN();
                    MessageBox.Show("Check in thành công", "Thông báo");
                }else
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //ktra xem nhập đủ thông tin chưa
        bool ValidateInput()
        {
            foreach (Control control in this.Controls) 
            {
                if(!(control is Label) && control.Name != txtNote.Name)
                {
                    if(control.Text.Trim() == "" )
                        return false;
                }
            }
            return true;
        }

        //Ktra mã khách hàng đã tồn tại chưa
        bool IsCustomerIdExists(string ID)
        {
            string query = "Select * from khachHang where MaKH = @MaKH";
            SqlParameter pa = new SqlParameter("@MaKH", ID);
            DataTable dt = DataProvider.ExcuteQuery(query, pa);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //check in
        void checkIN()
        {
            string MaDP = AutoID.nextID("DatPhong", "MaDP", "DP", 3);//tự tăng mã đặt phòng
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", txtID.Text),
                new SqlParameter("@HoTen", txtClientName.Text),
                new SqlParameter("@GioiTinh", cbbGender.Text),
                new SqlParameter("@CCCD", txtNatiID.Text),
                new SqlParameter("@SDT", txtPhoneNo.Text),
                new SqlParameter("@DiaChi", txtAddress.Text),
                new SqlParameter("@MaDP", MaDP),
                new SqlParameter("@MaPhong", roomID),//truyền mã mã phòng
                new SqlParameter("@NgayDat", dtCin.Value.ToString()),
                new SqlParameter("@MaNV", DBNull.Value),
                new SqlParameter("@GhiChu", txtNote.Text),
            };
            DataProvider.ExcuteNonQuery(Query.CheckIn, parameters);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.Clear();
                }
                else if (control is ComboBox cb)
                    cb.SelectedIndex = -1;
            }
            loadData();
        }
        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNumOfBeds.SelectedIndex = -1;
            cbbRoomName.SelectedIndex = -1;
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }

        string getPriceRoomID()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text),
                new SqlParameter("@TenPhong", cbbRoomName.Text),
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.ShowPrice, parameters);
            if (dt.Rows.Count > 0)
            {
                roomID = dt.Rows[0]["MaPhong"].ToString();// lấy mã phòng
                return dt.Rows[0]["GiaPhong"].ToString();// lấy giá phòng 
            }
            return "";
        }
        void loadData()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text),
                new SqlParameter("@TenPhong", cbbRoomName.Text)
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.CheckRoom, parameters);
            if (cbbRoomType.Text == "")
            {
                cbbRoomType.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["LoaiPhong"].ToString();
                    if (!cbbRoomType.Items.Contains(value))
                        cbbRoomType.Items.Add(value);
                }
            }
            if (cbbNumOfBeds.Text == "")
            {
                cbbNumOfBeds.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["SoGiuong"].ToString();
                    if (!cbbNumOfBeds.Items.Contains(value))
                        cbbNumOfBeds.Items.Add(value);
                }
            }
            if(cbbRoomName.Text == "")
            {
                cbbRoomName.Items.Clear();
                foreach (DataRow row in dt.Rows)
                    cbbRoomName.Items.Add(row["TenPhong"].ToString());
            }
        }
        private void cbbNumOfBeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }

        private void cbbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }

        private void txtNatiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(tb, "Chỉ được phép nhập số");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(tb, "");
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Nếu là Control cuối cùng (nút bấm), thì thực hiện Click
                if (sender == txtNote) // Giả sử txtNote là ô cuối
                {
                    btnCheckIn.PerformClick();
                }
                else
                {
                    // Nếu chưa phải ô cuối, nhấn Enter sẽ có tác dụng như nhấn Tab
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
