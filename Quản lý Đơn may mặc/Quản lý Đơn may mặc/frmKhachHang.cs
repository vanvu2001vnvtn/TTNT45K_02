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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKh.Text;
            MessageBox.Show("Bạn vừa nhập Mã Khách Hàng là: "+ sMaKH );
        }

    }
}
