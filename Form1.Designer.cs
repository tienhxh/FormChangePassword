namespace frm
{
    partial class Form1
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
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(123, 131);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(345, 33);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.Enter += new System.EventHandler(this.txtMatKhauMoi_Enter);
            this.txtMatKhauMoi.Leave += new System.EventHandler(this.txtMatKhauMoi_Leave);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(123, 81);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(345, 32);
            this.txtMatKhauCu.TabIndex = 2;
            this.txtMatKhauCu.Enter += new System.EventHandler(this.txtMatKhauCu_Enter);
            this.txtMatKhauCu.Leave += new System.EventHandler(this.txtMatKhauCu_Leave);
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNhapLai.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLai.Location = new System.Drawing.Point(123, 185);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(345, 32);
            this.txtNhapLai.TabIndex = 3;
            this.txtNhapLai.Enter += new System.EventHandler(this.txtNhapLai_Enter);
            this.txtNhapLai.Leave += new System.EventHandler(this.txtNhapLai_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(123, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frm.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtMatKhauCu);
            this.panel1.Controls.Add(this.txtMatKhauMoi);
            this.panel1.Controls.Add(this.txtNhapLai);
            this.panel1.Location = new System.Drawing.Point(53, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 364);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(336, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frm.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

