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
using DTO;
namespace AppQuanLyDatVeXe
{
    public partial class FormThongTinKhachHang : Form
    {
        NhanVien_DTO nv = new NhanVien_DTO();
        public FormThongTinKhachHang(NhanVien_DTO nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormCTKH ctkh= new FormCTKH();
            ctkh.ShowDialog();
        }

        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
            dgvDSKH.AutoGenerateColumns = false;
        }

        KhachHang_BUL KH_BUL = new KhachHang_BUL();
        public void LoadKH()
        {
            dgvDSKH.DataSource = null;
            dgvDSKH.DataSource = KH_BUL.GetKhachHang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSKH.DataSource = null;
            dgvDSKH.DataSource = KH_BUL.GetKhachHang1(txtTimKiem.Text);
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDSKH.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                if(nv.MaChucVu != 1 && nv.MaChucVu != 2)
                {
                    MessageBox.Show("Nhân viên không có quyền xóa khách hàng!");
                }    
            }
        }
    }
}
