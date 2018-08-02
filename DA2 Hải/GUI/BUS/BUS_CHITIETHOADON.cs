using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    
    public class BUS_CHITIETHOADON
    {
        DAL_CHITIETHOADON dal_chiTietHoaDon = new DAL_CHITIETHOADON();

        public bool themChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            return dal_chiTietHoaDon.themChiTietHoaDon(chiTietHoaDon);
        }

        public String taoMa()
        {
            return dal_chiTietHoaDon.taoMa();
        }
        public ChiTietHoaDon laySanPhanTheoMa(String maChiTietHoaDon)
        {
            return dal_chiTietHoaDon.laySanPhanTheoMa(maChiTietHoaDon);
        }
        public bool capNhat(ChiTietHoaDon chiTietHoaDon)
        {
            return dal_chiTietHoaDon.capNhat(chiTietHoaDon);
        }
    }
}
