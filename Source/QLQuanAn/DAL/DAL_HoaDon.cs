using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : KetNoi
    {
        public List<HoaDon> layDSHoaDon()
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public HoaDon layHoaDonTheoMaHoaDon(String maHoaDon)
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons
                              where item.MaHoaDon == maHoaDon
                              select item).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool capNhatTrangThaiHoaDon(HoaDon hoaDon)
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons
                              where item.MaHoaDon == hoaDon.MaHoaDon
                              select item).FirstOrDefault();

                ketQua.TrangThaiHoaDon= hoaDon.TrangThaiHoaDon;
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
