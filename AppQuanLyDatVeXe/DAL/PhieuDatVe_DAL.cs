using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuDatVe_DAL
    {

        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();


        public List<PhieuDatVe_DTO> GetPhieuDatVe()
        {

            var tbl = from pdv in qldvx.PhieuDatVes
                      select new PhieuDatVe_DTO
                      {
                        MaPhieu = pdv.MaPhieu,
                        SoLuongGhe = pdv.SoLuongGhe,
                        TongTien = pdv.TongTien,
                        MaKH = pdv.MaKH,    
                      };

            return tbl.ToList();
        }
    }
}
