using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDon:KetNoi
    {
        public List<ChiTietHoaDon> layDSChiTietHoaDonTheoMaHoaDon(String maHoaDon)
        {
            try
            {
                var ketQua = (from item in ketNoi.ChiTietHoaDons
                              where item.MaHoaDon == maHoaDon
                              select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool chinhSuaSoLuongChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                var ketQua = (from item in ketNoi.ChiTietHoaDons
                              where item.MaHoaDon == chiTietHoaDon.MaHoaDon && item.MaChiTietHoaDon == chiTietHoaDon.MaChiTietHoaDon
                              select item);

                foreach (var tam in ketQua)
                {

                    tam.SoLuong = chiTietHoaDon.SoLuong;
                    tam.MaHoaDon = chiTietHoaDon.MaHoaDon;
                    tam.MaSanPham = chiTietHoaDon.MaSanPham;

                }

                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public String taoMaCTHDMoi()
        {
            try
            {

                int count = ketNoi.ChiTietHoaDons.Count() + 1;
                int month = Int32.Parse(DateTime.Now.Month.ToString());
                int year = Int32.Parse(DateTime.Now.Year.ToString());
                int tong = month + year;
                String ma = "CTHD00" + tong + count.ToString();
                return ma;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool themCTHoaDon(ChiTietHoaDon item)
        {
            try
            {
                ketNoi.ChiTietHoaDons.InsertOnSubmit(item);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool themDSChiTietHoaDon(List<ChiTietHoaDon> lstItem)
        {
            try
            {
                foreach(ChiTietHoaDon item in lstItem)
                {
                    ketNoi.ChiTietHoaDons.InsertOnSubmit(item);
                    ketNoi.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
