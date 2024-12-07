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

        void QuyenNhanVienDatVe(bool check)
        {
            btnChuyenXe.Enabled = check;
            btnPhuongTien.Enabled = check;
            btnNhanVien.Enabled = check;
        }
        void QuyenNhanVienKeToan(bool check)
        {
            btnChuyenXe.Enabled = check;
            btnPhuongTien.Enabled = check;
            btnNhanVien.Enabled = check;
            btnVeXe.Enabled = check;
            btnDatVe.Enabled = check;
            btnKhachHang.Enabled = check;
        }

        public FormMain(TaiKhoan_DTO login_acc)
        {
            InitializeComponent();
            if (login_acc.Quyen == "Admin") { 
                labelTenNguoiDung.Text = acc.UserName;
                acc = login_acc;
            }
            else
            {
                nv = bul_nv.getNhanVien(login_acc.ID);
                //Kiểm tra quyền hiển thị hệ thống
                if(nv.MaChucVu == 1 || nv.MaChucVu == 2)
                {
                    acc = login_acc;
                    labelTenNguoiDung.Text = nv.HoTen;
                }
                else if (nv.MaChucVu == 3)
                {
                    acc = login_acc;
                    labelTenNguoiDung.Text = nv.HoTen;
                    QuyenNhanVienDatVe(false);
                }
                else
                {
                    acc = login_acc;
                    labelTenNguoiDung.Text = nv.HoTen;
                    QuyenNhanVienKeToan(false);
                }
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
            AddControls(new FormThongTinKhachHang(nv));
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

            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new FormDatVeXe());
        }
    }
}
