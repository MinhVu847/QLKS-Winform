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

        //load dữ liệu
        void loadData()
        {
            try
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
                new SqlParameter("@TrangThai", cbbStatus.Text.Trim())
                };
                DataTable dt = DataProvider.ExcuteQuery(Query.getInfoRoom, param);
                dgvRoom.DataSource = dt;

                dgvRoom.Columns["MaPhong"].HeaderText = "Room ID";
                dgvRoom.Columns["TenPhong"].HeaderText = "Room Name";
                dgvRoom.Columns["LoaiPhong"].HeaderText = "Room Type";
                dgvRoom.Columns["SoGiuong"].HeaderText = "Number Of Beds";
                dgvRoom.Columns["TrangThai"].HeaderText = "status";
                dgvRoom.Columns["GiaPhong"].HeaderText = "Price";

                if (cbbPrice.SelectedIndex == -1)
                {
                    cbbPrice.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string value = row["GiaPhong"].ToString();
                        if (!cbbPrice.Items.Contains(value))
                            cbbPrice.Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        //xóa hết dữ liệu trên textBox và comboBox
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

        //Thêm phòng
        void addRoom()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
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
                if (!IsDuplicateID.isDuplicateID("Phong", "MaPhong", txtRoomID.Text.Trim()))
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

        //Sửa phòng
        void EditRoom()
        {
            try
            {
                int giaPhong = Convert.ToInt32(txtPirce.Text.Trim());// ép sang int để thêm vào sql
                SqlParameter[] parameters =
                {
                new SqlParameter("@MaPhong", txtRoomID.Text.Trim()),
                new SqlParameter("@TenPhong", txtRoomName.Text.Trim()),
                new SqlParameter("@LoaiPhong", cbbRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbNumberOfBeds.Text.Trim()),
                new SqlParameter("@GiaPhong", giaPhong),
                };
                DataProvider.ExcuteNonQuery(Query.EditRoom, parameters);
                clearData();
                loadData();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //ktra trạng thái phòng
        bool IsRoomAvailable()
        {
            try
            {
                string query = "SELECT TrangThai FROM Phong WHERE MaPhong = @maPhong AND (TrangThai = N'Trống' OR TrangThai = N'Đang sửa')";
                SqlParameter param = new SqlParameter("@maPhong", txtRoomID.Text.Trim());
                if (DataProvider.ExcuteScalar(query, param) != null)
                    return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string s = "Mã phòng: " + txtRoomID.Text + "\nTên Phòng: " + txtRoomName.Text + "\nLoại phòng: " + cbbRoomType.Text +
                        "\nSố giường: " + cbbNumberOfBeds.Text + "\nGiá phòng: " + txtPirce.Text;
            if (ValidateInput())
            {
                if (IsDuplicateID.isDuplicateID("Phong", "MaPhong", txtRoomID.Text.Trim()))
                {
                    if (IsRoomAvailable())
                    {
                        DialogResult ds = MessageBox.Show(s, "Xác nhận", MessageBoxButtons.OKCancel);
                        if (ds == DialogResult.OK)
                        {
                            EditRoom();
                            MessageBox.Show("Sửa phòng thành công.");
                        }
                    }
                    else
                        MessageBox.Show("Phòng đang được đặt không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Mã phòng không tồn tại!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
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

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomID.Text = dgvRoom.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtRoomName.Text = dgvRoom.CurrentRow.Cells["TenPhong"].Value.ToString();
            cbbRoomType.Text = dgvRoom.CurrentRow.Cells["LoaiPhong"].Value.ToString();
            cbbNumberOfBeds.Text = dgvRoom.CurrentRow.Cells["SoGiuong"].Value.ToString();
            txtPirce.Text = dgvRoom.CurrentRow.Cells["GiaPhong"].Value.ToString();
        }

        //Xóa phòng
        void Delete()
        {
            try
            {
                SqlParameter parameters = new SqlParameter("@MaPhong", txtRoomID.Text.Trim());
                DataProvider.ExcuteNonQuery(Query.DeleteRoom, parameters);
                clearData();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsDuplicateID.isDuplicateID("Phong", "MaPhong", txtRoomID.Text.Trim()))
            {
                if (IsRoomAvailable())
                {
                    DialogResult ds = MessageBox.Show("Có bạn có chắc muốn xóa phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ds == DialogResult.Yes)
                    {
                        Delete();
                        MessageBox.Show("Xóa phòng thành công!");
                    }
                }
                else
                    MessageBox.Show("Lỗi. Phòng đã bị xóa hoặc đang được đặt!");
            }
            else
                MessageBox.Show("Mã phòng không tồn tại!");
        }

        private void txtSeachRoomID_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbbSeachRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in grbRoomSeach.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
            }
        }

        private void UC_RoomManagement_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}