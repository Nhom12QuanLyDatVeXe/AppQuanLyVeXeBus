using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public partial class TinhThanh_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();

        public object getAll()
        {
            var tbl = qldvx.TinhThanhs.ToList();
            return tbl;
        }
    }
}
