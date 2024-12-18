﻿using AppQuanLyDatVeXe.FormChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Windows.Forms;
using BUL;
using DTO;
using Microsoft.Office.Interop.Word;

using Word = Microsoft.Office.Interop.Word;
using WordApplication = Microsoft.Office.Interop.Word.Application;
using WinFormsApplication = System.Windows.Forms.Application;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System.Globalization;



namespace AppQuanLyDatVeXe
{
    public partial class FormVeXe : Form
    {
        NhanVien_DTO nhanvien = new NhanVien_DTO();
        public FormVeXe(NhanVien_DTO nv)
        {
            nhanvien = nv;
            InitializeComponent();
            dgvCTPDV.Columns["dg"].DefaultCellStyle.Format = "0";
        }


        private void FormVeXe_Load(object sender, EventArgs e)
        {
            LoadPDV();
            dgvCTPDV.AutoGenerateColumns = false;
            dgvDSVX.AutoGenerateColumns = false;
        }

        PhieuDatVe_BUL PDV_BUL = new PhieuDatVe_BUL();
        HoaDon_BUL hd_bul = new HoaDon_BUL();
        TuyenXe_BUL tx_bul = new TuyenXe_BUL();
        public void LoadPDV()
        {
            dgvDSVX.DataSource = null;
            dgvDSVX.DataSource = PDV_BUL.GetPhieuDatVe();
        }

        void loadCTPDV( string maPhieu)
        {
            dgvCTPDV.DataSource = null;
            dgvCTPDV.DataSource = PDV_BUL.getCTPDV(maPhieu);
        }
        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSVX.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSVX.Rows[e.RowIndex];
                string maphieu = row.Cells["MaPhieu"].Value.ToString();
                loadCTPDV(maphieu);
                
                int matuyenxe = PDV_BUL.get1CTPDV(maphieu);
                string tenKH = PDV_BUL.getTenKH(maphieu);
                TuyenXe_DTO tuyenxe = tx_bul.Get1TuyenXe(matuyenxe);

                if(tuyenxe != null)
                {
                    lbTuyenXe.Text = "Tuyến xe: " + tuyenxe.TenTuyen;
                    lbNgayDi.Text = "Ngày đi: " + tuyenxe.ThoiGianDi.ToString("dd/MM/yyyy");
                    lbGioXuatBen.Text = "Giờ xuất bến: " + tuyenxe.GioXuatBen;
                    lbBienSoXe.Text = "Biển số xe: " + tuyenxe.BienSoXe;
                    lbKH.Text = "Khách hàng: " + tenKH;
                }
                else
                {
                    lbTuyenXe.Text = "Tuyến xe: ";
                    lbNgayDi.Text = "Ngày đi: ";
                    lbGioXuatBen.Text = "Giờ xuất bến: ";
                    lbBienSoXe.Text = "Biển số xe: ";
                    lbKH.Text = "Khách hàng: ";
                }
                
                if (e.ColumnIndex == dgvDSVX.Columns["btnThanhToan"].Index && e.RowIndex >= 0)
                {
                    DateTime currentDate = DateTime.Now;
                    HoaDon_DTO hoadon = new HoaDon_DTO();
                    var selectedRow = dgvDSVX.Rows[e.RowIndex]; //Dữ liệu dòng đã nhấn
                    hoadon.SoHD = int.Parse(currentDate.ToString("ddMMyyHHmm"));
                    hoadon.MaPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    hoadon.ThanhTien = decimal.Parse(selectedRow.Cells["TongTien"].Value.ToString());
                    hoadon.MaNV = nhanvien.MaNV;
                    hoadon.TrangThai = "Đã thanh toán";
                    hoadon.PhuongThucThanhToan = "Tiền mặt";
                    if (hd_bul.ThemHoaDon(hoadon) == true)
                    {
                        MessageBox.Show("Thanh toán hóa đơn " + hoadon.SoHD + " thành công!");
                        LoadPDV();
                        dgvCTPDV.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thanh toán!");
                    }
                }

