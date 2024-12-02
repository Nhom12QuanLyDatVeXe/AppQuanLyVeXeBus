using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVien_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();


        public List<NhanVien_DTO> GetNhanVien()
        {

            var tbl = from nv in qldvx.NhanViens
                      select new NhanVien_DTO
                      {
                          MaNV = nv.MaNV,
                          HoTen = nv.TenNV,
                          NgaySinh = nv.NgaySinh.Value,
                          GioiTinh = nv.GioiTinh,
                          CCCD = nv.CCCD,
                          SDT = nv.SDT,
                          Luong = nv.Luong,
                          TrangThai = nv.TrangThai,
                          MaChucVu = nv.MaChucVu
                      };


            return tbl.ToList();
        }

        public bool ThemNhanVien(NhanVien_DTO nhanvien)
        {
            try
            {
                Console.WriteLine($"Ngày sinh: {nhanvien.NgaySinh}");
                NhanVien newNhanVien = new NhanVien
                {
                    MaNV = nhanvien.MaNV,
                    TenNV = nhanvien.HoTen,
                    NgaySinh = nhanvien.NgaySinh,
                    GioiTinh = nhanvien.GioiTinh,
                    CCCD = nhanvien.CCCD,
                    SDT = nhanvien.SDT,
                    Luong = nhanvien.Luong,
                    TrangThai = nhanvien.TrangThai,
                    MaChucVu = nhanvien.MaChucVu,
                };

                qldvx.NhanViens.InsertOnSubmit(newNhanVien);
                qldvx.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nhân viên: " + ex.Message); // Log lỗi
                return false;
            }
        }
        public NhanVien_DTO getNhanVien(string ma)
        {
            try
            {
                var nv = qldvx.NhanViens.Where(t => t.MaNV == ma).FirstOrDefault();
                NhanVien_DTO nhanvien = new NhanVien_DTO
                {
                    MaNV = nv.MaNV,
                    HoTen = nv.TenNV,
                    CCCD = nv.CCCD,
                    SDT = nv.SDT,
                    Luong = nv.Luong,
                    GioiTinh = nv.GioiTinh,
                    MaChucVu = nv.MaChucVu,
                    NgaySinh = nv.NgaySinh.Value,
                    TrangThai = nv.TrangThai
                };
                return nhanvien;
            }
            catch {  return null; }
        }
    }
}
