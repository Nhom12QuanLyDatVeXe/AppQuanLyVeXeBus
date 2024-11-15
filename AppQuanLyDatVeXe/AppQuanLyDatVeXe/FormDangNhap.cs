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

        private TaiKhoan_BUL TK_BUL = new TaiKhoan_BUL();

        

        private void ckcHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienPass.Checked == true)
                txtPass.PasswordChar = (char)0;
            else
                txtPass.PasswordChar = '*';
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                lblThongBaoSDT.Visible = true;
                lblThongBaoSDT.Text = "Vui lòng nhập số điện thoại";
                return;
            }
            if (txtPass.Text.Length == 0)
            {
                lblThongBaoPass.Visible = true;
                lblThongBaoPass.Text = "Vui lòng nhập mật khẩu";
                return;
            }
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.UserName = txtUserName.Text;
            account.PassWord = txtPass.Text;
            if(TK_BUL.CheckLogin(account) == 1)
            {
                FormMain form = new FormMain();
                form.ShowDialog();
                this.Visible = false;
                this.Hide();
            }
        }
    }
}
