using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_PHIEUNHAP
    {
        DAL_PHIEUNHAP dal_phieuNhap = new DAL_PHIEUNHAP();

        public bool Them(PhieuNhap item)
        {
            return dal_phieuNhap.Them(item);
        }
        public List<PhieuNhap> LayPhieuNhap()
        {
            return dal_phieuNhap.LayPhieuNhap();
        }
        public String taoMa()
        {
            return dal_phieuNhap.taoMa();
        }
    }
}
