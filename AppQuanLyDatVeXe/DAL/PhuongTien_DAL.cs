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

        public bool ThemPhuongTien(PhuongTien_DTO phuongtien)
        {
            try
            {
                PhuongTien newPhuongTien= new PhuongTien
                {

                    BienSoXe = phuongtien.BienSoXe,
                    TaiXeChinh = phuongtien.TaiXeChinh,
                    TaiXePhu = phuongtien.TaiXephu,
                    SoGhe = phuongtien.SoGhe,
                };


                qldvx.PhuongTiens.InsertOnSubmit(newPhuongTien);


                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm phương tiện !: " + ex.Message);
                return false;
            }
        }
}
