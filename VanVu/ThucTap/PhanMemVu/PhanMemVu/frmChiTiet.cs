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

namespace PhanMemVu
{
    public partial class frmChiTiet : Form
    {
        string Scon = "Data Source=DESKTOP-8T8UIUI\\SQLEXPRESS02;Initial Catalog=TRANVANVU;Integrated Security=True";
        public frmChiTiet()
        {
            InitializeComponent();
        }
        public void GetDatagridview()
        {
            string query = "select * from HD_CHITIET";
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            DataTable a = new DataTable();
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            dataGridView1.DataSource = a;
        }
        private void bthienthi_Click(object sender, EventArgs e)
        {
            GetDatagridview();
        }
        private void LoadDataHDchitiet(string mahd)
        {

            string query = "select * from HD_CHITIET where MaHD = " + mahd;
            DataTable a = new DataTable();
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            foreach(DataRow i in a.Rows)
            {
                txtMaHD.Text = i["MaHD"].ToString();
                txtTenSP.Text = i["TenSP"].ToString();
                txtNoiDung.Text = i["NoiDung"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(i["NgayHenTra"]);
                dateTimePicker2.Value = Convert.ToDateTime(i["NgayTra"]);
                txtThanhTien.Text = i["ThanhTien"].ToString();
                break;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
             if(txttimkiem.Text=="")
            {
                MessageBox.Show("Chưa nhập mã đơn hàng cần tìm","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "select * from HD_CHITIET where MaHD = " + txttimkiem.Text;
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            DataTable a = new DataTable();
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            dataGridView1.DataSource = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        string mahd = dataGridView1.CurrentRow.Cells["MaHD"].Value.ToString();
            LoadDataHDchitiet(mahd);
            txtMaHD.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        SqlConnection cnn = new SqlConnection(Scon);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kế nối !");
            }
            string query = "update HD_CHITIET set MaHD =" + txtMaHD.Text + ",TenSP = '" + txtTenSP.Text + "',NoiDung = '" + txtNoiDung.Text + "',NgayHenTra ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', NgayTra = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',ThanhTien = " + txtThanhTien.Text + "where MaHD = " + txtMaHD.Text;         
            SqlCommand cmm = new SqlCommand(query, cnn);

            try
            {
                cmm.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình lưu!");
            }
            cnn.Close();
            ResetData();
            GetDatagridview();
        }
        private void ResetData()
        {
            txtMaHD.Text = "";
            txtNoiDung.Text = "";
            txtTenSP.Text = "";
            txtThanhTien.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            txtMaHD.Enabled = true;
            txttimkiem.Text = "";
        }

        private void btnDHchuatra_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today;
            string date = tomorrow.ToString("yyyy-MM-dd");
            string query = "select * from HD_CHITIET where NgayTra > '" + date + "'";
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            DataTable a = new DataTable();
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            dataGridView1.DataSource = a;
        }

        private void btnDHdatra_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today;
            string date = tomorrow.ToString("yyyy-MM-dd");
            string query = "select * from HD_CHITIET where NgayTra < '" + date + "'";
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            DataTable a = new DataTable();
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            dataGridView1.DataSource = a;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btnDHcanhoanthanh_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            string date = tomorrow.ToString("yyyy-MM-dd");
            string query = "select * from HD_CHITIET where NgayHenTra = '" + date + "'";
            SqlConnection cnn = new SqlConnection(Scon);
            SqlCommand cmm = new SqlCommand(query, cnn);
            SqlDataAdapter caa = new SqlDataAdapter(cmm);
            DataTable a = new DataTable();
            cnn.Open();
            caa.Fill(a);
            cnn.Close();
            dataGridView1.DataSource = a;
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form QuayLai = new frmHoaDon();
            QuayLai.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            txtNoiDung.Text = dataGridView1.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Ngayhentra"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Ngaytra"].Value);
            txtThanhTien.Text = dataGridView1.Rows[e.RowIndex].Cells["Thanhtien"].Value.ToString();

            txtMaHD.Enabled = false;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xay ra lỗi trong quá trình kết nối DB");

            }
            // Lay du lieu ve
            string sQuery = "SELECT*FROM HD_CHITIET";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "HD_CHITIET");
            dataGridView1.DataSource = ds.Tables["HD_CHITIET"];
            con.Close();
        }

       
            
        }       

    }

