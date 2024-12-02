using AppQuanLyDatVeXe.FormChiTiet;
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

namespace AppQuanLyDatVeXe
{
    public partial class FormVeXe : Form
    {
        NhanVien_DTO nhanvien = new NhanVien_DTO();
        public FormVeXe(NhanVien_DTO nv)
        {
            nhanvien = nv;
            InitializeComponent();
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
                    lbNgayDi.Text = "Ngày đi: " + tuyenxe.ThoiGianDi;
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

        public void XuatDanhSachHuyTrongTuan()
        {
            // Lấy danh sách phiếu đặt vé đã hủy trong tuần
            DataTable dataTable = PDV_BUL.GetPhieuDatVeDaHuyTrongTuan();

            // Đường dẫn lưu file Excel
            string filePath = @"D:\hufi\Hk1_2024_2025\PTPMUDTM\AppQuanLyVeXeBus-main\AppQuanLyDatVeXe\FileExcel\DanhSachPhieuHuy.xlsx";

            // Gọi hàm xuất Excel
            XuatPhieuDatVeHuyRaExcel(dataTable, filePath);
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            //XuatDanhSachHuyTrongTuan();
        }

        public void XuatPhieuDatVeHuyRaExcel(DataTable dataTable, string filePath)
        {
            // Bật giấy phép không thương mại của EPPlus
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Phiếu Đặt Vé Hủy");

                // Thêm header vào file Excel
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataTable.Columns[col].ColumnName;
                    worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    worksheet.Cells[1, col + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                // Thêm dữ liệu từ DataTable vào Excel
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                    }
                }

                // Tự động điều chỉnh kích thước cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file Excel
                FileInfo fileInfo = new FileInfo(filePath);
                excelPackage.SaveAs(fileInfo);
            }

            Console.WriteLine("Xuất file Excel thành công!");
        }
    }
}
