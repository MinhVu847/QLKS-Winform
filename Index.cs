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
                btnData.Enabled=false;
                btnData.Cursor = default;
                OffCorlor(btnData);
            }    
                                
            else if(ConnectionString.ChucVu=="Lễ tân")
            {
                btnData.Enabled = false;
                btnData.Cursor = default;
                btnSting.Enabled = false;
                btnSting.Cursor = default;
                btnAltic.Enabled = false;
                btnAltic.Cursor = default;
                OffCorlor(btnSting);
                OffCorlor(btnAltic); 
                OffCorlor(btnData);
            }    
            else if(ConnectionString.ChucVu=="Kế toán")
            {
                btnChkin.Enabled= false;
                btnChkin.Cursor = default;
                btnChkout.Enabled = false;
                btnChkout.Cursor = default;
                btnSting.Enabled= false;
                btnSting.Cursor = default;
                OffCorlor(btnChkin);
                OffCorlor(btnChkout);
                OffCorlor(btnSting);
            }
            else if(ConnectionString.ChucVu=="Bảo vệ" || ConnectionString.ChucVu=="Buồng phòng")
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
                OffCorlor(btnData);
                OffCorlor(btnChkin);
                OffCorlor(btnChkout);
                OffCorlor(btnSting);
                OffCorlor(btnAltic);
            }    
            //quản trị- full chức năng
        }
        private void OffCorlor(Button bt)
        {
            bt.BackColor = Color.FromArgb(10, 23, 49);
            
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

        private void btnChkout_Click(object sender, EventArgs e)
        {
            showUserControl(uC_CheckOut1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
                Application.Restart();
        }
    }
}
