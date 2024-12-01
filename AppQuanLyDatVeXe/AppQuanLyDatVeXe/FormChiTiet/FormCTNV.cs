using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDatVeXe.FormChiTiet
{
    public partial class FormCTNV : Sample
    {
        NhanVien_BUL bul = new NhanVien_BUL();
        public FormCTNV()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string maNV = txtMaNV.Text.Trim();
                string hoTen = txtTenNV.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                int machucVu =int.Parse( cboChucVu.SelectedItem?.ToString());
                string trangThai = cboTrangThai.SelectedItem?.ToString();   
                string gioiTinh = cboGioiTinh.SelectedItem?.ToString();
                string cccd = txtCCCD.Text.Trim();
                decimal luong = decimal.Parse(txtLuong.Text.Trim());
                DateTime ngaysinh = dtpNgaySinh.Value;


                if (string.IsNullOrEmpty(hoTen))
                {
                    MessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(sdt) || sdt.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                NhanVien_DTO nhanvien = new NhanVien_DTO
                {
                        MaNV = maNV,
                        HoTen = hoTen,
                        NgaySinh = ngaysinh,
                        GioiTinh=gioiTinh,
                        CCCD = cccd,
                        SDT = sdt,
                        Luong = luong,
                        TrangThai = trangThai,
                        MaChucVu = machucVu,
                };


                if (bul.ThemNV(nhanvien))
                {
                    MessageBox.Show("Thêm thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
