using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        QlyDatVeXeDataContext qldvx = new QlyDatVeXeDataContext();

        public int AddAccount(TaiKhoan_DTO acc)
        {
            try
            {
                var tbl = qldvx.KhachHangs.ToList();
                var new_acc = new TaiKhoan
                {
                    ID = "KH" + (tbl.Count + 1).ToString(),
                    UserName = acc.UserName,
                    Pass = acc.PassWord,
                    Quyen = "KH",
                    TrangThai = "Tài khoản mới"
                };
                qldvx.TaiKhoans.InsertOnSubmit(new_acc);
                var new_KH = new KhachHang
                { 
                    MaKH = new_acc.ID
                };
                qldvx.KhachHangs.InsertOnSubmit(new_KH);

                qldvx.SubmitChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public int CheckAccount(TaiKhoan_DTO acc)
        {
            var tbl = qldvx.TaiKhoans.Where(t => t.UserName == acc.UserName).FirstOrDefault();
            if (tbl != null)
                return 1;
            return 0;
        }

        public int checkLogin(TaiKhoan_DTO acc)
        {
            try
            {
                var tbl = qldvx.TaiKhoans.Where(t => t.UserName == acc.UserName && t.Pass == acc.PassWord).FirstOrDefault();
                if(tbl != null)
                {
                    if (tbl.TrangThai == "Hoạt động" && tbl.Quyen == "NV" || tbl.Quyen == "Admin")
                        return 1;
                }
                return 0;
            }
            catch(Exception ex) { return -1;}
            
        }

        public TaiKhoan_DTO getAccount(string userName)
        {
            var tbl = qldvx.TaiKhoans.Where(t => t.UserName == userName).FirstOrDefault();
            TaiKhoan_DTO acc = new TaiKhoan_DTO
            {
                ID = tbl.ID,
                UserName = tbl.UserName,
                PassWord = tbl.Pass,
                Quyen = tbl.Quyen,
                TrangThai = tbl.TrangThai
            };
            return acc;
        }
    }
}
