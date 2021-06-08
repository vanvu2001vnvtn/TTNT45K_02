
namespace Calculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(45, 280);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(70, 31);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(183, 281);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(70, 30);
            this.btTru.TabIndex = 1;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(46, 218);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(69, 31);
            this.btNhan.TabIndex = 2;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(186, 220);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(67, 29);
            this.btChia.TabIndex = 3;
            this.btChia.Text = "Chia";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(117, 165);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(70, 30);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Nhập Lại";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(46, 35);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(206, 23);
            this.txtKQ.TabIndex = 5;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(186, 115);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(103, 23);
            this.txtSo2.TabIndex = 6;
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(12, 115);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(103, 23);
            this.txtSo1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(304, 360);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txt;
    }
}

