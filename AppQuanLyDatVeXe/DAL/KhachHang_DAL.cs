using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHang_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();


        public List<KhachHang_DTO> GetKhachHang()
        {

            var tbl = from kh in qldvx.KhachHangs
                      select new KhachHang_DTO
                      {

                         MaKH = kh.MaKH,
                         HoTen = kh.HoTen,  
                         SDT = kh.SDT,
                         Email = kh.Email,
                         GioiTinh= kh.GioiTinh,

                      };


            return tbl.ToList();
        }
    }
}
