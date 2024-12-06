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
            dgvDSTX.AutoGenerateColumns = false;
            LoadCX();

            dgvDSTX.Columns["DonGia"].DefaultCellStyle.Format = "0";
            dgvDSTX.Columns["GioXuatBen"].DefaultCellStyle.Format = @"hh\:mm\:ss";
            dgvDSTX.Columns["GioDenNoi"].DefaultCellStyle.Format = @"hh\:mm\:ss";
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
            if (dgvDSTX.Columns[e.ColumnIndex].Name == "GioXuatBen" || dgvDSTX.Columns[e.ColumnIndex].Name == "GioDenNoi")
            {
                if (e.Value is TimeSpan time)
            
                    
                    e.Value = time.ToString(@"hh\:mm\:ss");
                    e.FormattingApplied = true; 
               
            }

            if (dgvDSTX.Columns[e.ColumnIndex].Name == "GioDenNoi" && e.Value is TimeSpan)
            {
                TimeSpan timeSpan = (TimeSpan)e.Value;
               
                e.Value = timeSpan.ToString(@"hh\:mm\:ss");
                e.FormattingApplied = true;
            }

            if (dgvDSTX.Columns[e.ColumnIndex].Name == "DonGia")
            {
                if (e.Value is decimal donGia)
                {
                  
                    e.Value = donGia.ToString("0");  
                    e.FormattingApplied = true; 
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe(txtTimKiem.Text);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
