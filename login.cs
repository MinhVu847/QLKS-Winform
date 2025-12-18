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
                Index id = new Index();
                this.Hide();
                id.ShowDialog();
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
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand(Query.LoginCheckQr, con);
                cmd.Parameters.AddWithValue("@manv", txtUser.Text);
                cmd.Parameters.AddWithValue("@matkhau", txtPass.Text);
                if (cmd.ExecuteScalar() != null)
                {
                    return true;
                }
            }
            return false;
        }       
    }
}
