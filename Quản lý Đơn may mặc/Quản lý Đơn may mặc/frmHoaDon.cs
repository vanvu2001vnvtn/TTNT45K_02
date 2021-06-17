using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Quản_lý_Đơn_may_mặc
{
    public partial class frmHoaDon : Form
    {
        string sCon = "Data Source=DESKTOP-7QTS2T4;Initial Catalog=QUANLIMAYMAC;Integrated Security=True";
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {   //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            //Bước 2
            string sQuery = "Select * from HOADON";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HOADON");

            dgvHoaDon.DataSource = ds.Tables["HOADON"];

            con.Close();//Bước 3
        }

    }
}
