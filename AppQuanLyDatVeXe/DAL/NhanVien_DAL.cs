using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
                      where nv.TrangThai.Contains("Hoạt động")
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
                          MaChucVu= nv.MaChucVu,
                      };


            return tbl.ToList();
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

        public object getNhanViens(string text)
        {
            var tbl = from nv in qldvx.NhanViens
                      where nv.TenNV.Contains(text) 
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
                          MaChucVu = nv.MaChucVu,
                      };


            return tbl.ToList();
        }

        public bool ThemNhanVien(NhanVien_DTO nhanvien)
        {
            try
            {
                DateTime current = DateTime.Now;
                TaiKhoan tk = new TaiKhoan();
                tk.ID = "NV" + current.ToString("HHmm");
                tk.UserName = tk.ID;
                tk.Pass = tk.ID;
                tk.Quyen = "NV";
                tk.TrangThai = "Hoạt động";
                qldvx.TaiKhoans.InsertOnSubmit(tk);
                qldvx.SubmitChanges();

                Console.WriteLine($"Ngày sinh: {nhanvien.NgaySinh}");
                NhanVien newNhanVien = new NhanVien
                {
                    MaNV = tk.ID,
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
        public bool SuaNhanVien(NhanVien_DTO nv)
        {
            try
            {
                NhanVien suaNhanVien = qldvx.NhanViens.FirstOrDefault(n => n.MaNV == nv.MaNV);

                suaNhanVien.TenNV = nv.HoTen;
                suaNhanVien.NgaySinh = nv.NgaySinh;
                suaNhanVien.GioiTinh = nv.GioiTinh;
                suaNhanVien.CCCD = nv.CCCD;
                suaNhanVien.SDT = nv.SDT;
                suaNhanVien.Luong = nv.Luong;
                suaNhanVien.TrangThai = nv.TrangThai;
                suaNhanVien.MaChucVu = nv.MaChucVu;

                qldvx.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa nhân viên: " + ex.Message); // Log lỗi
                return false;
            }
        }
        public bool XoaNhanVien(NhanVien_DTO nv)
        {
            try
            {
                NhanVien xoaNhanVien = qldvx.NhanViens.FirstOrDefault(n => n.MaNV == nv.MaNV);

                xoaNhanVien.TrangThai = "Hủy";
                qldvx.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi hủy tài khoản nhân viên: " + ex.Message); // Log lỗi
                return false;
            }
        }

        public bool doiMatKhau(string mkCu, string mkMoi, string maNV)
        {
            try
            {
                var nv = qldvx.TaiKhoans.Where(t=>t.ID == maNV).FirstOrDefault();
                if (nv != null)
                {
                    if(nv.Pass == mkCu)
                    {
                        nv.Pass = mkMoi;

                        qldvx.SubmitChanges();
                        return true;
                    }
                    return false;
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
