using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class ChiTietSanPham
    {
        public ChiTietSanPham(String maChiTietSanPham, String maSanPham, String maNguyenLieu, int soLuongSuDung)
        {
            this.MaChiTietSanPham = maChiTietSanPham;
            this.MaSanPham = maSanPham;
            this.MaNguyenLieu = maNguyenLieu;
            this.SoLuongDung = soLuongSuDung;
        }
    }
}
