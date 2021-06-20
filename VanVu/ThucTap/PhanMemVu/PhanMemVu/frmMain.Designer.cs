namespace PhanMemVu
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CaiDatTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaiDatTKToolStripMenuItem,
            this.KhachHangToolStripMenuItem,
            this.DonHangToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CaiDatTKToolStripMenuItem
            // 
            this.CaiDatTKToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaiDatTKToolStripMenuItem.Name = "CaiDatTKToolStripMenuItem";
            this.CaiDatTKToolStripMenuItem.Size = new System.Drawing.Size(147, 25);
            this.CaiDatTKToolStripMenuItem.Text = "Cài đặt tài khoản";
            this.CaiDatTKToolStripMenuItem.Click += new System.EventHandler(this.CaiDatTKToolStripMenuItem_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.KhachHangToolStripMenuItem.Text = "Khách Hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // DonHangToolStripMenuItem
            // 
            this.DonHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonHangToolStripMenuItem.Name = "DonHangToolStripMenuItem";
            this.DonHangToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.DonHangToolStripMenuItem.Text = "Đơn Hàng";
            this.DonHangToolStripMenuItem.Click += new System.EventHandler(this.DonHangToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC KINH TẾ - ĐẠI HỌC ĐÀ NẴNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(313, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÍ CÁC ĐƠN HÀNG ĐẶT MAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(220, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giáo Viên Hướng Dẫn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(220, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sinh Viên Thực Hiện:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(537, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cao Thị Nhâm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(537, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trần Văn Vũ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(537, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đỗ Như Quỳnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(537, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngô Thị Tú Trinh";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources.duli;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmMain";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DonHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CaiDatTKToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}