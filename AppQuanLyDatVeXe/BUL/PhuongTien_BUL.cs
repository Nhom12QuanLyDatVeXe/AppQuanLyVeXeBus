using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BUL
{
    public class PhuongTien_BUL
    {
        PhuongTien_DAL dal = new PhuongTien_DAL();
        public List<PhuongTien_DTO>GetPhuongTien()
        {

            try
            {
                return dal.GetPhuongTien();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
        }

        public PhuongTien_DTO GetPhuongTien(string biensoxe)
        {
            return dal.GetPhuongTien(biensoxe);
        }

        public object GetPhuongTiens(string text)
        {
            return dal.GetPhuongTiens(text);
        }

        public int insert(PhuongTien_DTO pt)
        {
            return dal.insert(pt);
        }
        public bool ThemPT(PhuongTien_DTO pt)
        {

            return dal.ThemPhuongTien(pt);
        }
        public bool SuaPT(PhuongTien_DTO pt)
        {
            return dal.SuaPhuongTien(pt);
        }
        public bool XoaPT(PhuongTien_DTO pt)
        {
            return dal.XoaPhuongTien(pt);
        }
    }
}
