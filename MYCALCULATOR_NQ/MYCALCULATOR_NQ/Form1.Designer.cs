namespace MYCALCULATOR_NQ
{
    partial class frmCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculation));
            this.btnCong = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCong.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnCong.Location = new System.Drawing.Point(36, 143);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNhan.Location = new System.Drawing.Point(186, 143);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 1;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTru.Location = new System.Drawing.Point(36, 183);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 2;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChia.Location = new System.Drawing.Point(186, 183);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNhaplai.Location = new System.Drawing.Point(197, 55);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 4;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = false;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSo1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSo1.Location = new System.Drawing.Point(36, 33);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 20);
            this.txtSo1.TabIndex = 5;
            // 
            // txtSo2
            // 
            this.txtSo2.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSo2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSo2.Location = new System.Drawing.Point(36, 84);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 20);
            this.txtSo2.TabIndex = 6;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtKQ.ForeColor = System.Drawing.Color.Tomato;
            this.txtKQ.Location = new System.Drawing.Point(98, 245);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 7;
            // 
            // frmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 307);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnCong);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.MaximizeBox = false;
            this.Name = "frmCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

