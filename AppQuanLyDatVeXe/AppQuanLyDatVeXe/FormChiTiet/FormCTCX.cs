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
            dtpGioDi.CustomFormat = "HH:mm";
            dtpNgayDi.MinDate = DateTime.Today;
            dtpGioDi.Value = DateTime.Now;
            dtpGioDi.Format = DateTimePickerFormat.Time;
            dtpGioDi.ShowUpDown = true;
            DateTime myDate = dtpNgayDi.Value.Date +
                    dtpGioDi.Value.TimeOfDay;
            ///
            cboDiemDen.Items.Clear();
            loadDiemDen();
            ///
            cboDiemDi.Items.Clear();
            loadDiemDi();
            ///

            cbBienSoXe.Items.Clear();
            loadBienXe();
        }


        TinhThanh_BUL tt_bul = new TinhThanh_BUL();
        public void loadDiemDen()
        {
            cboDiemDen.DataSource = tt_bul.getAll1();
            cboDiemDen.DisplayMember = "TenTinh";
            cboDiemDen.ValueMember = "MaTinh";
        }

        public void loadDiemDi()
        {
            cboDiemDi.DataSource = tt_bul.getAll1();
            cboDiemDi.DisplayMember = "TenTinh";
            cboDiemDi.ValueMember = "MaTinh";
        }

        public void loadBienXe()
        {
            PhuongTien_BUL pt = new PhuongTien_BUL();
            cbBienSoXe.DataSource = pt.GetPhuongTien();
            cbBienSoXe.DisplayMember = "BienSoXe";
            cbBienSoXe.ValueMember = "BienSoXe";
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                //int maTx = int.Parse(txtMaChuyen.Text.Trim());
                string tenTuyen = txtTenChuyen.Text.Trim();
                string diemDi = cboDiemDi.SelectedValue?.ToString();
                string diemDen = cboDiemDen.SelectedValue?.ToString();
                DateTime ngayDi = dtpNgayDi.Value.Date;
                TimeSpan gioxuatBen = dtpGioDi.Value.TimeOfDay;
                int khoangcach = int.Parse(txtKhoangcach.Text.Trim());
                decimal donGia = decimal.Parse(txtDonGia.Text.Trim());
                string biensoxe = cbBienSoXe.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(tenTuyen))
                {
                    MessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TimeSpan gioDenNoi = TinhThoiGianDenNoi();

                if (gioDenNoi == TimeSpan.Zero)
                {
                   
                    return;
                }

                //if(dtpGioDi.Value.TimeOfDay <= now.TimeOfDay)
                //{
                //    MessageBox.Show("Thời gian đi xát hiện tại! Không thể thêm chuyến xe!");
                //    return;
                //}

                TuyenXe_DTO tx = new TuyenXe_DTO
                {
                    //MaTuyenXe = maTx,
                    TenTuyen = tenTuyen,
                    DiemDi = diemDi,
                    DiemDen = diemDen,
                    ThoiGianDi = ngayDi,
                    GioDenNoi = gioDenNoi,
                    GioXuatBen = gioxuatBen,
                    KhoangCach = khoangcach,
                    DonGia = donGia,
                    BienSoXe = biensoxe,
                };
                if (bul.ThemTX(tx))
                {
                    MessageBox.Show("Thêm thông tin tuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var parentForm = this.Owner as FormChuyenXe;
                    parentForm?.LoadCX();
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

        private TimeSpan TinhThoiGianDenNoi()
        {
            try
            {

                TimeSpan gioKhoiHanh = dtpGioDi.Value.TimeOfDay;
                if (!int.TryParse(txtKhoangcach.Text.Trim(), out int khoangCach))
                {
                    throw new Exception("Khoảng cách phải là số nguyên hợp lệ.");
                }

                double vanTocTrungBinh = 60.0; // km/h
                double gioNghi = 1;

                double thoiGianDiChuyen = khoangCach / vanTocTrungBinh + gioNghi;
                DateTime thoiGianKhoiHanh = DateTime.Today.Add(gioKhoiHanh);
                DateTime thoiGianDenNoi = thoiGianKhoiHanh.AddHours(thoiGianDiChuyen);

                if (thoiGianDenNoi.TimeOfDay.TotalHours >= 24)
                {

                    thoiGianDenNoi = thoiGianDenNoi.AddDays(-1);
                }

                return thoiGianDenNoi.TimeOfDay;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tính thời gian đến nơi: {ex.Message}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return TimeSpan.Zero;
            }
        }

        private void dtpNgayDi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayDi.Value.Date > DateTime.Today)
            {
                // Nếu chọn ngày tương lai, không cần kiểm tra giờ
                dtpGioDi.Value = new DateTime(dtpNgayDi.Value.Year, dtpNgayDi.Value.Month, dtpNgayDi.Value.Day, 0, 0, 0);
            }
            else
            {
                // Nếu là ngày hiện tại, cập nhật giờ
                dtpGioDi_ValueChanged(sender, e);
            }
        }

        private void dtpGioDi_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
