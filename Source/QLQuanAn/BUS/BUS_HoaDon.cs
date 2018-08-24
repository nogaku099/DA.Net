using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();

        public HoaDon layHoaDonTheoMaHoaDon(String maHoaDon)
        {
            return dal_HoaDon.layHoaDonTheoMaHoaDon(maHoaDon);
        }

        public List<HoaDon> layDSHoaDon()
        {
            return dal_HoaDon.layDSHoaDon();
        }

        public bool capNhatTrangThaiHoaDon(HoaDon hoaDon)
        {
            return dal_HoaDon.capNhatTrangThaiHoaDon(hoaDon);
        }

        public String taoMaHDMoi()
        {
            return dal_HoaDon.taoMaHDMoi();
        }

        public bool themHoaDon(HoaDon item)
        {
            return dal_HoaDon.themHoaDon(item);
        }

        public HoaDon layHDTheoMaBanVaTrangThaiBusy(String maBan)
        {
            return dal_HoaDon.layHDTheoMaBanVaTrangThaiBusy(maBan);
        }

        public bool capNhatTongTienHoaDonTheoMaHoaDon(String maHD, float tongTien)
        {
            return dal_HoaDon.capNhatTongTienHoaDonTheoMaHoaDon(maHD, tongTien);
        }

        public List<HoaDon> layDanhSachHoaDon(int soDongBoQua, int soDongCanLay)
        {
            return dal_HoaDon.layDanhSachHoaDon(soDongBoQua, soDongCanLay);
        }
    }
}