                if (e.ColumnIndex == dgvDSVX.Columns["btnHuy"].Index && e.RowIndex >= 0)
                {
                    var selectedRow = dgvDSVX.Rows[e.RowIndex]; //Dữ liệu dòng đã nhấn
                    string maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    if (PDV_BUL.checkDieuKienHuy(maPhieu) == 1) // Đã thanh toán và cách thời gian đi trên 12 tiếng
                    {
                        if(PDV_BUL.huyVe(maphieu,0,nhanvien.MaNV))
                        {
                            MessageBox.Show("Hủy vé thành công!");
                            LoadPDV();
                            dgvCTPDV.DataSource = null;
                        }    
                    }
                    else if (PDV_BUL.checkDieuKienHuy(maPhieu) == 0) // Đã thanh toán nhưng các thời gian đi dưới 12 tiếng
                    {
                        //Xử lí trường hợp hủy vé đã thanh toán, tính phí 20% hóa đơn
                        decimal phiHuyVe = PDV_BUL.tinhPhiHuyVe(maPhieu);

                        DialogResult result = MessageBox.Show(
                            "Phí hủy vé là " + phiHuyVe.ToString("N0") + " VNĐ. Bạn có chắc chắn muốn hủy không?",
                            "Xác nhận hủy vé",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning
                        );

                        // Xử lý kết quả từ hộp thoại
                        if (result == DialogResult.OK)
                        {
                            // Người dùng nhấn OK, thực hiện hủy vé
                            if (PDV_BUL.huyVe(maPhieu, phiHuyVe, nhanvien.MaNV))
                            {
                                MessageBox.Show("Hủy vé thành công!", "Thông báo");
                                LoadPDV();
                                dgvCTPDV.DataSource = null;
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra khi hủy vé!", "Thông báo");
                            }
                        }
                        else
                        {
                            // Người dùng nhấn Cancel, bỏ qua hủy vé
                            MessageBox.Show("Hủy vé đã được hủy bỏ.", "Thông báo");
                        }
                    }
                    else if(PDV_BUL.checkDieuKienHuy(maPhieu) == 2) //chưa thanh toán
                    {
                        if(PDV_BUL.deleteOne(maphieu) == 1)
                        {
                            MessageBox.Show("Hủy vé " + maPhieu + " thành công!");
                            LoadPDV();
                            dgvCTPDV.DataSource = null;
                        }
                        else
                        { MessageBox.Show("Không thể xóa phiếu đặt vé này!"); }
                            
                    } 
                    else
                    {
                        MessageBox.Show("Tuyến xe này đã chạy! Không thể hủy vé này nữa!");
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSVX.DataSource = null;
            dgvDSVX.DataSource = PDV_BUL.GetPhieuDatVe(txtTimKiem.Text);

        }

        private void ReplaceFieldValue(Microsoft.Office.Interop.Word.Document wordDoc, string fieldName, string fieldValue)
        {
            foreach (Microsoft.Office.Interop.Word.Field field in wordDoc.Fields)
            {
                if (field.Code.Text.Contains(fieldName))
                {
                    field.Result.Text = fieldValue;
                }
            }
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            try
            {
               
                string templateFolder = Path.Combine(System.Windows.Forms.Application.StartupPath, "Template");
                string saveFolder = Path.Combine(System.Windows.Forms.Application.StartupPath, "PhieuDatVe");
                string templatePath = Path.Combine(templateFolder, "MauVeXe.dotx");

                if (!Directory.Exists(templateFolder))
                    Directory.CreateDirectory(templateFolder);

                if (!Directory.Exists(saveFolder))
                    Directory.CreateDirectory(saveFolder);

                if (!File.Exists(templatePath))
                {
                    MessageBox.Show($"Không tìm thấy file mẫu tại: {templatePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

               
                foreach (DataGridViewRow row in dgvCTPDV.Rows)
                {
                    // Lấy thông tin từ dòng hiện tại
                    string maPhieu = row.Cells["mp"].Value?.ToString() ?? "";
                    string maGhe = row.Cells["mg"].Value?.ToString() ?? "";
                    string donGiaStr = row.Cells["dg"].Value?.ToString() ?? "0";
                    decimal donGia = decimal.TryParse(donGiaStr, out decimal parsedDonGia) ? parsedDonGia : 0;

                 
                    Document wordDoc = wordApp.Documents.Add(templatePath);

              
                    string tuyenXe = lbTuyenXe.Text;
                    string bienSoXe = lbBienSoXe.Text;
                    string ngayDi = lbNgayDi.Text;
                    string gioXuatBen = lbGioXuatBen.Text;
                    string khachHang = lbKH.Text;

                  
                    ReplaceFieldValue(wordDoc, "TuyenXe", tuyenXe);
                    ReplaceFieldValue(wordDoc, "BienSoXe", bienSoXe);
                    ReplaceFieldValue(wordDoc, "NgayDi", ngayDi);
                    ReplaceFieldValue(wordDoc, "GioXuatBen", gioXuatBen);
                    ReplaceFieldValue(wordDoc, "KhachHang", khachHang);
                    ReplaceFieldValue(wordDoc, "MaPhieu", maPhieu);
                    ReplaceFieldValue(wordDoc, "MaGhe", maGhe);
                    ReplaceFieldValue(wordDoc, "DonGia", donGia.ToString("C0"));

                   
                    string savePath = Path.Combine(saveFolder, $"PhieuDatVe_{maPhieu}_{maGhe}_{DateTime.Now:yyyyMMdd_HHmmss}.docx");
                    wordDoc.SaveAs2(savePath);

                   
                    wordDoc.Close();
                }

                MessageBox.Show($"Xuất thông tin vé xe thành công! Các file đã được lưu tại: {saveFolder}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
     }
}
