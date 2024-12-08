using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using System.IO;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DAL
{
    public class PhieuDatVe_DAL
    {

        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();

        public int checkDieuKienHuy(string maPhieu)
        {
            var ctpd = qldvx.ChiTietDatVes.Where(t => t.MaPhieu == maPhieu).FirstOrDefault();
            if (ctpd != null)
            {
                var hoadon = qldvx.HoaDons.Where(h => h.MaPhieu == ctpd.MaPhieu).FirstOrDefault();
                if (hoadon != null) //nếu phiếu đặt đã thanh toán
                {

                    var tuyenxe = qldvx.TuyenXes.Where(m => m.MaTuyenXe == ctpd.MaTuyenXe).FirstOrDefault();
                    if (tuyenxe != null)
                    {
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeDifference = (TimeSpan)(tuyenxe.ThoiGianDi - currentDate);
                        //Xét điều kiện phải hủy cách giờ xuất phát là 12 tiếng
                        if (timeDifference.TotalHours > 12 && tuyenxe.ThoiGianDi > currentDate)
                        {
                            return 1; //Đủ điều kiện hủy
                        }
                        else if (timeDifference.TotalHours < 12 && tuyenxe.ThoiGianDi > currentDate)
                            return 0;
                        else return -1;
                    }
                }
                else
                {
                    return 2; // Phiếu chưa thanh toán
                }
            }
            return 3; //Phiếu không tồn tại 
        }

        public int createOne(int soluongghe, double tongtien, string makh, string matuyen, List<string> danhSachGheDaChon, double dongia)
        {
            try
            {
                DateTime currentDate = DateTime.Now;

                PhieuDatVe phieu = new PhieuDatVe();
                phieu.MaPhieu = currentDate.ToString("ddMMyyHHmm");
                phieu.SoLuongGhe = soluongghe;
                phieu.TongTien = (decimal)tongtien;
                phieu.MaKH = makh;
                phieu.TrangThai = "Đặt chỗ";
                qldvx.PhieuDatVes.InsertOnSubmit(phieu);
                qldvx.SubmitChanges();

                string maphieu = phieu.MaPhieu;
                foreach (string maghe in danhSachGheDaChon)
                {
                    var existingDetail = qldvx.ChiTietDatVes
                                      .FirstOrDefault(ctd => ctd.MaPhieu == maphieu && ctd.MaGhe == maghe);
                    if (existingDetail == null)
                    {
                        ChiTietDatVe ctdv = new ChiTietDatVe();
                        ctdv.MaPhieu = maphieu;
                        ctdv.MaTuyenXe = int.Parse(matuyen);
                        ctdv.MaGhe = maghe;
                        ctdv.DonGia = (decimal)dongia;
                        qldvx.ChiTietDatVes.InsertOnSubmit(ctdv);
                    }
                    else
                    {
                        Console.WriteLine("Chi tiết vé này đã tồn tại.");
                    }
                }

                qldvx.SubmitChanges();

                return 1;

            }
            catch (Exception e)
            { return -1; }

        }

        public int deleteOne(string maphieu)
        {
            try
            {
                var phieu = qldvx.PhieuDatVes.Where(p => p.MaPhieu == maphieu).FirstOrDefault();
                var ctpdv = qldvx.ChiTietDatVes.Where(c => c.MaPhieu == maphieu).ToList();
                if (phieu != null)
                {
                    if (ctpdv != null && ctpdv.Count > 0)
                    {
                        qldvx.ChiTietDatVes.DeleteAllOnSubmit(ctpdv);
                        qldvx.SubmitChanges();

                        qldvx.PhieuDatVes.DeleteOnSubmit(phieu);

                        qldvx.SubmitChanges();
                        return 1;
                    }
                    else
                    {
                        qldvx.PhieuDatVes.DeleteOnSubmit(phieu);

                        qldvx.SubmitChanges();
                        return 1;
                    }
                }
                return 0;
            }
            catch { return -1; }
        }

        public int get1CTPDV(string maPhieu)
        {
            var ctpdv = qldvx.ChiTietDatVes.Where(t => t.MaPhieu == maPhieu).FirstOrDefault();
            if (ctpdv != null)
            {
                return ctpdv.MaTuyenXe;
            }
            return -1;
        }

        public object getCTPDV(string maPhieu)
        {
            var tbl = qldvx.ChiTietDatVes
                           .Where(t => t.MaPhieu == maPhieu)
                           .Select(t => new
                           {
                               t.MaPhieu,
                               t.MaGhe,
                               t.DonGia
                           })
                           .ToList();

            if (tbl != null && tbl.Count > 0)
            {
                return tbl;
            }
            return null;
        }

        public List<string> GetGheDaDat(string matuyen)
        {
            var gheDaDat = qldvx.ChiTietDatVes
                            .Where(c => c.MaTuyenXe == int.Parse(matuyen))
                            .Select(c => c.MaGhe.Trim())
                            .ToList();

            return gheDaDat;
        }

        public List<PhieuDatVe_DTO> GetPhieuDatVe()
        {

            var tbl = from pdv in qldvx.PhieuDatVes
                      select new PhieuDatVe_DTO
                      {
                          MaPhieu = pdv.MaPhieu,
                          SoLuongGhe = pdv.SoLuongGhe,
                          TongTien = (decimal)pdv.TongTien,
                          MaKH = pdv.MaKH,
                          TrangThai = pdv.TrangThai
                      };

            return tbl.ToList();
        }

        public object GetPhieuDatVe(string text)
        {
            var tbl = from pdv in qldvx.PhieuDatVes
                      where pdv.MaKH.Contains(text)
                      select new PhieuDatVe_DTO
                      {
                          MaPhieu = pdv.MaPhieu,
                          SoLuongGhe = pdv.SoLuongGhe,
                          TongTien = (decimal)pdv.TongTien,
                          MaKH = pdv.MaKH,
                          TrangThai = pdv.TrangThai
                      };

            return tbl.ToList();
        }

        public string getTenKH(string maphieu)
        {
            var phieu = qldvx.PhieuDatVes.Where(p => p.MaPhieu == maphieu).FirstOrDefault();
            if (phieu != null)
            {
                var khachhang = qldvx.KhachHangs.Where(k => k.MaKH == phieu.MaKH).FirstOrDefault();
                return khachhang.HoTen;
            }
            return null;
        }

        public bool huyVe(string maPhieu, decimal phiHuyVe, string manv)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                var phieu = qldvx.PhieuDatVes.Where(t => t.MaPhieu == maPhieu).FirstOrDefault();
                var hoadon = qldvx.HoaDons.Where(h => h.MaPhieu == maPhieu).FirstOrDefault();
                if (phieu != null && hoadon != null)
                {
                    if (phiHuyVe > 0)
                    {
                        phieu.TrangThai = "Vé đã hủy";
                        HoaDon hd = new HoaDon()
                        {
                            SoHD = int.Parse(currentDate.ToString("ddMMyyHHmm")),
                            MaPhieu = maPhieu,
                            ThanhTien = phiHuyVe,
                            TrangThai = "Thanh toán phí hủy",
                            PhuongThucTT = "Tiền mặt",
                            MaNV = manv
                        };


                        qldvx.HoaDons.InsertOnSubmit(hd);
                        qldvx.SubmitChanges();
                    }
                    else
                    {
                        qldvx.HoaDons.DeleteOnSubmit(hoadon);
                        qldvx.SubmitChanges();

                        qldvx.PhieuDatVes.DeleteOnSubmit(phieu);
                        qldvx.SubmitChanges();
                    }
                    return true;
                }
                return false;
            }
            catch
            { return false; }
        }



        public bool ThemPhieuDat(PhieuDatVe_DTO phieuDatVe)
        {
            try
            {
                PhieuDatVe newPhieuDatVe = new PhieuDatVe
                {

                    MaPhieu = phieuDatVe.MaPhieu,
                    SoLuongGhe = phieuDatVe.SoLuongGhe,
                    TongTien = phieuDatVe.TongTien,
                    MaKH = phieuDatVe.MaKH,
                };


                qldvx.PhieuDatVes.InsertOnSubmit(newPhieuDatVe);


                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm khách hàng !: " + ex.Message);
                return false;
            }
        }

        public decimal tinhPhiHuyVe(string maphieu)
        {
            var phieu = qldvx.PhieuDatVes.Where(t => t.MaPhieu == maphieu).FirstOrDefault();
            decimal phi = phieu.TongTien.Value * 0.2m;
            return phi;
        }

        public DataTable GetPhieuDatVeDaHuyTrongTuan()
        {
            DateTime startOfWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1); // Bắt đầu tuần
            DateTime endOfWeek = startOfWeek.AddDays(6); // Kết thúc tuần

            var danhSachPhieuHuy = from pdv in qldvx.PhieuDatVes
                                   join kh in qldvx.KhachHangs on pdv.MaKH equals kh.MaKH
                                   where pdv.TrangThai == "Vé đã hủy"
                                   && DateTime.ParseExact(pdv.MaPhieu.Substring(0, 8), "yyyyMMdd", null) >= startOfWeek
                                   && DateTime.ParseExact(pdv.MaPhieu.Substring(0, 8), "yyyyMMdd", null) <= endOfWeek
                                   select new
                                   {
                                       pdv.MaPhieu,
                                       pdv.SoLuongGhe,
                                       pdv.TrangThai,
                                       pdv.TongTien,
                                       pdv.MaKH,
                                       kh.HoTen,
                                       kh.SDT
                                   };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Phiếu", typeof(string));
            dt.Columns.Add("Số Lượng Ghế", typeof(int));
            dt.Columns.Add("Trạng Thái", typeof(string));
            dt.Columns.Add("Tổng Tiền", typeof(decimal));
            dt.Columns.Add("Mã Khách Hàng", typeof(string));
            dt.Columns.Add("Tên Khách Hàng", typeof(string));
            dt.Columns.Add("Số Điện Thoại", typeof(string));

            // Thêm dữ liệu vào DataTable
            foreach (var item in danhSachPhieuHuy)
            {
                dt.Rows.Add(item.MaPhieu, item.SoLuongGhe, item.TrangThai, item.TongTien, item.MaKH, item.HoTen, item.SDT);
            }

            return dt;
        }

        //=====================================================Thống kê============================================================
        public List<WeeklyReport> PhieuDatVeTrongTuan()
        {
            var currentDate = DateTime.Now;  // Ngày hiện tại
            var currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);  // Tuần hiện tại

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            // Lọc các phiếu có ngày đặt trong tuần hiện tại
            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                t.NgayDat, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == currentWeek)  // Chỉ lấy phiếu trong tuần hiện tại
            .GroupBy(p => currentWeek)  // Gộp theo tuần hiện tại
            .Select(g => new WeeklyReport
            {
                Week = g.Key,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Week)
            .ToList();

            return result;
        }

        public List<WeeklyReport> PhieuDatVe_DaHuy_TrongTuan()
        {
            var currentDate = DateTime.Now;  // Ngày hiện tại
            var currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);  // Tuần hiện tại

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            // Lọc các phiếu đã hủy trong tuần hiện tại
            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => t.Phieu.TrangThai == "Vé đã hủy" &&
                        CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                            t.NgayDat, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == currentWeek)  // Lọc theo tuần hiện tại
            .GroupBy(p => currentWeek)  // Gộp theo tuần hiện tại
            .Select(g => new WeeklyReport
            {
                Week = g.Key,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Week)
            .ToList();

            return result;
        }


        public List<WeeklyReport> PhieuDatVe_DaThanhToan_TrongTuan()
        {
            var currentDate = DateTime.Now;  // Ngày hiện tại
            var currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);  // Tuần hiện tại

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            // Lọc các phiếu đã thanh toán trong tuần hiện tại
            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => t.Phieu.TrangThai == "Đã thanh toán" &&
                        CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                            t.NgayDat, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == currentWeek)  // Lọc theo tuần hiện tại
            .GroupBy(p => currentWeek)  // Gộp theo tuần hiện tại
            .Select(g => new WeeklyReport
            {
                Week = g.Key,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Week)
            .ToList();

            return result;
        }

        private DateTime GetStartOfWeek(DateTime date, DayOfWeek startOfWeek)
        {
            int diff = (7 + (date.DayOfWeek - startOfWeek)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        public List<DailyReport> GetPhieuDatVeTheoNgayTrongTuan()
        {
            var startOfWeek = GetStartOfWeek(DateTime.Now, DayOfWeek.Monday);
            var endOfWeek = startOfWeek.AddDays(7);

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            var reports = phieuDatVes
                .Select(p => new
                {
                    Phieu = p,
                    NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
                })
                .Where(p => p.NgayDat >= startOfWeek && p.NgayDat < endOfWeek)
                .GroupBy(p => p.NgayDat.Date)
                .Select(g => new DailyReport
                {
                    Date = g.Key,
                    DatVe = g.Count(p => p.Phieu.TrangThai == "Đặt chỗ"),
                    DaHuy = g.Count(p => p.Phieu.TrangThai == "Vé đã hủy"),
                    DaThanhToan = g.Count(p => p.Phieu.TrangThai == "Đã thanh toán")
                })
                .ToList();

            return reports;
        }


        //============Theo Tháng===============
        public List<MonthlyReport> PhieuDatVeTheoThang()
        {
            var currentDate = DateTime.Now;  // Ngày hiện tại
            var currentMonth = currentDate.Month;  // Tháng hiện tại
            var currentYear = currentDate.Year;  // Năm hiện tại

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => t.NgayDat.Month == currentMonth && t.NgayDat.Year == currentYear)  // Chỉ lấy phiếu trong tháng hiện tại
            .GroupBy(p => new { p.NgayDat.Month, p.NgayDat.Year })  // Gộp theo tháng và năm
            .Select(g => new MonthlyReport
            {
                Month = g.Key.Month,
                Year = g.Key.Year,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Month)
            .ToList();

            return result;
        }
        public List<MonthlyReport> PhieuDatVe_DaHuy_TrongThang()
        {
            var currentDate = DateTime.Now;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => t.Phieu.TrangThai == "Vé đã hủy" &&
                        t.NgayDat.Month == currentMonth && t.NgayDat.Year == currentYear)  // Lọc theo tháng và năm hiện tại
            .GroupBy(p => new { p.NgayDat.Month, p.NgayDat.Year })  // Gộp theo tháng và năm
            .Select(g => new MonthlyReport
            {
                Month = g.Key.Month,
                Year = g.Key.Year,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Month)
            .ToList();

            return result;
        }

        public List<MonthlyReport> PhieuDatVe_DaThanhToan_TrongThang()
        {
            var currentDate = DateTime.Now;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            // Lọc các phiếu đã thanh toán trong tháng hiện tại
            var result = phieuDatVes.Select(p => new
            {
                Phieu = p,
                NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
            })
            .Where(t => t.Phieu.TrangThai == "Đã thanh toán" &&
                        t.NgayDat.Month == currentMonth && t.NgayDat.Year == currentYear)  // Lọc theo tháng và năm hiện tại
            .GroupBy(p => new { p.NgayDat.Month, p.NgayDat.Year })  // Gộp theo tháng và năm
            .Select(g => new MonthlyReport
            {
                Month = g.Key.Month,
                Year = g.Key.Year,
                Count = g.Count(),
                TotalSeats = g.Sum(x => x.Phieu.SoLuongGhe ?? 0),
                TotalAmount = (decimal)g.Sum(x => x.Phieu.TongTien)
            })
            .OrderBy(r => r.Month)
            .ToList();

            return result;
        }



        public List<WeeklyReport> GetPhieuDatVeTheoTuanTrongThang()
        {
            var currentDate = DateTime.Now;
            var firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1); // Ngày đầu tiên của tháng
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng

            var phieuDatVes = qldvx.PhieuDatVes.ToList();

            var reports = phieuDatVes
                .Select(p => new
                {
                    Phieu = p,
                    NgayDat = DateTime.ParseExact(p.MaPhieu, "ddMMyyHHmm", CultureInfo.InvariantCulture)
                })
                .Where(p => p.NgayDat >= firstDayOfMonth && p.NgayDat <= lastDayOfMonth)
                .GroupBy(p => GetWeekOfMonth(p.NgayDat)) // Nhóm theo tuần trong tháng
                .Select(g => new WeeklyReport
                {
                    Week = g.Key,
                    DatVe = g.Count(p => p.Phieu.TrangThai == "Đặt chỗ"),
                    DaHuy = g.Count(p => p.Phieu.TrangThai == "Vé đã hủy"),
                    DaThanhToan = g.Count(p => p.Phieu.TrangThai == "Đã thanh toán")
                })
                .ToList();

            return reports;
        }

        private int GetWeekOfMonth(DateTime date)
        {
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var days = (date - firstDayOfMonth).Days;
            return (days / 7) + 1; // Tính tuần trong tháng
        }

        // ==================== Xuất file Excel =====================
        public int ExportPhieuDatVeToExcel()
        {
            // Lấy tháng và năm hiện tại
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // Lọc các phiếu đặt vé trong tháng hiện tại
            var phieuDatVes = qldvx.PhieuDatVes.ToList(); // Lấy tất cả phiếu đặt vé từ cơ sở dữ liệu
            var phieuDatVesThangHienTai = phieuDatVes
                .Where(p => DateTime.ParseExact(p.MaPhieu.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture).Month == currentMonth &&
                            DateTime.ParseExact(p.MaPhieu.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture).Year == currentYear)
                .ToList();


            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // Tạo một file Excel mới
                using (var package = new ExcelPackage())
                {
                    // Tạo sheet "Phiếu đã đặt"
                    var sheetDatVe = package.Workbook.Worksheets.Add("Phiếu đã đặt");
                    sheetDatVe.Cells[1, 1].Value = "Mã phiếu";
                    sheetDatVe.Cells[1, 2].Value = "Tên khách hàng";
                    sheetDatVe.Cells[1, 3].Value = "Số lượng ghế";
                    sheetDatVe.Cells[1, 4].Value = "Tổng tiền";
                    sheetDatVe.Cells[1, 5].Value = "Trạng thái";

                    int row = 2; // Dòng bắt đầu từ 2 vì dòng 1 là tiêu đề
                    foreach (var phieu in phieuDatVesThangHienTai.Where(p => p.TrangThai == "Đặt chỗ"))
                    {
                        // Tìm tên khách hàng từ danh sách khách hàng theo MaKH
                        var tenKH = qldvx.KhachHangs.FirstOrDefault(k => k.MaKH == phieu.MaKH)?.HoTen ?? "Không tìm thấy";

                        sheetDatVe.Cells[row, 1].Value = phieu.MaPhieu;
                        sheetDatVe.Cells[row, 2].Value = tenKH;
                        sheetDatVe.Cells[row, 3].Value = phieu.SoLuongGhe ?? 0;
                        sheetDatVe.Cells[row, 4].Value = phieu.TongTien;
                        sheetDatVe.Cells[row, 5].Value = phieu.TrangThai;
                        row++;
                    }

                    // Tạo sheet "Phiếu đã hủy"
                    var sheetDaHuy = package.Workbook.Worksheets.Add("Phiếu đã hủy");
                    sheetDaHuy.Cells[1, 1].Value = "Mã phiếu";
                    sheetDaHuy.Cells[1, 2].Value = "Tên khách hàng";
                    sheetDaHuy.Cells[1, 3].Value = "Số lượng ghế";
                    sheetDaHuy.Cells[1, 4].Value = "Tổng tiền";
                    sheetDaHuy.Cells[1, 5].Value = "Trạng thái";

                    row = 2;
                    foreach (var phieu in phieuDatVesThangHienTai.Where(p => p.TrangThai == "Vé đã hủy"))
                    {
                        // Tìm tên khách hàng từ danh sách khách hàng theo MaKH
                        var tenKH = qldvx.KhachHangs.FirstOrDefault(k => k.MaKH == phieu.MaKH)?.HoTen ?? "Không tìm thấy";

                        sheetDaHuy.Cells[row, 1].Value = phieu.MaPhieu;
                        sheetDaHuy.Cells[row, 2].Value = tenKH;
                        sheetDaHuy.Cells[row, 3].Value = phieu.SoLuongGhe ?? 0;
                        sheetDaHuy.Cells[row, 4].Value = phieu.TongTien;
                        sheetDaHuy.Cells[row, 5].Value = phieu.TrangThai;
                        row++;
                    }

                    // Tạo sheet "Phiếu đã thanh toán"
                    var sheetDaThanhToan = package.Workbook.Worksheets.Add("Phiếu đã thanh toán");
                    sheetDaThanhToan.Cells[1, 1].Value = "Mã phiếu";
                    sheetDaThanhToan.Cells[1, 2].Value = "Tên khách hàng";
                    sheetDaThanhToan.Cells[1, 3].Value = "Số lượng ghế";
                    sheetDaThanhToan.Cells[1, 4].Value = "Tổng tiền";
                    sheetDaThanhToan.Cells[1, 5].Value = "Trạng thái";

                    row = 2;
                    foreach (var phieu in phieuDatVesThangHienTai.Where(p => p.TrangThai == "Đã thanh toán"))
                    {
                        // Tìm tên khách hàng từ danh sách khách hàng theo MaKH
                        var tenKH = qldvx.KhachHangs.FirstOrDefault(k => k.MaKH == phieu.MaKH)?.HoTen ?? "Không tìm thấy";

                        sheetDaThanhToan.Cells[row, 1].Value = phieu.MaPhieu;
                        sheetDaThanhToan.Cells[row, 2].Value = tenKH;
                        sheetDaThanhToan.Cells[row, 3].Value = phieu.SoLuongGhe ?? 0;
                        sheetDaThanhToan.Cells[row, 4].Value = phieu.TongTien;
                        sheetDaThanhToan.Cells[row, 5].Value = phieu.TrangThai;
                        row++;
                    }

                    // Xác định thư mục bên ngoài project và lưu file vào đó
                    var projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn thư mục gốc của project
                    var parentDirectory = Directory.GetParent(projectDirectory).FullName; // Lấy thư mục cha (bên ngoài project)

                    var exportDirectory = Path.Combine(parentDirectory, "Exports"); // Tạo thư mục "Exports" bên ngoài project nếu chưa có
                    if (!Directory.Exists(exportDirectory))
                    {
                        Directory.CreateDirectory(exportDirectory);
                    }

                    // Đặt đường dẫn lưu file Excel
                    var filePath = Path.Combine(exportDirectory, $"phieu_dat_ve_thang_{currentMonth}_{currentYear}.xlsx");
                    FileInfo fileInfo = new FileInfo(filePath);

                    // Lưu file
                    package.SaveAs(fileInfo);
                    return 1;
                }
            }
            catch
            {
                return -1;
            }
        }

    }
}
