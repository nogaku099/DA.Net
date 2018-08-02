using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HOADON:CONNECT
    {
        public List<HoaDon> layHoaDon()
        {
            try
            {
                var ketQua = (from hoaDon in ketNoi.HoaDons select hoaDon).ToList();

                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public HoaDon layHoaDonTheoMaBan(String maBan)
        {
            try
            {
                var ketQua = (from hoadon in ketNoi.HoaDons where hoadon.MaBan == maBan && hoadon.TrangThai == "Chưa Thanh Toán" select hoadon).FirstOrDefault();
                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public bool xoaHoaDon(String maHoaDon)
        {
            try
            {
                var ketQua = (from hoadon in ketNoi.HoaDons
                              where hoadon.MaHoaDon == maHoaDon
                              select hoadon).FirstOrDefault();
                ketNoi.HoaDons.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChiTietHoaDon> layChiTietHoaDon(String maHoaDon)
        {
            try
            {
                var ketQua = (from tam in ketNoi.ChiTietHoaDons where tam.MaHoaDon == maHoaDon select tam).ToList();

                return ketQua;
                
            }
            catch (Exception)
            {
                return null;
            }

        }

        public String taoMa()
        {
            try
            {

                String id = Guid.NewGuid().ToString();


                return id;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool themHoaDon(HoaDon hoaDon)
        {
            try
            {
                ketNoi.HoaDons.InsertOnSubmit(hoaDon);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool capNhatHoaDon(HoaDon sanPham)
        {
            try
            {
                var result = from item in ketNoi.HoaDons
                             where item.MaHoaDon == sanPham.MaHoaDon
                             select item;

                foreach (var tam in result)
                {
                    tam.TrangThai = sanPham.TrangThai;
                    tam.MaNhanVien = sanPham.MaNhanVien;
                    
                }

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
