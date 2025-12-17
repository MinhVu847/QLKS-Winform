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
            cbbPosition.SelectedIndex = 0;
            cbbSeachEmpl.SelectedIndex = 0;
            loadData();
        }

        //load dữ liệu nhân viên
        void loadData()
        {
            dgvEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", txtSeachID.Text),
                new SqlParameter("@HoTen", txtSeachEmplName.Text),
                new SqlParameter("@SDT", txtSeachPhoneNo.Text),
                new SqlParameter("@ChucVu", cbbSeachPosition.Text),
                new SqlParameter("@EmployeeStatus", cbbSeachEmpl.Text)
            };
            dgvEmpl.DataSource = DataProvider.ExcuteQuery(Query.SeachEmpl, param);
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!checkEmpl())
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
            SqlParameter[] param = {
                    new SqlParameter("@MaNV", txtID.Text),
                    new SqlParameter("@HoTen", txtEmplName.Text),
                    new SqlParameter("@GioiTinh", cbbGender.Text),
                    new SqlParameter("@NgaySinh", dtDOBEmpl.Value.Date),
                    new SqlParameter("@SDT", txtPhoneNo.Text),
                    new SqlParameter("@ChucVu", cbbPosition.Text),
                    new SqlParameter("@MatKhau", txtPass.Text)
                };
            DataProvider.ExcuteNonQuery(Query.AddEmpl, param);
            loadData();
        }
        //Kiểm tra tồn tại
        bool checkEmpl()
        {
            string queryCheck = Query.ShowEmpl + "\n WHERE MaNV = @ID";
            SqlParameter[] param = 
            {
                    new SqlParameter("@ID", txtID.Text)
            };
            object data = DataProvider.ExcuteScalar(queryCheck, param);
            if (data != null)
                return true;
            else
                return false;
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
            if (checkEmpl())
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
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", txtID.Text),
                new SqlParameter("@HoTen", txtEmplName.Text),
                new SqlParameter("@GioiTinh", cbbGender.Text),
                new SqlParameter("@NgaySinh", dtDOBEmpl.Value.Date),
                new SqlParameter("@SDT", txtPhoneNo.Text)
            };
            DataProvider.ExcuteNonQuery(Query.EditEmpl, param);
            loadData();
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            if (checkEmpl())
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
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", txtID.Text)
            };
            DataProvider.ExcuteNonQuery(Query.DelEmpl, param);
            loadData();
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
    }
}
