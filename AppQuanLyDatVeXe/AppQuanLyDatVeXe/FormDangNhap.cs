using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;

namespace AppQuanLyDatVeXe
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        TaiKhoan_BUL tK_BUL = new TaiKhoan_BUL();
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ckcHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienPass.Checked == true)
                txtPass.PasswordChar = (char)0;
            else
                txtPass.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenUser.Text.Length == 0)
            {
                lblThongBaoSDT.Visible = true;
                lblThongBaoSDT.Text = "Vui lòng nhập tên đăng nhập"; return;
            }          
            if (txtPass.Text.Length == 0)
            {
                lblThongBaoPass.Visible = true;
                lblThongBaoPass.Text = "Vui lòng nhập mật khẩu"; return;
            }
            TaiKhoan_DTO acc = new TaiKhoan_DTO();
            if(tK_BUL.CheckLogin(acc) == 1)
            {
                FormMain main = new FormMain();
                main.ShowDialog();
                this.Hide();
                this.Visible = false;
            }
        }

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormDangKy dk= new FormDangKy();
            
            dk.Show();
            this.Hide();
        }

    }
}
