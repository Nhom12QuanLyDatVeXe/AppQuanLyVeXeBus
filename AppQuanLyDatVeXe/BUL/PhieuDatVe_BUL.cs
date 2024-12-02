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

        public int checkDieuKienHuy(string maPhieu)
        {
            return dal.checkDieuKienHuy(maPhieu);
        }

        public int createOne(int soluongghe, double tongtien, string makh, string matuyen, List<string> danhSachGheDaChon, double dongia)
        {
            return dal.createOne(soluongghe, tongtien, makh, matuyen, danhSachGheDaChon, dongia);
        }

        public int deleteOne(string maphieu)
        {
            return dal.deleteOne(maphieu);
        }

        public int get1CTPDV(string maPhieu)
        {
            return dal.get1CTPDV(maPhieu);
        }

        public object getCTPDV(string maPhieu)
        {
            return dal.getCTPDV(maPhieu);
        }

        public List<string> GetGheDaDat(string matuyen)
        {
            return dal.GetGheDaDat(matuyen);
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

        public string getTenKH(string maphieu)
        {
            return dal.getTenKH(maphieu);
        }

        public bool huyVe(string maPhieu)
        {
            return dal.huyVe(maPhieu);
        }

        public bool ThemPDV(PhieuDatVe_DTO pdv)
        {

            return dal.ThemPhieuDat(pdv);
        }

        public decimal tinhPhiHuyVe(string maphieu)
        {
            return dal.tinhPhiHuyVe(maphieu);
        }
    }
}
