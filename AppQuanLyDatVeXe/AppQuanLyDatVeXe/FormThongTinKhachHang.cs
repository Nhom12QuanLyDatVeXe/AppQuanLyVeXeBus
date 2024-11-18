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
    public partial class FormThongTinKhachHang : Form
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTKH ctkh= new FormCTKH();
            ctkh.ShowDialog();
        }

        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        KhachHang_BUL KH_BUL = new KhachHang_BUL();
        public void LoadKH()
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = KH_BUL.GetKhachHang();
        }
    }
}
