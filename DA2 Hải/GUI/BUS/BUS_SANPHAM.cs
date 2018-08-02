using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_SANPHAM
    {
        DAL_SANPHAM dal_sanPham = new DAL_SANPHAM();

        public List<SanPham> laySanPham()
        {
            return dal_sanPham.laySanPham();
        }

        public bool capNhatSanPham(SanPham sanPham)
        {
            return dal_sanPham.capNhatSanPham(sanPham);
        }
        public List<SanPham> laySanPhamTheoTrang(int boQua, int lay)
        {
            return dal_sanPham.laySanPhamTheoTrang(boQua, lay);
        }
        public SanPham laySanPhanTheoMa(String maSanPham)
        {
            return dal_sanPham.laySanPhanTheoMa(maSanPham);
        }
        public List<SanPham> laySanPhamTrangDau()
        {
            return dal_sanPham.laySanPhamTrangDau();
        }
        public String taoMaSanPham()
        {
            return dal_sanPham.taoMa();
        }
        public bool themSanPham(SanPham sanpham)
        {
            return dal_sanPham.themSanPham(sanpham);
        }
        public bool xoaSanPham(String maSanPham)
        {
            return dal_sanPham.xoaSanPham(maSanPham);
        }

    }
}
