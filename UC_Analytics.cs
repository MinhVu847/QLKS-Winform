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
    public partial class UC_Analytics : UserControl
    {
        public UC_Analytics()
        {
            InitializeComponent();
        }

        private void btnAnalytic_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetRevenueByDate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //truyền ngày tháng từ giao diện
                cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }    

            //đổ dữ liệu vào dataset
            dsRevenue ds = new dsRevenue();

            //copy dữ liệu từ sql --> dataset
            foreach(DataRow row in dt.Rows)
            {
                ds.dtDoanhThu.Rows.Add(
                    row["MaHD"],
                    row["TenKhachHang"],
                    row["TenPhong"],
                    row["NgayThanhToan"],
                    row["TongTien"]
                    );
                    
            }         
            // gắn dataset vào report
            rptRevenue rpt = new rptRevenue();
            rpt.SetDataSource(ds);

            //hiển thị lên view
            crvRevenue.ReportSource = rpt;
            crvRevenue.Refresh();
        }
    }
}
