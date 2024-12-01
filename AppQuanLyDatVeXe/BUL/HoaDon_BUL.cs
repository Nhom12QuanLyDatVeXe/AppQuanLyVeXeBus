using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class HoaDon_BUL
    {
        HoaDon_DAL dal = new HoaDon_DAL();
        public List<HoaDon_DTO>GetHoaDon()
        {

            try
            {
                return dal.GetHoaDon();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
        }
        public bool ThemHoaDon(HoaDon_DTO hoadon)
        {

            return dal.ThemHoaDon(hoadon);
        }

    }



}

