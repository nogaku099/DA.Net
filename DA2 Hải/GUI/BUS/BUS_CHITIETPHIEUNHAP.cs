using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_CHITIETPHIEUNHAP
    {
        DAL_CHITIETPHIEUNHAP dal_chiTietPhieuNhap = new DAL_CHITIETPHIEUNHAP();

        public bool Them(ChiTietPhieuNhap item)
        {
            return dal_chiTietPhieuNhap.them(item);
        }
        public List<ChiTietPhieuNhap> LayChiTietPhieuNhap()
        {
            return dal_chiTietPhieuNhap.LayChiTietPhieuNhap();
        }
        public String taoMa()
        {
            return dal_chiTietPhieuNhap.taoMa();
        }
    }
}
