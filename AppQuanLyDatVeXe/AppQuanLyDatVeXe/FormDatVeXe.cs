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
    public partial class FormDatVeXe : Form
    {
        TuyenXe_BUL CX_BUL = new TuyenXe_BUL();
        public FormDatVeXe()
        {
            InitializeComponent();
        }

        private void FormDatVeXe_Load(object sender, EventArgs e)
        {
            LoadCX();
        }

        public void LoadCX()
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe();
        }

        private void dgvDSTX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSTX.Columns[e.ColumnIndex].Name == "ThoiGianDi" && e.Value is DateTime dateTime)
            {
                e.Value = dateTime.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }
    }
}
