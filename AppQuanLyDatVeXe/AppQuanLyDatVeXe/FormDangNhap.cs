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
            acc.UserName = txtTenUser.Text;
            acc.PassWord = txtPass.Text;
            if (tK_BUL.CheckLogin(acc) == 1)
            {
                this.Hide();
                TaiKhoan_DTO acc_login = new TaiKhoan_DTO();
                acc_login = tK_BUL.getAccount(acc.UserName);
                using (FormMain main = new FormMain(acc_login))
                {
                    main.ShowDialog();
                }
                this.Close();
                
            }
            else if (tK_BUL.CheckLogin(acc) == 0)
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
            else
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!");
        }


    }
}
