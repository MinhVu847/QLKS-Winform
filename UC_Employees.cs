using QLKS_Winform.QuerySQL;
using System;
using System.Collections;
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
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
        }

        //load dữ liệu nhân viên
        void loadData()
        {
            dgvEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", txtSeachID.Text.Trim()),
                new SqlParameter("@HoTen", txtSeachEmplName.Text.Trim()),
                new SqlParameter("@SDT", txtSeachPhoneNo.Text.Trim()),
                new SqlParameter("@ChucVu", cbbSeachPosition.Text.Trim()),
                new SqlParameter("@EmployeeStatus", cbbSeachEmpl.Text.Trim())
            };
            dgvEmpl.DataSource = DataProvider.ExcuteQuery(Query.SeachEmpl, param);

            dgvEmpl.Columns["MaNV"].HeaderText = "ID";
            dgvEmpl.Columns["HoTen"].HeaderText = "Name";
            dgvEmpl.Columns["GioiTinh"].HeaderText = "Gender";
            dgvEmpl.Columns["NgaySinh"].HeaderText = "Date Of Birth";
            dgvEmpl.Columns["SDT"].HeaderText = "Phone No";
            dgvEmpl.Columns["ChucVu"].HeaderText = "Position";
            dgvEmpl.Columns["MatKhau"].HeaderText = "Password";
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!IsDuplicateID.isDuplicateID("NhanVien", "MaNV", txtID.Text.Trim()))
            {
                if (checkInfo())
                {
                    AddEmpl();
                    txtID.Clear();
                    txtEmplName.Clear();
                    txtPhoneNo.Clear();
                    txtPass.Text = "123456";
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Thêm nhân viên
        void AddEmpl()
        {
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@MaNV", txtID.Text.Trim()),
                    new SqlParameter("@HoTen", txtEmplName.Text.Trim()),
                    new SqlParameter("@GioiTinh", cbbGender.Text.Trim()),
                    new SqlParameter("@NgaySinh", dtDOBEmpl.Value.Date),
                    new SqlParameter("@SDT", txtPhoneNo.Text.Trim()),
                    new SqlParameter("@ChucVu", cbbPosition.Text.Trim()),
                    new SqlParameter("@MatKhau", txtPass.Text.Trim())
                };
                DataProvider.ExcuteNonQuery(Query.AddEmpl, param);
                loadData();
            }catch(Exception ex) 
            { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvEmpl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvEmpl.CurrentRow.Cells[0].Value.ToString();
            txtEmplName.Text = dgvEmpl.CurrentRow.Cells[1].Value.ToString();
            cbbGender.Text = dgvEmpl.CurrentRow.Cells[2].Value.ToString();
            dtDOBEmpl.Text = dgvEmpl.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNo.Text = dgvEmpl.CurrentRow.Cells[4].Value.ToString();
            cbbPosition.Text = dgvEmpl.CurrentRow.Cells[5].Value.ToString();
            txtPass.Text = dgvEmpl.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (IsDuplicateID.isDuplicateID("NhanVien", "MaNV", txtID.Text.Trim()))
            {
                if (checkInfo())
                {
                    string info = "ID: " + txtID.Text + "\n" + "Name: " + txtEmplName.Text +
                    "\n" + "Gender: " + cbbGender.Text + "\n" + "Date of birth: " + dtDOBEmpl.Text + "\n" + "Phone No: " + txtPhoneNo.Text;
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này?\n" + info, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                        EditEmpl();
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Kiểm tra xem nhập đủ thông tin chưa
        bool checkInfo()
        {
            if (txtEmplName.Text.Trim() == "")
                return false;
            else if (cbbGender.Text.Trim() == "")
                return false;
            else if (txtPhoneNo.Text.Trim() == "")
                return false;
            return true;
        }
        //Sửa thông tin
        void EditEmpl()
        {
            try
            {
                SqlParameter[] param =
                {
                new SqlParameter("@MaNV", txtID.Text.Trim()),
                new SqlParameter("@HoTen", txtEmplName.Text.Trim()),
                new SqlParameter("@GioiTinh", cbbGender.Text.Trim()),
                new SqlParameter("@NgaySinh", dtDOBEmpl.Value.Date),
                new SqlParameter("@SDT", txtPhoneNo.Text.Trim())
            };
                DataProvider.ExcuteNonQuery(Query.EditEmpl, param);
                loadData();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            if (IsDuplicateID.isDuplicateID("NhanVien", "MaNV", txtID.Text.Trim()))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DelEmpl();
                    txtID.Clear();
                    txtEmplName.Clear();
                    txtPhoneNo.Clear();
                    txtPass.Text = "123456";
                }
            }
            else
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Xóa nhân viên
        void DelEmpl()
        {
            try
            {
                SqlParameter param = new SqlParameter("@MaNV", txtID.Text.Trim());
                DataProvider.ExcuteNonQuery(Query.DelEmpl, param);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Tìm kiếm nhân viên
        private void txtSeachID_TextChanged(object sender, EventArgs e)
        {
            timeStop.Stop();
            timeStop.Start();
        }

        private void timeStop_Tick(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbbSeachPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSeachID.Clear();
            txtSeachEmplName.Clear();
            txtSeachPhoneNo.Clear();
            cbbSeachPosition.SelectedIndex = 0;
            cbbSeachEmpl.SelectedIndex = 0;
        }

        private void txtSeachID_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)//load lại data khi visible = true trên Index
            {
                cbbPosition.SelectedIndex = 0;
                cbbSeachEmpl.SelectedIndex = 0;
                loadData();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Nếu là Control cuối cùng (nút bấm), thì thực hiện Click
                if (sender == txtPass) // Giả sử txtPass là ô cuối
                {
                    btnAdd.PerformClick();
                }
                else
                {
                    // Nếu chưa phải ô cuối, nhấn Enter sẽ có tác dụng như nhấn Tab
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtPhoneNo, "Chỉ được phép nhập số");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtPhoneNo, "");
        }
    }
}
