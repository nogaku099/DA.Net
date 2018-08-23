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
    }


}
