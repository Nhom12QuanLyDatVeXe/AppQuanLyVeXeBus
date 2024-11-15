using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class TaiKhoan_BUL
    {
        private TaiKhoan_DAL dal = new TaiKhoan_DAL();
        public int CheckLogin(TaiKhoan_DTO acc)
        {
            return dal.checkLogin(acc);
        }
    }
}
