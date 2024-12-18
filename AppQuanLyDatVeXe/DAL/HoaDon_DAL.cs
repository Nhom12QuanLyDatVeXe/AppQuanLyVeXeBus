﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDon_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();


        public List<HoaDon_DTO> GetHoaDon()
        {

            var tbl = from hd in qldvx.HoaDons
                      select new HoaDon_DTO
                      {

                        SoHD = hd.SoHD,
                        MaPhieu = hd.MaPhieu,
                        ThanhTien = hd.ThanhTien,
                        TrangThai = hd.TrangThai,
                        PhuongThucThanhToan = hd.PhuongThucTT,
                        MaNV = hd.MaNV,

                      };


            return tbl.ToList();
        }

        public object GetHoaDon(string ma)
        {
            var tbl = from hd in qldvx.HoaDons
                      where hd.MaPhieu.Contains(ma)
                      select new HoaDon_DTO
                      {

                          SoHD = hd.SoHD,
                          MaPhieu = hd.MaPhieu,
                          ThanhTien = hd.ThanhTien,
                          TrangThai = hd.TrangThai,
                          PhuongThucThanhToan = hd.PhuongThucTT,
                          MaNV = hd.MaNV,

                      };


            return tbl.ToList();
        }

        public bool ThemHoaDon(HoaDon_DTO hoadon)
        {
            try
            {
                var phieu = qldvx.PhieuDatVes.Where(t => t.MaPhieu == hoadon.MaPhieu).FirstOrDefault();
                HoaDon newHoaDon = new HoaDon
                {

                    SoHD = hoadon.SoHD,
                    MaNV = hoadon.MaNV,
                    MaPhieu = hoadon.MaPhieu,
                    ThanhTien = hoadon.ThanhTien,
                    TrangThai = hoadon.TrangThai,
                    PhuongThucTT = hoadon.PhuongThucThanhToan,
                };


                qldvx.HoaDons.InsertOnSubmit(newHoaDon);
                phieu.TrangThai = "Đã thanh toán";

                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm hóa đơn !: " + ex.Message);
                return false;
            }
        }

        
    }
}
