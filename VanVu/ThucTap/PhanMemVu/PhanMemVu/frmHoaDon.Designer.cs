namespace PhanMemVu
{
    partial class frmHoaDon
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
            this.quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.qulai = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.TimLai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.taomoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quaylai
            // 
            this.quaylai.Location = new System.Drawing.Point(1788, 402);
            this.quaylai.Margin = new System.Windows.Forms.Padding(5);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(125, 37);
            this.quaylai.TabIndex = 0;
            this.quaylai.Text = "Quay Lại";
            this.quaylai.UseVisualStyleBackColor = true;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng Tiền";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(392, 141);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(320, 29);
            this.txtMaHD.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(392, 217);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(320, 29);
            this.txtMaKH.TabIndex = 7;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(919, 217);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(277, 29);
            this.txtTongTien.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(919, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 29);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(622, 306);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(96, 36);
            this.luu.TabIndex = 10;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(739, 306);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(96, 36);
            this.sua.TabIndex = 11;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(859, 306);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(96, 36);
            this.xoa.TabIndex = 12;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // qulai
            // 
            this.qulai.Location = new System.Drawing.Point(1100, 306);
            this.qulai.Name = "qulai";
            this.qulai.Size = new System.Drawing.Size(96, 36);
            this.qulai.TabIndex = 13;
            this.qulai.Text = "Quay Lại";
            this.qulai.UseVisualStyleBackColor = true;
            this.qulai.Click += new System.EventHandler(this.qulai_Click);
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(978, 380);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(96, 36);
            this.tim.TabIndex = 14;
            this.tim.Text = "Tìm Kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // TimLai
            // 
            this.TimLai.Location = new System.Drawing.Point(1100, 380);
            this.TimLai.Name = "TimLai";
            this.TimLai.Size = new System.Drawing.Size(96, 36);
            this.TimLai.TabIndex = 15;
            this.TimLai.Text = "Tìm Lại";
            this.TimLai.UseVisualStyleBackColor = true;
            this.TimLai.Click += new System.EventHandler(this.TimLai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(622, 385);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 29);
            this.txtTimKiem.TabIndex = 17;
            // 
            // taomoi
            // 
            this.taomoi.Location = new System.Drawing.Point(503, 306);
            this.taomoi.Name = "taomoi";
            this.taomoi.Size = new System.Drawing.Size(96, 36);
            this.taomoi.TabIndex = 18;
            this.taomoi.Text = "Tạo Mới";
            this.taomoi.UseVisualStyleBackColor = true;
            this.taomoi.Click += new System.EventHandler(this.taomoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 293);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chitiet
            // 
            this.chitiet.Location = new System.Drawing.Point(978, 306);
            this.chitiet.Name = "chitiet";
            this.chitiet.Size = new System.Drawing.Size(96, 36);
            this.chitiet.TabIndex = 20;
            this.chitiet.Text = "Chi Tiết";
            this.chitiet.UseVisualStyleBackColor = true;
            this.chitiet.Click += new System.EventHandler(this.chitiet_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.chitiet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taomoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimLai);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.qulai);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quaylai);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button qulai;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Button TimLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button taomoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button chitiet;
    }
}