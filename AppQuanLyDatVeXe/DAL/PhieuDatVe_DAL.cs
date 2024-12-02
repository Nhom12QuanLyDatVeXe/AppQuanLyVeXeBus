﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
                        if (timeDifference.TotalHours > 12)
                        {
                            return 1;
                        }
                        else 
                            return 0;
                    }
                }
                else
                {
                    return 2;
                }
            }
            return 2; 
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

                qldvx.PhieuDatVes.InsertOnSubmit(phieu);
                qldvx.SubmitChanges();

                string maphieu = phieu.MaPhieu;
                foreach(string maghe in danhSachGheDaChon)
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
            if(ctpdv != null)
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
                      };

            return tbl.ToList();
        }

        public string getTenKH(string maphieu)
        {
            var phieu = qldvx.PhieuDatVes.Where(p => p.MaPhieu == maphieu).FirstOrDefault();
            if(phieu != null)
            {
                var khachhang = qldvx.KhachHangs.Where(k => k.MaKH == phieu.MaKH).FirstOrDefault();
                return khachhang.HoTen;
            }
            return null;
        }

        public bool huyVe(string maPhieu)
        {
            var phieu = qldvx.PhieuDatVes.Where(t => t.MaPhieu == maPhieu).FirstOrDefault();
            if (phieu != null) 
            {
                phieu.TrangThai = "Vé đã hủy";

                qldvx.SubmitChanges();

                return true;
            }
            return false;
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
    }
}
