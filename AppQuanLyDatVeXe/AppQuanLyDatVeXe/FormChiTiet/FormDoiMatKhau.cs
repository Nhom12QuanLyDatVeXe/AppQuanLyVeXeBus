using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;

namespace AppQuanLyDatVeXe.FormChiTiet
{
    public partial class FormDoiMatKhau : Form
    {
        NhanVien_DTO nhanvien = new NhanVien_DTO();
        public FormDoiMatKhau(NhanVien_DTO nv)
        {
            nhanvien = nv;
            InitializeComponent();
            txtMKCu.PasswordChar = '*';
            txtMKMoi.PasswordChar = '*';
        }

        NhanVien_BUL bul = new NhanVien_BUL();
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nhanvien != null)
            {
                string mkCu = txtMKCu.Text;
                string mkMoi = txtMKMoi.Text;
                if(bul.doiMatKhau(mkCu, mkMoi, nhanvien.MaNV) == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không trùng khớp!");
                }
            }
        }
    }
}
