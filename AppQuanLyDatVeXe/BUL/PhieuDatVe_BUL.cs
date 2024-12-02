using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class PhieuDatVe_BUL
    {
        PhieuDatVe_DAL dal = new PhieuDatVe_DAL();

        public int createOne(int soluongghe, double tongtien, string makh, string matuyen, List<string> danhSachGheDaChon, double dongia)
        {
            return dal.createOne(soluongghe, tongtien, makh, matuyen, danhSachGheDaChon, dongia);
        }

        public List<PhieuDatVe_DTO> GetPhieuDatVe()
        {


            try
            {
                return dal.GetPhieuDatVe();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public bool ThemPDV(PhieuDatVe_DTO pdv)
        {

            return dal.ThemPhieuDat(pdv);
        }


    }
}
