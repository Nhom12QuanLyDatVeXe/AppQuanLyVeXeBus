using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();
        public int checkLogin(TaiKhoan_DTO acc)
        {
            var tbl = qldvx.TaiKhoans.Where(t => t.UserName == acc.UserName && t.Pass == acc.PassWord).FirstOrDefault();
            if (tbl != null)
                return 1;
            return 0;
        }
    }
}
