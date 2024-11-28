using AppQuanLyDatVeXe.FormChiTiet;
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

namespace AppQuanLyDatVeXe
{
    public partial class FormVeXe : Form
    {
        public FormVeXe()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTVX ctvx=  new FormCTVX();
            ctvx.ShowDialog();
        }

        private void FormVeXe_Load(object sender, EventArgs e)
        {
            LoadPDV();
        }

        PhieuDatVe_BUL PDV_BUL = new PhieuDatVe_BUL();
       
        public void LoadPDV()
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = PDV_BUL.GetPhieuDatVe();
        }
    }
}
