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
    public partial class frmDangNhap : Form
    {
        string Scon = "Data Source=DESKTOP-8T8UIUI\\SQLEXPRESS02;Initial Catalog=TRANVANVU;Integrated Security=True";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Scon);
            try
            {
                conn.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sqlSelect = "select * from DANGNHAP where TaiKhoan ='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    Form frmMain = new frmMain();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!");                    
                    txtmatkhau.Text = "";                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!");

            }
        }

        private void MatKhau_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
