using DTO;
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
    }
}
