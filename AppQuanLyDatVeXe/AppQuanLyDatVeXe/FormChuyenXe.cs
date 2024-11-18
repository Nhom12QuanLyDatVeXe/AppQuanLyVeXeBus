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
using DTO;
using BUL;

namespace AppQuanLyDatVeXe
{
    public partial class FormChuyenXe : Form
    {

        TuyenXe_BUL CX_BUL = new TuyenXe_BUL();
        public FormChuyenXe()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTCX ctcx=new FormCTCX();
            ctcx.ShowDialog();
        }

        private void FormChuyenXe_Load(object sender, EventArgs e)
        {
            LoadCX();
        }
        public void LoadCX()
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = CX_BUL.GetTuyenXe();
        }
    }
}
