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
            ctpt.Owner = this;
            ctpt.ShowDialog();
        }

        PhuongTien_BUL PT_BUL = new PhuongTien_BUL();
        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
            loadPT();
        }

        public void loadPT()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = PT_BUL.GetPhuongTien();
            dgvDSPT.DataSource = bindingSource;

            //dgvDSPT.DataSource = null;
            //dgvDSPT.DataSource = PT_BUL.GetPhuongTien();

        }

        private void dgvDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                if (dgvDSPT.Columns[e.RowIndex].Name == "ColumnSua")
                {
                    DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];
                    
                }
            }
        }
    }
}
