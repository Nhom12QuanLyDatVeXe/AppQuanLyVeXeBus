﻿using System;
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

namespace AppQuanLyDatVeXe.FormChiTiet
{
    public partial class FormCTCX : Sample
    {
        public FormCTCX()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TuyenXe_BUL bul = new TuyenXe_BUL();
        private void FormCTCX_Load(object sender, EventArgs e)
        {
            dtpGioDi.Format = DateTimePickerFormat.Time;
            dtpGioDi.ShowUpDown = true;
            DateTime myDate = dtpNgayDi.Value.Date +
                    dtpGioDi.Value.TimeOfDay;
            ///
            cboDiemDen.Items.Clear();
            cboDiemDen.Items.Add("77");
            cboDiemDen.Items.Add("39");
            cboDiemDen.Items.Add("50");
            cboDiemDen.Items.Add("80");
            ///
            cboDiemDi.Items.Clear();
            cboDiemDi.Items.Add("79");
            ///

            cbBienSoXe.Items.Clear();
            cbBienSoXe.Items.Add("51B-67890");
            cbBienSoXe.Items.Add("51B-12345");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int maTx = int.Parse(txtMaChuyen.Text.Trim());
                string tenTuyen = txtTenChuyen.Text.Trim();
                string diemDi = cboDiemDen.SelectedItem?.ToString();
                string diemDen = cboDiemDen.SelectedItem?.ToString();
                DateTime ngayDi = dtpNgayDi.Value.Date;
                TimeSpan gioxuatBen = dtpGioDi.Value.TimeOfDay;
                int khoangcach = int.Parse(txtKhoangcach.Text.Trim());
                decimal donGia = decimal.Parse(txtDonGia.Text.Trim());
                string biensoxe = cbBienSoXe.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(tenTuyen))
                {
                    MessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TuyenXe_DTO tx = new TuyenXe_DTO
                {
                    MaTuyenXe = maTx,
                    TenTuyen = tenTuyen,
                    DiemDi = diemDi,
                    DiemDen = diemDen,
                    ThoiGianDi = ngayDi,
                    GioXuatBen = gioxuatBen,
                    KhoangCach = khoangcach,
                    DonGia = donGia,
                    BienSoXe = biensoxe,
                };
                if (bul.ThemTX(tx))
                {
                    MessageBox.Show("Thêm thông tin tuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin tuyến xe thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
