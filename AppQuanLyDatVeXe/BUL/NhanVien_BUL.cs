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

        public object GetNhanVien(string text)
        {
            return dal.getNhanViens(text);
        }

        public bool ThemNV(NhanVien_DTO nhanvien)
        {

            return dal.ThemNhanVien(nhanvien);
        }
        public bool SuaNV(NhanVien_DTO nhanvien)
        {
            return dal.SuaNhanVien(nhanvien);
        }
        public bool XoaNV(NhanVien_DTO nhanvien)
        {
            return dal.XoaNhanVien(nhanvien);
        }

        public bool doiMatKhau(string mkCu, string mkMoi, string maNV)
        {
            return dal.doiMatKhau(mkCu, mkMoi, maNV);
        }
    }
}
