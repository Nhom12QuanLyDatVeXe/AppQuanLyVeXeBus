
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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }


        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();   
        }
        
        NhanVien_BUL NV_BUL = new NhanVien_BUL();
        public void LoadNV()
        {
            
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = NV_BUL.GetNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTNV ctnv=new FormCTNV();
            ctnv.ShowDialog();
        }

        private void dgvDSNV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDSNV.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
