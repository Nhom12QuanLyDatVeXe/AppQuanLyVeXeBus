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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
            dgvDSHD.AutoGenerateColumns = false;
        }

        HoaDon_BUL HD_BUL = new HoaDon_BUL();
        public void LoadHD()
        {
            dgvDSHD.DataSource = null;
            dgvDSHD.DataSource = HD_BUL.GetHoaDon();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = null;
            dgvDSHD.DataSource = HD_BUL.GetHoaDon(txtTimKiem.Text);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
