using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TuyenXe_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();

        public TuyenXe_DTO Get1TuyenXe(int matuyenxe)
        {
            var tx = qldvx.TuyenXes.Where(t => t.MaTuyenXe == matuyenxe).FirstOrDefault();
            if(tx!= null)
            {
                TuyenXe_DTO tuyenxe = new TuyenXe_DTO();
                tuyenxe.TenTuyen = tx.TenTuyen;
                tuyenxe.BienSoXe = tx.BienSoXe;
                tuyenxe.ThoiGianDi = (DateTime)tx.ThoiGianDi;
                tuyenxe.GioXuatBen = (TimeSpan)tx.GioXuatBen;

                return tuyenxe;
            }
            return null;
        }

        public List<TuyenXe_DTO> GetTuyenXe()
        {
            DateTime currentDate = DateTime.Now;
            var tbl = from tx in qldvx.TuyenXes
                      where tx.ThoiGianDi > currentDate
                      select new TuyenXe_DTO
                      {

                          MaTuyenXe = tx.MaTuyenXe,
                          TenTuyen = tx.TenTuyen,
                          ThoiGianDi = tx.ThoiGianDi.Value, // Default if null
                          DiemDi = tx.DiemDi,
                          DiemDen = tx.DiemDen,
                          GioXuatBen = tx.GioXuatBen.Value,
                          GioDenNoi = tx.GioDenNoi.Value,
                          KhoangCach = (int)tx.KhoangCach,
                          DonGia = tx.DonGia,
                          BienSoXe = tx.BienSoXe,

                      };


            return tbl.ToList();
        }

        public object GetTuyenXe(string diemdi, string diemden, DateTime ngaydi)
        {
            var tbl = from tx in qldvx.TuyenXes
                      where tx.DiemDi == diemdi && tx.DiemDen == diemden && tx.ThoiGianDi.HasValue && tx.ThoiGianDi.Value.Date == ngaydi.Date
                      select new TuyenXe_DTO
                      {
                          MaTuyenXe = tx.MaTuyenXe,
                          TenTuyen = tx.TenTuyen,
                          ThoiGianDi = tx.ThoiGianDi.Value,
                          DiemDi = tx.DiemDi,
                          DiemDen = tx.DiemDen,
                          GioXuatBen = tx.GioXuatBen.Value,
                          GioDenNoi = tx.GioDenNoi.Value,
                          KhoangCach = (int)tx.KhoangCach,
                          DonGia = tx.DonGia,
                          BienSoXe = tx.BienSoXe
                      };
            return tbl.ToList();
        }

        public object GetTuyenXe(string text)
        {
            DateTime currentDate = DateTime.Now;
            var tbl = from tx in qldvx.TuyenXes
                      where tx.ThoiGianDi > currentDate && tx.TenTuyen.Contains(text)
                      select new TuyenXe_DTO
                      {

                          MaTuyenXe = tx.MaTuyenXe,
                          TenTuyen = tx.TenTuyen,
                          ThoiGianDi = tx.ThoiGianDi.Value, // Default if null
                          DiemDi = tx.DiemDi,
                          DiemDen = tx.DiemDen,
                          GioXuatBen = tx.GioXuatBen.Value,
                          GioDenNoi = tx.GioDenNoi.Value,
                          KhoangCach = (int)tx.KhoangCach,
                          DonGia = tx.DonGia,
                          BienSoXe = tx.BienSoXe,

                      };


            return tbl.ToList();
        }

        public bool ThemTuyenXe(TuyenXe_DTO tuyenxe)
        {
            try
            {
                Random random = new Random();
                
                DateTime ngayKhoiHanh = tuyenxe.ThoiGianDi.Date; 
                string bienSoXe = tuyenxe.BienSoXe;

                
                var existingTuyenXe = qldvx.TuyenXes
                    .Where(tx => tx.BienSoXe == bienSoXe && tx.ThoiGianDi.HasValue && tx.ThoiGianDi.Value.Date == ngayKhoiHanh)
                    .FirstOrDefault();

                if (existingTuyenXe != null)
                {
                    Console.WriteLine("Lỗi khi thêm tuyến xe ! ");
                    return false; 
                }

                int temp = random.Next(1, 999);
                while (qldvx.TuyenXes.Where(t=>t.MaTuyenXe == temp).FirstOrDefault() != null)
                {
                    temp = random.Next(1, 999);
                }
                TuyenXe newTuyenXe = new TuyenXe
                {

                    MaTuyenXe = temp,
                    TenTuyen = tuyenxe.TenTuyen,
                    ThoiGianDi = tuyenxe.ThoiGianDi,
                    DiemDi = tuyenxe.DiemDi,
                    DiemDen = tuyenxe.DiemDen,
                    GioDenNoi = tuyenxe.GioDenNoi,
                    GioXuatBen = tuyenxe.GioXuatBen,
                    KhoangCach = tuyenxe.KhoangCach,
                    DonGia = tuyenxe.DonGia,
                    BienSoXe = tuyenxe.BienSoXe,
                };


                qldvx.TuyenXes.InsertOnSubmit(newTuyenXe);


                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi khi thêm tuyến xe !: " + ex.Message);
                return false;
            }
        }
        public bool SuaTuyenXe(TuyenXe_DTO tuyenxe)
        {
            try
            {
                var tbl = from tx in qldvx.TuyenXes
                          where tx.ThoiGianDi.HasValue && tx.ThoiGianDi.Value.Date == tuyenxe.ThoiGianDi.Date && tx.MaTuyenXe != tuyenxe.MaTuyenXe
                          select new TuyenXe_DTO 
                          {
                              MaTuyenXe = tx.MaTuyenXe,
                              TenTuyen = tx.TenTuyen,
                              ThoiGianDi = tx.ThoiGianDi.Value,
                              DiemDi = tx.DiemDi,
                              DiemDen = tx.DiemDen,
                              GioXuatBen = tx.GioXuatBen.Value,
                              GioDenNoi = tx.GioDenNoi.Value,
                              KhoangCach = (int)tx.KhoangCach,
                              DonGia = tx.DonGia,
                              BienSoXe = tx.BienSoXe
                          };
                List<TuyenXe_DTO> lst = tbl.ToList();
                foreach (TuyenXe_DTO t in lst)
                {
                    if (t.BienSoXe == tuyenxe.BienSoXe)
                    {
                        Console.WriteLine("Xe đã có tuyến xe cùng giờ");
                        return false;
                    }
                }

                TuyenXe txe = qldvx.TuyenXes.Where(n => n.MaTuyenXe == tuyenxe.MaTuyenXe).FirstOrDefault();
                txe.TenTuyen = tuyenxe.TenTuyen;
                txe.ThoiGianDi = tuyenxe.ThoiGianDi;
                txe.DiemDi = tuyenxe.DiemDi;
                txe.DiemDen = tuyenxe.DiemDen;
                txe.GioXuatBen = tuyenxe.GioXuatBen;
                txe.GioDenNoi = tuyenxe.GioDenNoi;
                txe.KhoangCach = tuyenxe.KhoangCach;
                txe.DonGia = tuyenxe.DonGia;
                txe.BienSoXe = tuyenxe.BienSoXe;

                qldvx.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa tuyến xe: " + ex.Message);
                return false;
            }
        }

        public bool deleteOne(int matuyen)
        {
            try
            {
                var tbl = qldvx.TuyenXes.Where(t => t.MaTuyenXe == matuyen).FirstOrDefault();
                if (tbl!=null)
                {
                    qldvx.TuyenXes.DeleteOnSubmit(tbl);
                    qldvx.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
