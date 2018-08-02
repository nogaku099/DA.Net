using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_NGUYENLIEU
    {
        DAL_NGUYENLIEU dal_NguyenLieu = new DAL_NGUYENLIEU();
        public List<NguyenLieu> layNguyenLieu()
        {
            return dal_NguyenLieu.layNguyenLieu();

        }

        public NguyenLieu layNguyenLieuTheoMa(String maNguyenLieu)
        {
            return dal_NguyenLieu.layNguyenLieuTheoMa(maNguyenLieu);
        }

        public String taoMa()
        {
            return dal_NguyenLieu.taoMa();
        }
        public bool CapNhat(NguyenLieu nguyenLieu)
        {
            return dal_NguyenLieu.CapNhat(nguyenLieu);
        }

        public bool xoa(String maNguyenLieu)
        {
            return dal_NguyenLieu.xoa(maNguyenLieu);
        }

        public bool them(NguyenLieu nguyenLieu)
        {
            return dal_NguyenLieu.them(nguyenLieu);
        }
    }
}
