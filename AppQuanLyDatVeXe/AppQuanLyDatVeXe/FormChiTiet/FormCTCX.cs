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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TuyenXe_DTO tx = new TuyenXe_DTO();
            tx.MaTuyenXe = int.Parse(txtMaChuyen.Text);
            tx.TenTuyen = txtTenChuyen.Text;

        }
    }
}
