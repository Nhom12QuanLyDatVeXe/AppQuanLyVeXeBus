﻿using System;
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


        public List<TuyenXe_DTO> GetTuyenXe()
        {

            var tbl = from tx in qldvx.TuyenXes
                      select new TuyenXe_DTO
                      {

                          MaTuyenXe = tx.MaTuyenXe,
                          TenTuyen = tx.TenTuyen,
                          ThoiGianDi = tx.ThoiGianDi.Value, // Default if null
                          DiemDi = tx.DiemDi,
                          DiemDen = tx.DiemDen,
                          GioXuatBen = tx.GioXuatBen.Value,
                          GioDenNoi = tx.GioDenNoi.Value,
                          KhoangCach = tx.KhoangCach,
                          DonGia = tx.DonGia,
                          BienSoXe = tx.BienSoXe,

                      };


            return tbl.ToList();
        }
    }
}