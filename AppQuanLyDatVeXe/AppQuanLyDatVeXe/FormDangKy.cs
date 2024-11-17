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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }
        TaiKhoan_BUL TK_BUL = new TaiKhoan_BUL();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenUser.Text.Length == 0)
            {
                lblThongBaoSDT.Visible = true;
                lblThongBaoSDT.Text = "Vui lòng nhập tên đăng nhập";
                return;
            }  
            if (txtPass.Text.Length == 0)
            {
                lblThongBaoPass.Visible = true;
                lblThongBaoPass.Text = "Vui lòng nhập mật khẩu";
                return;
            }                
            if(txtNhapLaiPass.Text.Length == 0) 
            {
                lblThongBaoNhapLai.Visible = true;
                lblThongBaoNhapLai.Text = "Vui lòng nhập lại mật khẩu";
                return;
            }
            TaiKhoan_DTO acc = new TaiKhoan_DTO();
            if (txtPass.Text != txtNhapLaiPass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            else
            {
                acc.UserName = txtTenUser.Text;
                acc.PassWord = txtNhapLaiPass.Text;
                if(TK_BUL.CheckAccount(acc) == 1)
                {
                    MessageBox.Show("User Name đã tồn tại! Vui lòng dùng User Name mới!");
                    return;
                }
                else
                {
                    if(TK_BUL.AddAccount(acc) == 1)
                    {
                        MessageBox.Show("Đã tạo tài khoản mới thành công!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại! Kiểm tra lại thông tin vừa nhập!");
                        txtTenUser.Focus();
                        return;
                    }    
                }
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
