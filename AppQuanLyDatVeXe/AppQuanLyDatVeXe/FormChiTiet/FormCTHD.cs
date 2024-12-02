﻿using System;
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
    public partial class FormCTHD : Sample
    {
        public FormCTHD()
        {
            InitializeComponent();
        }
        HoaDon_BUL bUL = new HoaDon_BUL();
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                int sohd = int.Parse(txtSoHD.Text);
                string maPhieu = txtMaPhieu.Text.Trim();
                decimal thanhTien = decimal.Parse(txtThanhTien.Text);
                string trangThai = cboTrangThai.SelectedItem?.ToString();
                string phuongThucTT = cboPhuongThuc.SelectedItem?.ToString();
                string maNV = txtMaNV.Text.Trim();




                HoaDon_DTO hoadon = new HoaDon_DTO
                {
                    SoHD = sohd,
                    MaPhieu = maPhieu,
                    ThanhTien = thanhTien,
                    TrangThai = trangThai,
                    PhuongThucThanhToan = phuongThucTT,
                    MaNV = maNV,
                };


                if (bUL.ThemHoaDon(hoadon))
                {
                    MessageBox.Show("Thêm thông tin hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đã thanh toán");
            cboTrangThai.Items.Add("Chưa thanh toán");

            cboPhuongThuc.Items.Clear();
            cboPhuongThuc.Items.Add("Tiền mặt");
            cboPhuongThuc.Items.Add("Chuyển khoản");
        }
    }
}
