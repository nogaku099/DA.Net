using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class ChiTietHoaDon:CONNECT
    {
        public ChiTietHoaDon(String maChiTietHoaDon,String maHoaDon,String maSanPham, int soLuong)
        {
            this.MaChiTietHoaDon = maChiTietHoaDon;
            this.MaHoaDon = maHoaDon;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
        }
    }
}
