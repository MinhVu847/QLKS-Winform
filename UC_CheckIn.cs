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
    public partial class UC_CheckIn : UserControl
    {
        public UC_CheckIn()
        {
            InitializeComponent();
            loadData();
        }
        string roomID;
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                MessageBox.Show(roomID);
                
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        bool CheckInfo()
        {
            foreach (Control control in this.Controls) 
            {
                if(!(control is Label) && control.Name != txtNote.Name)
                {
                    if(control.Text.Trim() == "" )
                        return false;
                }
            }
            return true;
        }
        void checkIN()
        {
            string MaDP = AutoID.nextID("DatPhong", "MaDP", "DP", 3);
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", txtID.Text),
                new SqlParameter("@HoTen", txtClientName.Text),
                new SqlParameter("@GioiTinh", cbbGender.Text),
                new SqlParameter("@CCCD", txtNatiID.Text),
                new SqlParameter("@SDT", txtPhoneNo.Text),
                new SqlParameter("@DiaChi", txtAddress.Text),
                new SqlParameter("@MaDP", MaDP),
                new SqlParameter("@MaPhong", roomID),
                new SqlParameter("@NgayDat", dtCin.Value.ToString()),
                //new SqlParameter("@MaNV", ),
                new SqlParameter("@GhiChu", txtNote.Text),
            };
            DataProvider.ExcuteNonQuery(Query.CheckIn, parameters);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.Clear();
                }
                else if (control is ComboBox cb)
                    cb.SelectedIndex = -1;
            }
            loadData();
        }
        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNumOfBeds.SelectedIndex = -1;
            cbbRoomName.SelectedIndex = -1;
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }
        string getPriceRoomID()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text),
                new SqlParameter("@TenPhong", cbbRoomName.Text),
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.ShowPrice, parameters);
            if (dt.Rows.Count > 0)
            {
                roomID = dt.Rows[0]["MaPhong"].ToString();
                return dt.Rows[0]["GiaPhong"].ToString();
            }
            return "";
        }
        void loadData()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text),
                new SqlParameter("@TenPhong", cbbRoomName.Text)
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.CheckRoom, parameters);
            if (cbbRoomType.Text == "")
            {
                cbbRoomType.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["LoaiPhong"].ToString();
                    if (!cbbRoomType.Items.Contains(value))
                        cbbRoomType.Items.Add(value);
                }
            }
            if (cbbNumOfBeds.Text == "")
            {
                cbbNumOfBeds.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string value = row["SoGiuong"].ToString();
                    if (!cbbNumOfBeds.Items.Contains(value))
                        cbbNumOfBeds.Items.Add(value);
                }
            }
            if(cbbRoomName.Text == "")
            {
                cbbRoomName.Items.Clear();
                foreach (DataRow row in dt.Rows)
                    cbbRoomName.Items.Add(row["TenPhong"].ToString());
            }
        }
        private void cbbNumOfBeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }

        private void cbbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
            {
                txtPrice.Text = getPriceRoomID();
            }
            loadData();
        }
    }
}
