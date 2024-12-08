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
                        TaiXePhu = pt.TaiXePhu,
                        SoGhe = pt.SoGhe,

                      };


            return tbl.ToList();
        }

        public PhuongTien_DTO GetPhuongTien(string biensoxe)
        {
            var phuongtien = qldvx.PhuongTiens.Where(t => t.BienSoXe == biensoxe).FirstOrDefault();
            PhuongTien_DTO pt = new PhuongTien_DTO();
            pt.BienSoXe = phuongtien.BienSoXe;
            pt.TaiXePhu = phuongtien.TaiXePhu;
            pt.TaiXeChinh = phuongtien.TaiXeChinh;
            pt.SoGhe = phuongtien.SoGhe;
            return pt;
        }

        public object GetPhuongTiens(string text)
        {
            var tbl = from pt in qldvx.PhuongTiens
                      where pt.BienSoXe.Contains(text)
                      select new PhuongTien_DTO
                      {

                          BienSoXe = pt.BienSoXe,
                          TaiXeChinh = pt.TaiXeChinh,
                          TaiXePhu = pt.TaiXePhu,
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
                TaiXePhu = pt.TaiXePhu,
                SoGhe = pt.SoGhe};
                qldvx.PhuongTiens.InsertOnSubmit(phuongtien);
                qldvx.SubmitChanges();
                return 1;
            }
            catch { return -1; }
        }

        public bool ThemPhuongTien(PhuongTien_DTO phuongtien)
        {
            try
            {
                PhuongTien newPhuongTien = new PhuongTien
                {

                    BienSoXe = phuongtien.BienSoXe,
                    TaiXeChinh = phuongtien.TaiXeChinh,
                    TaiXePhu = phuongtien.TaiXePhu,
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
        public bool SuaPhuongTien(PhuongTien_DTO phuongtien)
        {
            try
            {
                PhuongTien suapt = qldvx.PhuongTiens.Where(n => n.BienSoXe == phuongtien.BienSoXe).FirstOrDefault();

                suapt.TaiXeChinh = phuongtien.TaiXeChinh;
                suapt.TaiXePhu = phuongtien.TaiXePhu;
                suapt.SoGhe = phuongtien.SoGhe;

                qldvx.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa phương tiện: " + ex.Message);
                return false;
            }
        }
        public bool XoaPhuongTien(PhuongTien_DTO phuongtien)
        {
            try
            {
                PhuongTien xoapt = qldvx.PhuongTiens.Where(n => n.BienSoXe == phuongtien.BienSoXe).FirstOrDefault();

                qldvx.PhuongTiens.DeleteOnSubmit(xoapt);
                qldvx.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phương tiện: " + ex.Message);
                return false;
            }
        }
    }
}
