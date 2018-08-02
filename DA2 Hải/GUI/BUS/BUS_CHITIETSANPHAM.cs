using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_CHITIETSANPHAM
    {
        DAL_CHITIETSANPHAM dal_chiTietSanPham = new DAL_CHITIETSANPHAM();

        public List<ChiTietSanPham> layChiTietSanPhamTheoMaSanPham(String maSanPham)
        {
            return dal_chiTietSanPham.layChiTietSanPhamTheoMaSanPham(maSanPham);
        }
        public List<ChiTietSanPham> layListChiTietSanPhamTheoMaSanPham(String maSanpham)
        {
            return dal_chiTietSanPham.layListChiTietSanPhamTheoMaSanPham(maSanpham);
        }
        public String taoMa()
        {
            return dal_chiTietSanPham.taoMa();
        }
        public bool themChiTietSanPham(ChiTietSanPham chitiet)
        {
            return dal_chiTietSanPham.themChiTietSanPham(chitiet);
        }
    }
}

