using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class ChiTietHoaDon
    {
        public ChiTietHoaDon(String maChiTietHoaDon, String maHoaDon, String maSanPham, int soLuong, float thanhTien)
        {
            this.MaChiTietHoaDon = maChiTietHoaDon;
            this.MaHoaDon = maHoaDon;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
    }
}
