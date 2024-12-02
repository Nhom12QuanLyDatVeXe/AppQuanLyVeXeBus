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
    public partial class FormCTVX : Sample
    {
        public FormCTVX()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PhieuDatVe_BUL bul = new PhieuDatVe_BUL();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string maPhieu = txtMaPhieu.Text.Trim();
                int soghe = int.Parse(txtSLGhe.Text);
                decimal tongtien = decimal.Parse(txtTongTien.Text);
                string makh = txtMaKH.Text.Trim();



                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Mã phiếu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                PhieuDatVe_DTO pdv = new PhieuDatVe_DTO
                {
                    MaPhieu = maPhieu,
                    SoLuongGhe = soghe,
                    TongTien = tongtien,
                    MaKH = makh,


                };


                if (bul.ThemPDV(pdv))
                {
                    MessageBox.Show("Thêm thông tin phiếu đặt vé thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin tin phiếu đặt vé thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCTVX_Load(object sender, EventArgs e)
        {

        }
    }
}
