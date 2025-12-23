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
    public partial class UC_MyAccount : UserControl
    {
        public UC_MyAccount()
        {
            InitializeComponent();
        }

        private void UC_MyAccount_Load(object sender, EventArgs e)
        {
            txtUser.Text = ConnectionString.MaNV;
            // txtuser = readonly = true; - k cho phép sửa mã nv
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newPass = txtPass.Text.Trim();
            string maNV=ConnectionString.MaNV;
            string currentPass=txtCurrentPass.Text.Trim();

            if(string.IsNullOrEmpty(newPass) )
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
            //lấy mk cũ từ database
            string query = "SELECT MatKhau FROM NhanVien WHERE MaNV = @manv";
            SqlParameter[] param = { new SqlParameter("@manv", maNV) };

            DataTable dt = DataProvider.ExcuteQuery(query, param);

            if(dt.Rows.Count > 0 )
            {
                string realPass = dt.Rows[0]["MatKhau"].ToString();

                //kiểm tra mk nhập vào có đúng mk trong db k
                if (currentPass != realPass)
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCurrentPass.Focus();
                    return;
                }
                //kiểm tra có trùng mk cũ k
                if (newPass == realPass)
                {
                    MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ!", "Thông báo");
                    txtPass.Focus();
                    return;
                }

                //update mk
                string queryUp = "Update NhanVien set MatKhau = @newpass where MaNV=@manv";
                SqlParameter[] parammeter =
                {
                    new SqlParameter("@newpass",newPass),
                    new SqlParameter("@manv",maNV)
                };

                int result = DataProvider.ExcuteNonQuery(queryUp, parammeter);
                if(result > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurrentPass.Clear();
                    txtPass.Clear();
                } 
                    
            }    

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             txtCurrentPass.Clear();
                    txtPass.Clear();
        }
    }
}
