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
    }
}
