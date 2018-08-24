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

        public String taoMaHDMoi()
        {
            try
            {

                int count = ketNoi.HoaDons.Count() + 1;
                int month = Int32.Parse(DateTime.Now.Month.ToString());
                int year = Int32.Parse(DateTime.Now.Year.ToString());
                int tong = month + year;
                String ma = "HD00" + tong + count.ToString();
                return ma;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool capNhatTongTienHoaDonTheoMaHoaDon(String maHD, float tongTien)
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons
                              where item.MaHoaDon == maHD
                              select item).FirstOrDefault();
                ketQua.TongTien = tongTien;
                ketNoi.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool themHoaDon(HoaDon item)
        {
            try
            {
                ketNoi.HoaDons.InsertOnSubmit(item);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public HoaDon layHDTheoMaBanVaTrangThaiBusy(String maBan)
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons
                              where item.MaBan == maBan && item.TrangThaiHoaDon == "Chưa thanh toán"
                              select item).FirstOrDefault();
                return ketQua;
            }
            catch
            {
                return null;
            }
        }

        public List<HoaDon> layDanhSachHoaDon(int soDongBoQua, int soDongCanLay)
        {
            var ketQua = (from item in ketNoi.HoaDons.Skip(soDongBoQua).Take(soDongCanLay)
                          select item).ToList();

            return ketQua;
        }

    }
}
