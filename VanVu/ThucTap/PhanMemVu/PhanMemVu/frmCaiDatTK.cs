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
    public partial class frmCaiDatTK : Form
    {
        string Scon = "Data Source=DESKTOP-8T8UIUI\\SQLEXPRESS02;Initial Catalog=TRANVANVU;Integrated Security=True";
        public frmCaiDatTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmMain();
            CaiDat.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtMK.Text = "";
            txtTK.Focus();
            txtTK.Enabled = true;
        }

        private void frmCaiDatTK_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            string sQuery = " select * from DANGNHAP";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "DANGNHAP");
            dataGridView1.DataSource = ds.Tables["DANGNHAP"];
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = dataGridView1.Rows[e.RowIndex].Cells["TAIKHOAN"].Value.ToString();
            txtMK.Text = dataGridView1.Rows[e.RowIndex].Cells["MATKHAU"].Value.ToString();
            txtTK.Enabled = false;
           
        }

        private void doiMK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            string sTK = txtTK.Text;
            string sMK = txtMK.Text;
            string sQuery = "update DANGNHAP set MATKHAU =@MATKHAU Where TAIKHOAN = @TAIKHOAN";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TAIKHOAN", sTK);
            cmd.Parameters.AddWithValue("@MATKHAU", sMK);
            try
            {
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            con.Close();

        }

        private void luu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }

            string sTK = txtTK.Text;
            string sMK = txtMK.Text;
            string sQuery = "insert into DANGNHAP values(@TAIKHOAN, @MATKHAU)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TAIKHOAN", sTK);
            cmd.Parameters.AddWithValue("@MATKHAU", sMK);
            try
            {
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Tạo mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài Khoản đã được sử dụng!");
            }
            con.Close();
        }

        private void xoaTK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn Xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sTK = txtTK.Text;
                string sQuery = "delete DANGNHAP WHERE TAIKHOAN = @TAIKHOAN";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TAIKHOAN", sTK);

                try
                {
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trinh Xóa!");
                }
                con.Close();
            }
        }
        public void HienThi()
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            string Select = "SELECT * FROM  DANGNHAP";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
