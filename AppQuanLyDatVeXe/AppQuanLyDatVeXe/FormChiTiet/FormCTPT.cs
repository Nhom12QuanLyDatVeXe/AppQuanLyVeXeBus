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
    public partial class FormCTPT : Sample
    {
        public FormCTPT()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PhuongTien_BUL bul = new PhuongTien_BUL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string biensoxe = txtBienSoXe.Text.Trim();
                string taixechinh = txtTaiXeChinh.Text.Trim();
                string taixephu = txtTaiXePhu.Text.Trim();
                int soghe = int.Parse(txtSLGhe.Text);


                if (string.IsNullOrEmpty(taixechinh))
                {
                    MessageBox.Show("Tài xế chính không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(taixephu))
                {
                    MessageBox.Show("Tài xế phụ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                PhuongTien_DTO phuongTien = new PhuongTien_DTO
                {
                    BienSoXe = biensoxe,
                    TaiXeChinh = taixechinh,
                    TaiXephu = taixephu,
                    SoGhe = soghe,
                };


                if (bul.ThemPT(phuongTien))
                {
                    MessageBox.Show("Thêm phương tiện thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var parentForm = this.Owner as FormPhuongTien;
                    parentForm?.loadPT();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phương tiện thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
