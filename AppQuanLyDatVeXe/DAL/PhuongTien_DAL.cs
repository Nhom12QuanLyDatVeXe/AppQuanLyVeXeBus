using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhuongTien_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();


        public List<PhuongTien_DTO> GetPhuongTien()
        {

            var tbl = from pt in qldvx.PhuongTiens
                      select new PhuongTien_DTO
                      {

                        BienSoXe = pt.BienSoXe,
                        TaiXeChinh = pt.TaiXeChinh,
                        TaiXephu = pt.TaiXePhu,
                        SoGhe = pt.SoGhe,

                      };


            return tbl.ToList();
        }

        public int insert(PhuongTien_DTO pt)
        {
            try
            {
                PhuongTien phuongtien = new PhuongTien { 
                BienSoXe = pt.BienSoXe,
                TaiXeChinh = pt.TaiXeChinh,
                TaiXePhu = pt.TaiXephu,
                SoGhe = pt.SoGhe};
                qldvx.PhuongTiens.InsertOnSubmit(phuongtien);
                qldvx.SubmitChanges();
                return 1;
            }
            catch { return -1; }
        }
    }
}
