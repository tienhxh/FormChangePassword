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
using System.Configuration;

namespace frm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "Nhập mật khẩu cũ";
            txtMatKhauCu.ForeColor = Color.Silver;
            txtMatKhauMoi.Text = "Nhập mật khẩu mới";
            txtMatKhauMoi.ForeColor = Color.Silver;
            txtNhapLai.Text = "Nhập lại mật khẩu mới";
            txtNhapLai.ForeColor = Color.Silver;
        }

        private void txtMatKhauCu_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "Nhập mật khẩu cũ")
            {
                txtMatKhauCu.Text = "";
                txtMatKhauCu.ForeColor = Color.Black;

            }    
        }

        private void txtMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                txtMatKhauCu.Text = "Nhập mật khẩu cũ";
                txtMatKhauCu.ForeColor = Color.Silver;
            }    
        }

        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "Nhập mật khẩu mới")
            {
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.ForeColor = Color.Black;

            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                txtMatKhauMoi.Text = "Nhập mật khẩu mới";
                txtMatKhauMoi.ForeColor = Color.Silver;
            }
        }

        private void txtNhapLai_Enter(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "Nhập lại mật khẩu mới")
            {
                txtNhapLai.Text = "";
                txtNhapLai.ForeColor = Color.Black;

            }
        }

        private void txtNhapLai_Leave(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "")
            {
                txtNhapLai.Text = "Nhập lại mật khẩu mới";
                txtNhapLai.ForeColor = Color.Silver;
            }
        }
    }
}
