﻿using AppQuanLyDatVeXe.FormChiTiet;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSTX.DataSource = null;
            dgvDSTX.DataSource = CX_BUL.GetTuyenXe(txtTimKiem.Text);
        }

        private void dgvDSTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDSTX.Columns["btnSua"].Index && e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow row = dgvDSTX.Rows[e.RowIndex];
                    TuyenXe_DTO txe = new TuyenXe_DTO
                    {
                        MaTuyenXe = Convert.ToInt32(row.Cells["MaTuyenXe"].Value),
                        TenTuyen = row.Cells["tenTuyen"].Value.ToString(),
                        ThoiGianDi = Convert.ToDateTime(row.Cells["thoiGianDi"].Value),
                        DiemDi = row.Cells["diemDi"].Value.ToString(),
                        DiemDen = row.Cells["diemDen"].Value.ToString(),
                        GioXuatBen = Convert.ToDateTime(row.Cells["gioXuatBen"].Value).TimeOfDay,
                        GioDenNoi = Convert.ToDateTime(row.Cells["gioDenNoi"].Value).TimeOfDay,
                        KhoangCach = Convert.ToInt32(row.Cells["khoangCach"].Value),
                        DonGia = Convert.ToInt32(row.Cells["donGia"].Value),
                        BienSoXe = row.Cells["bienSoXe"].Value.ToString(),
                    };
                    bool result = CX_BUL.SuaTX(txe);
                    if(result)
                    {
                        MessageBox.Show("Cập nhật sửa tuyến xe thành công");
                        LoadCX();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phương tiện thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }
    }
}
