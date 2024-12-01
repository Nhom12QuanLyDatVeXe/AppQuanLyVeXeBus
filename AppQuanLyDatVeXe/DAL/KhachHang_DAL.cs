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

        public bool themKH(KhachHang_DTO khachHang)
        {
            try
            {
                KhachHang newKhachHang = new KhachHang
                {
                    MaKH = khachHang.MaKH,
                    HoTen = khachHang.HoTen,
                    SDT = khachHang.SDT,
                    Email = khachHang.Email,
                    GioiTinh = khachHang.GioiTinh
                };


                qldvx.KhachHangs.InsertOnSubmit(newKhachHang);


                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm khách hàng !: " + ex.Message);
                return false;
            }
        }

    }
}
