using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;

namespace AppQuanLyDatVeXe
{
    public partial class FormCTKH : Sample
    {
        public FormCTKH()
        {
            InitializeComponent();
        }
        KhachHang_BUL KH_BUL = new KhachHang_BUL();

        public virtual void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string maKh = txtMaKH.Text.Trim();
                string hoTen = txtTenKH.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string gioiTinh = cboGioiTinh.SelectedItem?.ToString();


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


                KhachHang_DTO khachHang = new KhachHang_DTO
                {
                    MaKH = maKh,
                    HoTen = hoTen,
                    SDT = sdt,
                    Email = email,
                    GioiTinh = gioiTinh
                };


                if (KH_BUL.ThemKH(khachHang))
                {
                    MessageBox.Show("Thêm thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void  btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
