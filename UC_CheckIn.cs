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
using System.Xml.Linq;

namespace QLKS_Winform
{
    public partial class UC_CheckIn : UserControl
    {
        public UC_CheckIn()
        {
            InitializeComponent();
        }
        string roomID;
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (!IsDuplicateID.isDuplicateID("KhachHang", "MaKH", txtID.Text.Trim()))
                {
                    checkIN();
                    MessageBox.Show("Check in thành công", "Thông báo");
                }else
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //check in
        void checkIN()
        {
            string MaDP = AutoID.nextID("DatPhong", "MaDP", "DP", 3);//tự tăng mã đặt phòng
            object maNVValue = string.IsNullOrEmpty(ConnectionString.MaNV)
                       ? (object)DBNull.Value
                       : ConnectionString.MaNV;
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", txtID.Text.Trim()),
                new SqlParameter("@HoTen", txtClientName.Text.Trim()),
                new SqlParameter("@GioiTinh", cbbGender.Text.Trim()),
                new SqlParameter("@CCCD", txtNatiID.Text.Trim()),
                new SqlParameter("@SDT", txtPhoneNo.Text.Trim()),
                new SqlParameter("@DiaChi", txtAddress.Text.Trim()),
                new SqlParameter("@MaDP", MaDP),
                new SqlParameter("@MaPhong", roomID),//truyền mã mã phòng
                new SqlParameter("@NgayDat", dtCin.Value.ToString()),
                new SqlParameter("@MaNV", maNVValue),
                new SqlParameter("@GhiChu", txtNote.Text.Trim()),
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

        //Lấy Giá tiềm và mã phòng
        string getPriceRoomID()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text.Trim()),
                new SqlParameter("@TenPhong", cbbRoomName.Text.Trim()),
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
                new SqlParameter("@LoaiPhong", cbbRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text.Trim()),
                new SqlParameter("@TenPhong", cbbRoomName.Text.Trim())
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.CheckRoom, parameters);
            if (cbbRoomType.Text == "")//nếu text của cbbRoomType rỗng thì thực hiện lọc dữ liệu để tìm loại phòng còn trống 
            {
                cbbRoomType.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["LoaiPhong"].ToString();
                    if (!cbbRoomType.Items.Contains(value))
                        cbbRoomType.Items.Add(value);
                }
            }
            if (cbbNumOfBeds.Text == "")//nếu text của cbbNumOfBeds rỗng thì thực hiện lọc dữ liệu để tìm số giường còn trống 
            {
                cbbNumOfBeds.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["SoGiuong"].ToString();
                    if (!cbbNumOfBeds.Items.Contains(value))
                        cbbNumOfBeds.Items.Add(value);
                }
            }
            if(cbbRoomName.Text == "")//nếu text của cbbRoomName rỗng thì thực hiện lọc dữ liệu để tìm loại tên phòng còn trống còn trống 
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

        private void UC_CheckIn_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)//load lại data khi visible = true trên Index
            {
                loadData();
            }
        }
    }
}
