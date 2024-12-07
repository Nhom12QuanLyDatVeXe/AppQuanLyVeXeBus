using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class KhachHang_BUL
    {
        KhachHang_DAL dal = new KhachHang_DAL();
        public List<KhachHang_DTO> GetKhachHang()
        {

            try
            {
                return dal.GetKhachHang();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
        }

        public KhachHang_DTO GetKhachHang(string v)
        {
            return dal.GetKhachHang(v);
        }

        public object GetKhachHang1(string text)
        {
            return dal.GetKhachHang1(text);
        }

        public bool ThemKH(KhachHang_DTO khachhang)
        {

            return dal.themKH(khachhang);
        }

        public KhachHang_DTO TimKHTheoMa(string text)
        {
            return dal.TimKHTheoMa(text);
        }
        public bool SuaKH(KhachHang_DTO khachhang)
        {
            return dal.SuaKhachHang(khachhang);
        }
        public bool XoaKH(KhachHang_DTO khachhang)
        {
            return dal.XoaKhachHang(khachhang);
        }
    }
}
