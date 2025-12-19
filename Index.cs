using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_Winform
{
    public partial class Index : Form
    {
        // Khai báo ngoài phạm vi của các phương thức 
        private Control button = null;
        public Index()
        {
            InitializeComponent();
            Phanquyen();
            
        }

        //Phân quyền
        private void Phanquyen()
        {
            if(ConnectionString.ChucVu=="Quản lý")
            {
                btnSting.Enabled = false;
                btnSting.Cursor = default;
            }    
                                
            else if(ConnectionString.ChucVu=="Lễ tân")
            {
                btnSting.Enabled = false;
                btnSting.Cursor = default;
                btnAltic.Enabled = false;
                btnAltic.Cursor = default;
            }    
            else if(ConnectionString.ChucVu=="Kế toán")
            {
                btnChkin.Enabled= false;
                btnChkin.Cursor = default;
                btnChkout.Enabled = false;
                btnChkout.Cursor = default;
                btnSting.Enabled= false;
                btnSting.Cursor = default;
            }
            else //bảo vệ-buồng phòng
            {
                btnData.Enabled = false;
                btnData.Cursor = default;
                btnChkin.Enabled = false;
                btnChkin.Cursor = default;
                btnChkout.Enabled = false;
                btnChkout.Cursor = default;
                btnSting.Enabled=false;
                btnSting.Cursor = default;
                btnAltic.Enabled=false;
                btnAltic.Cursor = default;
            }    
        }

        private void Index_Load(object sender, EventArgs e)
        {
            btnData.Click += Button_Click;
            btnAltic.Click += Button_Click;
            btnChkin.Click += Button_Click;
            btnChkout.Click += Button_Click;
            btnEx.Click += Button_Click;
            btnFind.Click += Button_Click;
            btnSting.Click += Button_Click;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            
            if (button != null)                      
                button.BackColor = Color.FromArgb(14, 27, 53); // Màu nền ban đầu          

            // Bước 2: Thiết lập nút hiện tại là nút được chọn
            Control clickedControl = (Control)sender; // 'sender' là nút vừa được click

            // Thiết lập màu nền đậm hơn (Active Color)
            clickedControl.BackColor = Color.FromArgb(30, 36, 61); // Màu đậm hơn

            // Bước 3: Cập nhật biến theo dõi
            button = clickedControl;

            // thêm form hiện ra
              


        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void showUserControl(UserControl uc)
        {
            foreach (Control c in plData.Controls)
            {
                c.Visible = false;
            }

            uc.Visible = true;
            uc.BringToFront();
        }
        private void btnSting_Click(object sender, EventArgs e)
        {
            showUserControl(uC_Employees1);
        }

        private void btnChkin_Click(object sender, EventArgs e)
        {
           showUserControl(uC_CheckIn1);
        }
    }
}
