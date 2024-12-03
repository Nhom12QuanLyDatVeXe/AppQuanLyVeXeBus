
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
using DTO;

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
            dgvDSNV.AutoGenerateColumns = false;
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

<<<<<<< HEAD
        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvDSNV.Columns["btnSua"].Index && e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                    NhanVien_DTO nv = new NhanVien_DTO
                    {
                        MaNV = row.Cells["MaNV"].Value.ToString(),
                        HoTen = row.Cells["HoTen"].Value.ToString(),
                        NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value),
                        GioiTinh = row.Cells["GioiTinh"].Value.ToString(),
                        CCCD = row.Cells["CCCD"].Value.ToString(),
                        SDT = row.Cells["SDT"].Value.ToString(),
                        Luong = Convert.ToDecimal(row.Cells["Luong"].Value),
                        TrangThai = row.Cells["TrangThai"].Value.ToString(),
                        MaChucVu = Convert.ToInt32(row.Cells["MaChucVu"].Value),
                    };
                    bool result = NV_BUL.SuaNV(nv);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công");
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
            else if(e.ColumnIndex == dgvDSNV.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                    DialogResult dialogResult = MessageBox.Show(
                       "Bạn có chắc chắn muốn xóa nhân viên này không?",
                       "Xác nhận xóa",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );

                    if (dialogResult == DialogResult.Yes)
                    {
                        NhanVien_DTO nv = new NhanVien_DTO
                        {
                            MaNV = row.Cells["MaNV"].Value.ToString(),
                        };

                        bool result = NV_BUL.XoaNV(nv);
                        if (result)
                        {
                            MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                            LoadNV(); 
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hủy thao tác xóa.", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
=======
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = NV_BUL.GetNhanVien(txtTimKiem.Text);
>>>>>>> 86d14a05274a6ab402011a7ef63e44d3f63c6c58
        }
    }
}
