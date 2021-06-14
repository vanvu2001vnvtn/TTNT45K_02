using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_Đơn_may_mặc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKhachHang Khach = new frmKhachHang();
            Khach.MdiParent = this;
            Khach.Show();
        }

        private void ThemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon HD = new frmHoaDon();
            HD.MdiParent = this;
            HD.Show();
        }

        private void thốngKêĐơnĐặtMayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe ThongKe = new frmThongKe();
            ThongKe.MdiParent = this;
            ThongKe.Show();
        }
    }
}
