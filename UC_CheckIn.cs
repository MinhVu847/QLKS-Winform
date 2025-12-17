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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNumOfBeds.SelectedIndex = -1;
            cbbRoomName.SelectedIndex = -1;
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
                txtPrice.Text = loadPrice();
            loadData();
        }
        string loadPrice()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@LoaiPhong", cbbRoomType.Text),
                new SqlParameter("@SoGiuong", cbbNumOfBeds.Text),
                new SqlParameter("@TenPhong", cbbRoomName.Text),
            };
            DataTable dt = DataProvider.ExcuteQuery(Query.ShowPrice, parameters);
            if(dt.Rows.Count > 0)
                return dt.Rows[0]["GiaPhong"].ToString();
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
                    cbbRoomType.Items.Add(row["LoaiPhong"].ToString());
            }
            if( cbbNumOfBeds.Text == "")
            {
                cbbNumOfBeds.Items.Clear();
                foreach (DataRow row in dt.Rows)
                    cbbNumOfBeds.Items.Add(row["SoGiuong"].ToString());
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
                txtPrice.Text = loadPrice();
            loadData();
        }

        private void cbbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoomType.Text != "" && cbbNumOfBeds.Text != "" && cbbRoomName.Text != "")
                txtPrice.Text = loadPrice();
            loadData();
        }
    }
}
