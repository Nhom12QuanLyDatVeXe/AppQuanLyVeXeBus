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
                int machucVu;
                decimal luong;

                
                if (!int.TryParse(cboChucVu.SelectedItem?.ToString(), out machucVu))
                {
                    MessageBox.Show("Vui lòng chọn chức vụ hợp lệ.");
                    return;
                }

                if (!decimal.TryParse(txtLuong.Text.Trim(), out luong))
                {
                    MessageBox.Show("Vui lòng nhập lương hợp lệ.");
                    return;
                }
               
                if (!int.TryParse(cboChucVu.SelectedItem?.ToString(), out machucVu))
                {
                    MessageBox.Show("Vui lòng chọn chức vụ hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string trangThai = cboTrangThai.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(trangThai))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtLuong.Text.Trim(), out luong))
                {
                    MessageBox.Show("Lương không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gioiTinh = cboGioiTinh.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(gioiTinh))
                {
                    MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NhanVien_DTO nhanvien = new NhanVien_DTO
                {
                    MaNV = maNV,
                    HoTen = hoTen,
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                    CCCD = txtCCCD.Text.Trim(),
                    SDT = sdt,
                    Luong = luong,
                    TrangThai = cboTrangThai.SelectedItem?.ToString(),
                    MaChucVu = machucVu,
                };

                if (bul.ThemNV(nhanvien))
                {
                    MessageBox.Show("Thêm thông tin nhân viên thành công.", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin nhân viên thất bại.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }


        private void FormCTNV_Load(object sender, EventArgs e)
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.Add("1");
            cboChucVu.Items.Add("2");
            cboChucVu.Items.Add("3");


            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Nghỉ việc");
            ;
        }
    }
}
