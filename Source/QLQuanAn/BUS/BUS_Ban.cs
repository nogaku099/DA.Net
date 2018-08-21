using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Ban
    {
        DAL_Ban dal_Ban = new DAL_Ban();

        public List<Ban> layDSBan()
        {
            return dal_Ban.layDSBan();
        }

        public bool capNhatTrangThai(Ban banCapNhat)
        {
            return dal_Ban.capNhatTrangThai(banCapNhat);
        }

        public Ban layBanTheoMaBan(String maBan)
        {
            return dal_Ban.layBanTheoMaBan(maBan);
        }

        public int demTongBan()
        {
            return dal_Ban.demTongBan();
        }

        public List<Ban> layDanhSachBan(int soDongBoQua, int soDongCanLay)
        {
            return dal_Ban.layDanhSachBan(soDongBoQua, soDongCanLay);
        }
    }
}
