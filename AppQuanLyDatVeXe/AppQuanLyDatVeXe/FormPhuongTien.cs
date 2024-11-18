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
    public partial class FormPhuongTien : Form
    {
        public FormPhuongTien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTPT ctpt=new FormCTPT();
            ctpt.ShowDialog();
        }

        PhuongTien_BUL PT_BUL = new PhuongTien_BUL();
        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
            loadPT();
        }

        public void loadPT()
        {
            dgvDSPT.DataSource = null;
            dgvDSPT.DataSource = PT_BUL.GetPhuongTien();
        }
    }
}
