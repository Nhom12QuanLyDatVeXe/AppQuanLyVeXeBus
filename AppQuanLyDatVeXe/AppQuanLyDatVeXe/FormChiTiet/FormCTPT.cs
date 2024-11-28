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
            PhuongTien_DTO pt = new PhuongTien_DTO();
            pt.BienSoXe = txtBienSoXe.Text;
            pt.TaiXephu = txtTaiXePhu.Text;
            pt.TaiXeChinh = txtTaiXeChinh.Text;
            pt.SoGhe = int.Parse(txtSLGhe.Text);

            if(bul.insert(pt) == 1)
            {
                MessageBox.Show("Thêm thành công!");

                var parentForm = this.Owner as FormPhuongTien;
                parentForm?.loadPT();

                this.Close();
            }
        }
    }
}
