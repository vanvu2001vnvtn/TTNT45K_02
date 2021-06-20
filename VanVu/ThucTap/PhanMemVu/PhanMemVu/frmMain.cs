using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemVu
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Hide();
                Form frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
            }
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void DonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DonHang = new frmHoaDon();
            DonHang.Show();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form KhachHang = new frmKhachHang();
            KhachHang.Show();
        }

        private void CaiDatTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmCaiDatTK();
            CaiDat.Show();
        }

      
    }
}
