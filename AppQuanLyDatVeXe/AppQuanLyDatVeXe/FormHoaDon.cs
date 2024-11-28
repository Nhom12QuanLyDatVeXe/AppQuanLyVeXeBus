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

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTHD cthd=new FormCTHD();
            cthd.ShowDialog();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        HoaDon_BUL HD_BUL = new HoaDon_BUL();
        public void LoadHD()
        {
            dgvDSHD.DataSource = null;
            dgvDSHD.DataSource = HD_BUL.GetHoaDon();
        }
    }
}
