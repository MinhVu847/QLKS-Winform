using QLKS_Winform.QuerySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_Winform
{
    public partial class UC_RoomManagement : UserControl
    {
        public UC_RoomManagement()
        {
            InitializeComponent();
        }
        void loadData()
        {
            int giaPhong = 0;
            if (cbbPrice.SelectedIndex >= 0)
                giaPhong = Convert.ToInt32(cbbPrice.Text.Trim());
            SqlParameter[] param =
            {
                new SqlParameter("@MaPhong", txtSeachRoomID.Text.Trim()),
                new SqlParameter("@TenPhong", txtSeachRoomName.Text.Trim()),
                new SqlParameter("@LoaiPhong", cbbSeachRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbSeachNumOfBeds.Text.Trim()),
                new SqlParameter("@GiaPhong", giaPhong),
                new SqlParameter("@TrangThai", cbbPrice.Text.Trim())
            };
            dgvRoom.DataSource = DataProvider.ExcuteQuery(Query.getInfoRoom, param);
        }

        //thêm phòng
        void clearData()
        {
            foreach (Control control in grbRoomManage.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
            }
        }
        void addRoom()
        {
            int giaPhong = Convert.ToInt32(txtPirce.Text);// ép sang int để thêm vào sql
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", txtRoomID.Text.Trim()),
                new SqlParameter("@TenPhong", txtRoomName.Text.Trim()),
                new SqlParameter("@LoaiPhong", cbbRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbNumberOfBeds.Text.Trim()),
                new SqlParameter("@TrangThai", "Trống"),
                new SqlParameter("@GiaPhong", giaPhong),
            };
            DataProvider.ExcuteNonQuery(Query.AddRoom, parameters);
            clearData();
            loadData();
        }
        
        //ktra xem nhập đủ thông tin chưa
        bool ValidateInput()
        {
            foreach(Control control in grbRoomManage.Controls)
            {
                if(!(control is Label))
                {
                    if(control.Text.Trim() == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (IsDuplicateID.isDuplicateID("Phong", "MaPhong", txtRoomID.Text.Trim()))
                {
                    DialogResult ds = MessageBox.Show("Xác nhận thêm phòng mới này vào danh sách", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ds == DialogResult.Yes)
                    {

                        try
                        {
                            addRoom();
                            MessageBox.Show("Thêm phòng thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.ToString());
                        }
                    }
                }
                else
                    MessageBox.Show("Mã phòng đã tồn tại!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }

        void Edit()
        {
            int giaPhong = Convert.ToInt32(cbbPrice.Text);// ép sang int để thêm vào sql
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", txtSeachRoomID.Text.Trim()),
                new SqlParameter("@TenPhong", txtSeachRoomName.Text.Trim()),
                new SqlParameter("@LoaiPhong", cbbSeachRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbSeachNumOfBeds.Text.Trim()),
                new SqlParameter("@GiaPhong", giaPhong),
                new SqlParameter("@TrangThai", cbbStatus.Text.Trim())
            };
            DataProvider.ExcuteNonQuery(Query.EditRoom, parameters);
            clearData();
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPirce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtPirce, "Chỉ được phép nhập số");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtPirce, "");
        }

        private void UC_RoomManagement_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomID.Text = e.RowIndex.ToString();
        }
    }
}