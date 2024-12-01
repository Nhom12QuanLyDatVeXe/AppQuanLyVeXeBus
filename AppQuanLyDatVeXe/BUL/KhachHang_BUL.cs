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

                Console.WriteLine($"lỗi : {ex.Message}");
                throw;
            }
        }

        public bool ThemKH(KhachHang_DTO khachhang)
        {

            return dal.themKH(khachhang);
        }
    }
}
