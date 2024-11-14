using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhanVien_DTO
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public float Luong { get; set; }
        public string TrangThai { get; set; }
        public int MaChucVu { get; set; }
    }
}
