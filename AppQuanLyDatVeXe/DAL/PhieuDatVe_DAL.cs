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

        public int createOne(int soluongghe, double tongtien, string makh, string matuyen, List<string> danhSachGheDaChon, double dongia)
        {
            try
            {
                DateTime currentDate = DateTime.Now;

                PhieuDatVe phieu = new PhieuDatVe();
                phieu.MaPhieu = currentDate.ToString("ddMMyyHHmm");
                phieu.SoLuongGhe = soluongghe;
                phieu.TongTien = (decimal)tongtien;
                phieu.MaKH = makh;

                qldvx.PhieuDatVes.InsertOnSubmit(phieu);
                qldvx.SubmitChanges();

                string maphieu = phieu.MaPhieu;
                foreach(string maghe in danhSachGheDaChon)
                {
                    var existingDetail = qldvx.ChiTietDatVes
                                      .FirstOrDefault(ctd => ctd.MaPhieu == maphieu && ctd.MaGhe == maghe);
                    if (existingDetail == null)
                    {
                        ChiTietDatVe ctdv = new ChiTietDatVe();
                        ctdv.MaPhieu = maphieu;
                        ctdv.MaTuyenXe = int.Parse(matuyen);
                        ctdv.MaGhe = maghe;
                        ctdv.DonGia = (decimal)dongia;

                        qldvx.ChiTietDatVes.InsertOnSubmit(ctdv);
                    }    
                    else
                    {
                        Console.WriteLine("Chi tiết vé này đã tồn tại.");
                    }    
                }

                qldvx.SubmitChanges();

                return 1;

            }
            catch (Exception e)
            { return -1; }
                
        }

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


        public bool ThemPhieuDat(PhieuDatVe_DTO phieuDatVe)
        {
            try
            {
                PhieuDatVe newPhieuDatVe = new PhieuDatVe
                {
                    
                    MaPhieu = phieuDatVe.MaPhieu,
                    SoLuongGhe = phieuDatVe.SoLuongGhe,
                    TongTien = phieuDatVe.TongTien,
                    MaKH = phieuDatVe.MaKH,
                };


                qldvx.PhieuDatVes.InsertOnSubmit(newPhieuDatVe);


                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm khách hàng !: " + ex.Message);
                return false;
            }
        }
    }
}
