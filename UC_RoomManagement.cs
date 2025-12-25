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
    public partial class UC_RoomManagement : UserControl
    {
        public UC_RoomManagement()
        {
            InitializeComponent();
        }
        void loadData()
        {

        }
        void addRoom()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", txtRoomID.Text.Trim()),
                new SqlParameter("@TenPhong", txtRoomName.Text.Trim()),
                new SqlParameter("@LoaiPhong", cbbRoomType.Text.Trim()),
                new SqlParameter("@SoGiuong", cbbRoomType.Text.Trim()),
                new SqlParameter("@TrangThai", "Trống"),
                new SqlParameter("@@GiaPhong", txtPrice.Text.Trim()),
            };
            DataProvider.ExcuteNonQuery(Query.AddRoom, parameters);
            foreach(Control control in grbRoomManage.Controls)
            {
                if(control is TextBox textBox)
                    textBox.Clear();
                else if(control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
            }
            loadData();
        }
        bool kTraTonTai(string roomID)
        {
            string query = "select MaPhong from Phong where MaPhong = @MaPhong";
            SqlParameter parameter = new SqlParameter("@MaPhong", roomID);
            if (DataProvider.ExcuteScalar(query, parameter) != null)
                return true;
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsDuplicateID.isDuplicateID("Phong", "MaPhong", txtRoomID.Text.Trim()))
            {
                DialogResult ds = MessageBox.Show("Xác nhận thêm phòng mới này vào danh sách", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    try
                    {
                        //addRoom();
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
    }
}
