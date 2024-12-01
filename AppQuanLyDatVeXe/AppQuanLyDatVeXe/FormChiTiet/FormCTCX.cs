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

        TuyenXe_BUL bul = new TuyenXe_BUL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string maTx = txtMaChuyen.Text.Trim();
                string tenTuyen = txtTenChuyen.Text.Trim();
                int diemDi =int.Parse( cboDiemDen.SelectedItem?.ToString());
                int diemDen = int.Parse(cboDiemDen.SelectedItem?.ToString());
                DateTime ngayDi = dtpNgayDi.Value;
                DateTime gioxuatBen= dtpGioDi.Value;

                




                if (string.IsNullOrEmpty(tenTuyen))
                {
                    MessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                TuyenXe_DTO tx = new TuyenXe_DTO
                {

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
        }
    }
}
