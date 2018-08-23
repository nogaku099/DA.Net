using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dal_SanPham = new DAL_SanPham();

        public List<SanPham> layDSSanPham()
        {
            return dal_SanPham.layDSSanPham();
        }

        public int demTongSanPham()
        {
            return dal_SanPham.demTongSanPham();
        }

        public List<SanPham> layDanhSachSanPham(int soDongBoQua, int soDongCanLay)
        {
            return dal_SanPham.layDanhSachSanPham(soDongBoQua, soDongCanLay);
        }

        public String layTenSPTheoMaSP(String maSP)
        {
            return dal_SanPham.layTenSPTheoMaSP(maSP);
        }

        public float layGiaSPTheoMaSP(String maSP)
        {
            return dal_SanPham.layGiaSPTheoMaSP(maSP);
        }
    }
}
