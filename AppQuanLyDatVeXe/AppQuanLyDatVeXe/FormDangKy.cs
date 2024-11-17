using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDatVeXe
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenUser.Text.Length == 0)
            {
                lblThongBaoSDT.Visible = true;
                lblThongBaoSDT.Text = "Vui lòng nhập tên đăng nhập";
            }
            else
                return;
            if (txtPass.Text.Length == 0)
            {
                lblThongBaoPass.Visible = true;
                lblThongBaoPass.Text = "Vui lòng nhập mật khẩu";
            }
            else
                return;
            if(txtNhapLaiPass.Text.Length == 0) 
            {
                lblThongBaoNhapLai.Visible = true;
                lblThongBaoNhapLai.Text = "Vui lòng nhập lại mật khẩu";
            }

        }

        private void ckcHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienPass.Checked == true)
                txtPass.PasswordChar = (char)0;
            else
                txtPass.PasswordChar = '*';
        }

        private void ckxHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxHienPass.Checked == true)
                txtNhapLaiPass.PasswordChar = (char)0;
            else
                txtNhapLaiPass.PasswordChar = '*';
        }

        private void linkDN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhap dn=new FormDangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
