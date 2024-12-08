using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class TuyenXe_BUL
    {
        TuyenXe_DAL dal = new TuyenXe_DAL();


        public List<TuyenXe_DTO> GetTuyenXe()
        {
            

            try
            {
                return dal.GetTuyenXe();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error : {ex.Message}");
                throw; 
            }
        }

        public object GetTuyenXe(string diemdi, string diemden, DateTime ngaydi)
        {
            return dal.GetTuyenXe(diemdi, diemden, ngaydi);
        }

        public TuyenXe_DTO Get1TuyenXe(int matuyenxe)
        {
            return dal.Get1TuyenXe(matuyenxe);
        }

        public bool ThemTX(TuyenXe_DTO tx)
        {

            return dal.ThemTuyenXe(tx);
        }

        public object GetTuyenXe(string text)
        {
            return dal.GetTuyenXe(text);
        }

        public bool SuaTX(TuyenXe_DTO txe)
        {
            return dal.SuaTuyenXe(txe);
        }

        public bool deleteOne(int matuyen)
        {
            return dal.deleteOne(matuyen);
        }
    }
}
