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


        public List<TinhThanh_DTO> getAll1()
        {
            try
            {
                return qldvx.TinhThanhs
                    .Select(t => new TinhThanh_DTO
                    {
                        MaTinh = t.MaTinh,  
                        TenTinh = t.TenTinh
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
              
                throw new Exception("Loi.", ex);
            }
        }
    }

}
