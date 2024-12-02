using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class NhanVien_BUL
    {
        NhanVien_DAL dal = new NhanVien_DAL();
        public List<NhanVien_DTO> GetNhanVien()
        {

            try
            {
                return dal.GetNhanVien();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
        }

        public NhanVien_DTO getNhanVien(string ma)
        {
            return dal.getNhanVien(ma);
        }

        public bool ThemNV(NhanVien_DTO nhanvien)
        {

            return dal.ThemNhanVien(nhanvien);
        }
    }
}
