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
using DTO;
using BUL;

namespace AppQuanLyDatVeXe.FormChiTiet
{
    public partial class FormCTCX : Sample
    {
        public FormCTCX()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTCX_Load(object sender, EventArgs e)
        {
            dtpGioDi.Format = DateTimePickerFormat.Time;
            dtpGioDi.ShowUpDown = true;
            DateTime myDate = dtpNgayDi.Value.Date +
                    dtpGioDi.Value.TimeOfDay;
        }

<<<<<<< HEAD
        TuyenXe_BUL bul = new TuyenXe_BUL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                int maTx =int.Parse( txtMaChuyen.Text.Trim());
                string tenTuyen = txtTenChuyen.Text.Trim();
                string diemDi =cboDiemDen.SelectedItem?.ToString();
                string diemDen = cboDiemDen.SelectedItem?.ToString();
                DateTime ngayDi = dtpNgayDi.Value;
                TimeSpan gioxuatBen = dtpGioDi.Value.TimeOfDay;
                int khoangcach = int.Parse(txtKhoangcach.Text.Trim());
                decimal donGia = decimal.Parse(txtDonGia.Text.Trim());
                string biensoxe = txtBienso.Text.Trim();
                




                if (string.IsNullOrEmpty(tenTuyen))
                {
                    MessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                TuyenXe_DTO tx = new TuyenXe_DTO
                {
                    MaTuyenXe = maTx,
                    TenTuyen = tenTuyen,
                    DiemDi = diemDi,
                    DiemDen = diemDen,
                    ThoiGianDi = ngayDi,
                    GioXuatBen = gioxuatBen,
                    KhoangCach = khoangcach,
                    DonGia = donGia,
                    BienSoXe = biensoxe,
                };


                if (bul.ThemTX(tx))
                {
                    MessageBox.Show("Thêm thông tin tuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin tuyến xe thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
=======
        private void btnLuu_Click(object sender, EventArgs e)
        {
            TuyenXe_DTO tx = new TuyenXe_DTO();
            tx.MaTuyenXe = int.Parse(txtMaChuyen.Text);
            tx.TenTuyen = txtTenChuyen.Text;
>>>>>>> main
        }
    }
}
