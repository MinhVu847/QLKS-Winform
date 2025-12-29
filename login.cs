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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {          
            if (checklogin())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();           
            }
            else
            {
                MessageBox.Show("User hoặc Pass không chính xác! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }    
        }
        bool checklogin()
        {
            if (txtUser.Text == "Admin" && txtPass.Text == "999") //tk mk admin được lưu trong code
                return true;

            SqlParameter[] parameter =
            {
                new SqlParameter("@manv", txtUser.Text),
                new SqlParameter("@matkhau", txtPass.Text)
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.LoginCheckQr, parameter);
            if (dt.Rows.Count > 0) 
            {              
                ConnectionString.MaNV = txtUser.Text.Trim();
                ConnectionString.ChucVu = dt.Rows[0]["ChucVu"].ToString();               
                return true;
            }         
            return false;
        }
        
        private void btnEyePass_Click(object sender, EventArgs e)
        {           
            if(txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                btnEyePass.Image = Properties.Resources.eye;
                txtPass.Focus();
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                btnEyePass.Image = Properties.Resources.eyeclose;
                txtPass.Focus();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
