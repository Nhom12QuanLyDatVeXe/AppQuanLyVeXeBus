﻿using System;
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

        public int insert(PhuongTien_DTO pt)
        {
            return dal.insert(pt);
        }
    }
}
