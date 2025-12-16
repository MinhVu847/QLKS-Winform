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

        void loadData()
        {
            dgvEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpl.DataSource = getData().Tables[0];
        }

        //lấy dữ liệu đổ vào dataset

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
            using(SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Query.AddEmpl, con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtEmplName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtDOBEmpl.Value.Date);
                    cmd.Parameters.AddWithValue("@SDT", txtPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", cbbPosition.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPass.Text);
                    cmd.ExecuteNonQuery();
                }
                loadData();
            }
        }
        //Kiểm tra tồn tại
        bool checkEmpl()
        {
            string queryCheck = Query.ShowEmpl + "\n WHERE MaNV = @ID";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(queryCheck, con))
                {
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    return command.ExecuteScalar() != null;
                }
            }
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
                    if(dr == DialogResult.Yes)
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
            else if(cbbGender.Text.Trim() == "")
                return false;
            else if (txtPhoneNo.Text.Trim() == "")
                return false;
            return true;
        }
        //Sửa thông tin
        void EditEmpl()
        {
            using(SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Query.EditEmpl, con)) 
                {
                    cmd.Parameters.AddWithValue("@HoTen", txtEmplName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtDOBEmpl.Value.Date);
                    cmd.Parameters.AddWithValue("@SDT", txtPhoneNo.Text);
                    cmd.ExecuteNonQuery();
                }
                foreach (DataGridViewRow row in dgvEmpl.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txtID.Text)
                    {
                        row.Cells[1].Value = txtEmplName.Text;
                        row.Cells[2].Value = cbbGender.Text;
                        row.Cells[3].Value = dtDOBEmpl.Value.Date;
                        row.Cells[4].Value = txtPhoneNo.Text;
                        break;
                    }
                }
            }
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
            using(SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(Query.DelEmpl, con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            foreach (DataGridViewRow row in dgvEmpl.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtID.Text)
                {
                    row.Cells[1].Value = txtEmplName.Text;
                    row.Cells[2].Value = cbbGender.Text;
                    row.Cells[3].Value = dtDOBEmpl.Value.Date;
                    row.Cells[4].Value = txtPhoneNo.Text;
                    row.Cells[6].Value = "";
                    break;
                }
            }
        }

        //Tìm kiếm nhân viên
        DataSet getData()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(Query.SeachEmpl, con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", txtSeachID.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtSeachEmplName.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSeachPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", cbbSeachPosition.Text);
                    cmd.Parameters.AddWithValue("@EmployeeStatus", cbbSeachEmpl.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }

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
