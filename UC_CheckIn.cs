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
            loadData();
        }
        void loadData()
        {
            try
            {
                cbbRoomType.Items.Add(CheckRoom().Rows[3][1]);
            }
            catch (Exception ex) { }
            try
            {
                cbbNumOfBeds.Items.Add(CheckRoom().Rows[4][1]);
            }
            catch (Exception ex) { }
            try {
                cbbRoomName.Items.Add(CheckRoom().Rows[2][1]);
            }catch (Exception ex) { }
        }
        DataTable CheckRoom()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query.CheckRoom, con))
                {
                    cmd.Parameters.AddWithValue("@LoaiPhong", cbbRoomName.Text);
                    cmd.Parameters.AddWithValue("@SoGiuong", cbbNumOfBeds.Text);
                    cmd.Parameters.AddWithValue("@TenPhong", cbbRoomName.Text);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) 
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
