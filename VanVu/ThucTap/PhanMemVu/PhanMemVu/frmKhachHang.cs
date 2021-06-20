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
    public partial class frmKhachHang : Form
    {
        string Scon = "Data Source=DESKTOP-8T8UIUI\\SQLEXPRESS02;Initial Catalog=TRANVANVU;Integrated Security=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form KhachHang = new frmMain();
            KhachHang.Show();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            string sQuery = " select * from KHACHHANG";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "KHACHHANG");
            dataGridView1.DataSource = ds.Tables["KHACHHANG"];
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
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            int iThanThiet = 0;
            if (radioCo.Checked == true)
            {
                iThanThiet = 1;
            }
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sDiaChi = txtDiaChi.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int iGioiTinh = 0;
            if (radioNam.Checked == true)
            {
                iGioiTinh = 1;
            }

            string sQuery = "insert into KHACHHANG values (@maKH, @tenKH, @DiaChi, @GioiTinh, @NgSinh, @ThanThiet)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@tenKH", sTenKH);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@GioiTinh", iGioiTinh);
            cmd.Parameters.AddWithValue("@NgSinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@ThanThiet", iThanThiet);            
            try
            {
                
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Lưu thành công!");
                
            }
            catch (Exception ex)
            {

                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp mã khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp tên Khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp địa chỉ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ThanThiet = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["ThanThiet"].Value);
            if (ThanThiet == 1)
            {
                radioCo.Checked = true;
            }
            else
            {
                radioKhong.Checked = true;
            }
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            int GioiTinh = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value);
            if (GioiTinh == 1)
            {
                radioNam.Checked = true;
            }
            else
            {
                radioNu.Checked = true;
            }

            txtMaKH.Enabled = false;

        }

        private void taomoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtMaKH.Focus();
            txtMaKH.Enabled = true;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int iThanThiet = 0;
            if (radioCo.Checked == true)
            {
                iThanThiet = 1;
            }
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sDiaChi = txtDiaChi.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int iGioiTinh = 0;
            if (radioNam.Checked == true)
            {
                iGioiTinh = 1;
            }

            string sQuery = "update KHACHHANG set TENKH = @tenKH, DIACHI = @DiaChi, NGAYSINH = @NgSinh, GIOITINH = @GioiTinh, ThanThiet = @ThanThiet WHERE MAKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@tenKH", sTenKH);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@GioiTinh", iGioiTinh);
            cmd.Parameters.AddWithValue("@NgSinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@ThanThiet", iThanThiet);
            try
            {
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
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
                string sMaKH = txtMaKH.Text;
                string sQuery = "delete KHACHHANG WHERE MAKH = @maKH";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maKH", sMaKH);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Xóa thành công!");
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trinh Xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

        }

        private void timlai_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(Scon);
            txtTimKiem.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            string sQuery = " select * from KHACHHANG";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt .Fill(ds, "KHACHHANG");
            dataGridView1.DataSource = ds.Tables["KHACHHANG"];
            con.Close();


        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng cần tìm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string sQuery = " SELECT * FROM KHACHHANG WHERE MAKH = @maKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);          
            cmd.Parameters.AddWithValue("@MaKH", txtTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Load(dr);
            dataGridView1.DataSource = dt;         
            
            
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
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string Select = "SELECT * FROM  KHACHHANG";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
