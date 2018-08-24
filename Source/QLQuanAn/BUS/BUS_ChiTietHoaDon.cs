using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dal_ChiTietHoaDon = new DAL_ChiTietHoaDon();

        public String taoMaCTHDMoi()
        {
            return dal_ChiTietHoaDon.taoMaCTHDMoi();
        }

        public bool themCTHoaDon(ChiTietHoaDon item)
        {
            return dal_ChiTietHoaDon.themCTHoaDon(item);
        }

        public bool themDSChiTietHoaDon(List<ChiTietHoaDon> lstItem)
        {
            return dal_ChiTietHoaDon.themDSChiTietHoaDon(lstItem);
        }

        public List<ChiTietHoaDon> layDSChiTietHoaDonTheoMaHoaDon(String maHoaDon)
        {
            return dal_ChiTietHoaDon.layDSChiTietHoaDonTheoMaHoaDon(maHoaDon);
        }

        public bool xoaChiTietHoaDonTheoMaHoaDon(String maHD)
        {
            return dal_ChiTietHoaDon.xoaChiTietHoaDonTheoMaHoaDon(maHD);
        }

        public String taoMaCTHDMoiUpdate()
        {
            return dal_ChiTietHoaDon.taoMaCTHDMoiUpdate();
        }

        public bool chinhSuaSoLuongChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            return dal_ChiTietHoaDon.chinhSuaSoLuongChiTietHoaDon(chiTietHoaDon);
        }

        public bool xoaCTHD(ChiTietHoaDon chiTietHoaDon)
        {
            return dal_ChiTietHoaDon.xoaCTHD(chiTietHoaDon);
        }

        public List<ChiTietHoaDon> layDanhSachChiTietHoaDon(int soDongBoQua, int soDongCanLay)
        {
            return dal_ChiTietHoaDon.layDanhSachChiTietHoaDon(soDongBoQua, soDongCanLay);
        }
    }


}
