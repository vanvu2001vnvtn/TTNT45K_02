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
    public partial class frmHoaDon : Form
    {
        string Scon = "Data Source=DESKTOP-8T8UIUI\\SQLEXPRESS02;Initial Catalog=TRANVANVU;Integrated Security=True";
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HoaDon = new frmMain();
            HoaDon.Show();

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            //Bước 1
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Bước 2
            string sQuery = "Select KH.TENKH, HD.* from HOADON AS HD, KHACHHANG AS KH WHERE HD.MAKH = KH.MAKH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HOADON");

            dataGridView1.DataSource = ds.Tables["HOADON"];

            con.Close();//Bước 3
        }

        private void taomoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtTongTien.Text = "";
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            //Bước 1
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Bước 2
            //Chuẩn bị dữ liệu
            //Kiểm tra tính hợp lệ của dl là ng dùng đã nhập mã hk...
            //Gán dl vào biến
            
            string sMaHD = txtMaHD.Text;
            string sMaKH = txtMaKH.Text;
            string sNgayDat = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sTongTien = txtTongTien.Text;

            //B2
            string sQuery = "insert into HOADON values(@MaHD, @MaKH, @NgayDat, @TongTien)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@NgayDat", sNgayDat);
            cmd.Parameters.AddWithValue("@TongTien", sTongTien);

            try
            {
                
                cmd.ExecuteNonQuery();
                HienThi();                
                string SQuery = "Select KH.TENKH, HD.* from HOADON AS HD, KHACHHANG AS KH WHERE HD.MAKH = KH.MAKH";
                SqlDataAdapter adt = new SqlDataAdapter(SQuery, con);
                DataSet ds = new DataSet();
                adt.Fill(ds, "HOADON");
                dataGridView1.DataSource = ds.Tables["HOADON"];
                MessageBox.Show("Lưu thành công !");
            }
            catch (Exception ex)
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp mã hóa đơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp mã Khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    else if (txtTongTien.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhâp tổng tiền!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Mã Hóa đơn đã tồn tại hoặc Mã khách hàng không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            con.Close();//Bước 3
        }

        private void sua_Click(object sender, EventArgs e)
        {
            //Bước 1
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Bước 2
            string sMaHD = txtMaHD.Text;
            string sMaKH = txtMaKH.Text;
            string sNgayDat = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sTongTien = txtTongTien.Text;

            string sQuery = "update HOADON set MaKH = @MaKH, " + "NgayDat = @NgayDat, " + "TongTien = @TongTien " + "where MaHD = @MaHD";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@NgayDat", sNgayDat);
            cmd.Parameters.AddWithValue("@TongTien", sTongTien);

            try
            {
                cmd.ExecuteNonQuery();
                HienThi();
                string SQuery = "Select KH.TENKH, HD.* from HOADON AS HD, KHACHHANG AS KH WHERE HD.MAKH = KH.MAKH";
                SqlDataAdapter adt = new SqlDataAdapter(SQuery, con);
                DataSet ds = new DataSet();
                adt.Fill(ds, "HOADON");
                dataGridView1.DataSource = ds.Tables["HOADON"];
                MessageBox.Show("Cập nhật thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();//Bước 3
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayDat"].Value);
            txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn Xóa không ?", "Thông báo !", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                //Bước 1
                SqlConnection con = new SqlConnection(Scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Bước 2
                //Lấy giá trị
                string sMaHD = txtMaHD.Text;

                //B2.2
                string sQuery = "delete HOADON where MaHD = @MaHD";

                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaHD", sMaHD);

                try
                {
                    cmd.ExecuteNonQuery();
                    HienThi();
                    string SQuery = "Select KH.TENKH, HD.* from HOADON AS HD, KHACHHANG AS KH WHERE HD.MAKH = KH.MAKH";
                    SqlDataAdapter adt = new SqlDataAdapter(SQuery, con);
                    DataSet ds = new DataSet();
                    adt.Fill(ds, "HOADON");
                    dataGridView1.DataSource = ds.Tables["HOADON"];
                    MessageBox.Show("Xóa thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình Xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();//Bước 3
            }
        }

        private void tim_Click(object sender, EventArgs e)
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
                MessageBox.Show("Chưa nhập mã hóa đơn hoặc mã khách hàng cần tìm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sQuery = "SELECT KH.TENKH, HD.* FROM HOADON AS HD, KHACHHANG AS KH where HD.MAKH = KH.MAKH AND HD.MaHD = @MaHD OR HD.MAKH = KH.MAKH AND KH.MAKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", txtTimKiem.Text);
            cmd.Parameters.AddWithValue("@MaKH", txtTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void TimLai_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            txtTimKiem.Text = "";
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtTongTien.Text = "";
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            string sQuery = "Select KH.TENKH, HD.* from HOADON AS HD, KHACHHANG AS KH WHERE HD.MAKH = KH.MAKH";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HOADON");
            dataGridView1.DataSource = ds.Tables["HOADON"];
            con.Close();
        }

        private void qulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HoaDon = new frmMain();
            HoaDon.Show();
        }

        private void chitiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form chitiet = new frmChiTiet();
            chitiet.Show();
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
            string Select = "SELECT * FROM  HOADON";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
