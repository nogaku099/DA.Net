using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_HOADON
    {
        DAL_HOADON dal_hoaDon = new DAL_HOADON();
        public List<ChiTietHoaDon> layChiTietHoaDon(String maHoaDon)
        {
            return dal_hoaDon.layChiTietHoaDon(maHoaDon);
        }
        public List<HoaDon> layHoaDon()
        {
            return dal_hoaDon.layHoaDon();
        }
        public HoaDon layHoaDonTheoMaBan(String maBan)
        {
            return dal_hoaDon.layHoaDonTheoMaBan(maBan);
        }
        public bool capNhatHoaDon(HoaDon sanPham)
        {
            return dal_hoaDon.capNhatHoaDon(sanPham);
        }
        public String taoMa()
        {
            return dal_hoaDon.taoMa();
        }
        public bool themHoaDon(HoaDon hoadon)
        {
            return dal_hoaDon.themHoaDon(hoadon);
        
        }
        public bool xoaHoaDon(String hoadon)
        {
            return dal_hoaDon.xoaHoaDon(hoadon);
        }
    }
}
