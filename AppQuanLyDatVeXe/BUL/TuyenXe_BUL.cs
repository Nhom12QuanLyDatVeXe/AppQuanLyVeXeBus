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


    }
}
