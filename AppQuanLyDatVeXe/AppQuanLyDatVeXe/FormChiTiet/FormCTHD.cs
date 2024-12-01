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

namespace AppQuanLyDatVeXe
{
    public partial class FormCTHD : Sample
    {
        HoaDon_BUL bUL = new HoaDon_BUL();
        public FormCTHD()
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

                int sohd = int.Parse(txtSoHD.Text);
                string maPhieu = txtMaPhieu.Text.Trim();
                decimal thanhTien = decimal.Parse(txtThanhTien.Text);
                string trangThai = cboTrangThai.SelectedItem?.ToString();
                string phuongThucTT = cboPhuongThuc.SelectedItem?.ToString();
                string maNV = txtMaNV.Text.Trim();




                HoaDon_DTO hoadon = new HoaDon_DTO
                {
                    SoHD = sohd,
                    MaPhieu = maPhieu,
                    ThanhTien = thanhTien,
                    TrangThai = trangThai,
                    PhuongThucThanhToan = phuongThucTT,
                    MaNV = maNV,
                };


                if (bUL.ThemHoaDon(hoadon))
                {
                    MessageBox.Show("Thêm thông tin hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
