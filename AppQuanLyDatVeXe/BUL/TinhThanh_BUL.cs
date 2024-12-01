using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class TinhThanh_BUL
    {
        TinhThanh_DAL dal_tt = new TinhThanh_DAL();
        public object getAll()
        {
            return dal_tt.getAll();
        }
    }
}
