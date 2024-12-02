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
    public partial class FormMain : Form
    {
        TaiKhoan_DTO acc = new TaiKhoan_DTO();
        NhanVien_BUL bul_nv = new NhanVien_BUL();
        NhanVien_DTO nv = new NhanVien_DTO();
        public FormMain(TaiKhoan_DTO login_acc)
        {
            InitializeComponent();
            if (login_acc.Quyen == "Admin") { 
                labelTenNguoiDung.Text = acc.UserName;

            }
            else
            {
                nv = bul_nv.getNhanVien(login_acc.ID);
                acc = login_acc;
                labelTenNguoiDung.Text = nv.HoTen;
            }
            
        }
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.AutoSize = true;
            f.AutoScaleMode = AutoScaleMode.Dpi;
            f.Dock= DockStyle.Fill;
            f.Show();
        }
        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            AddControls(new FormChuyenXe());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in CenterPanel.Controls)
            {
                ctrl.Dock = DockStyle.Fill;
            }
        }

        private void btnVeXe_Click(object sender, EventArgs e)
        {
            AddControls(new FormVeXe(nv));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            AddControls(new FormThongTinKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            AddControls(new FormHoaDon());
        }

        private void btnPhuongTien_Click(object sender, EventArgs e)
        {
            AddControls(new FormPhuongTien());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AddControls(new FormNhanVien());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();

            dn.Show();

            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new FormDatVeXe());
        }
    }
}
