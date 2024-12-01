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
        TinhThanh_BUL bul_tinhthanh = new TinhThanh_BUL();
        public FormDatVeXe()
        {
            InitializeComponent();
        }

        private void FormDatVeXe_Load(object sender, EventArgs e)
        {
            LoadCX();
            loadDiemDi_den();
            cboDiemDen.DropDownStyle = ComboBoxStyle.DropDown;
            cboDiemDi.DropDownStyle = ComboBoxStyle.DropDown;
        }

        public void LoadCX()
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe();
        }
        void loadDiemDi_den()
        {
            cboDiemDi.DataSource = bul_tinhthanh.getAll();
            cboDiemDi.DisplayMember = "TenTinh";
            cboDiemDi.ValueMember = "MaTinh";


            cboDiemDen.DataSource = bul_tinhthanh.getAll();
            cboDiemDen.DisplayMember = "TenTinh";
            cboDiemDen.ValueMember = "MaTinh";

        }
        private void dgvDSTX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSTX.Columns[e.ColumnIndex].Name == "ThoiGianDi" && e.Value is DateTime dateTime)
            {
                e.Value = dateTime.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void cboDiemDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
        public void LoadCX(string diemdi, string diemden, DateTime ngaydi)
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe(diemdi, diemden, ngaydi);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboDiemDi.SelectedIndex < 0 || cboDiemDen.SelectedIndex < 0)
            { return; }    
            LoadCX(cboDiemDi.SelectedValue.ToString(), cboDiemDen.SelectedValue.ToString(), dtpNgayDi.Value);
        }
    }
}
