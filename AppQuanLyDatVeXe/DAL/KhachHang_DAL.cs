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

        public KhachHang_DTO GetKhachHang(string v)
        {
            var tbl = qldvx.KhachHangs.Where(t => t.MaKH == v).FirstOrDefault();
            if (tbl != null)
            {
                KhachHang_DTO kh = new KhachHang_DTO
                { 
                    MaKH = tbl.MaKH,
                    HoTen= tbl.HoTen,
                    SDT= tbl.SDT,
                    Email = tbl.Email,
                    GioiTinh = tbl.GioiTinh
                };
                return kh;
            }    
            return null;
        }

        public object GetKhachHang1(string text)
        {
            var tbl = from kh in qldvx.KhachHangs
                      where kh.HoTen.Contains(text)
                      select new KhachHang_DTO
                      {

                          MaKH = kh.MaKH,
                          HoTen = kh.HoTen,
                          SDT = kh.SDT,
                          Email = kh.Email,
                          GioiTinh = kh.GioiTinh,

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

        public KhachHang_DTO TimKHTheoMa(string text)
        {
            var tbl = qldvx.KhachHangs.Where(t => t.MaKH == text).FirstOrDefault();
            if(tbl != null)
            {
                KhachHang_DTO kh = new KhachHang_DTO
                {
                    MaKH = tbl.MaKH,
                    HoTen = tbl.HoTen,
                    SDT = tbl.SDT,
                    Email = tbl.Email,
                    GioiTinh = tbl.GioiTinh
                };
                return kh;
            }
            return null;
        }
        public bool SuaKhachHang(KhachHang_DTO kh)
        {
            try
            {
                KhachHang suakh = qldvx.KhachHangs.FirstOrDefault(n => n.MaKH == kh.MaKH);

                suakh.HoTen = kh.HoTen;
                suakh.SDT = kh.SDT;
                suakh.Email = kh.Email;
                suakh.GioiTinh = kh.GioiTinh;

                qldvx.SubmitChanges();
                return true;
            }
            catch { return false; }

        }
        public bool XoaKhachHang(KhachHang_DTO kh)
        {
            try
            {
                KhachHang xoaKhachHang = qldvx.KhachHangs.Where(n => n.MaKH == kh.MaKH).FirstOrDefault();

                qldvx.KhachHangs.DeleteOnSubmit(xoaKhachHang);
                qldvx.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Không thể xóa khách hàng này. Lỗi: " + ex.Message); // Log lỗi
                return false;
            }
        }
    }
}
