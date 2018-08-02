using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap(String maChiTietPhieuNhap, String maNguyenLieu, int soLuong, String maNhaCungCap,String maPhieuNhap)
        {
            this.MaChiTietPhieuNhap = maChiTietPhieuNhap;
            this.MaNguyenLieu = maNguyenLieu;
            this.SoLuong = soLuong;
            this.MaNhaCungCap = maNhaCungCap;
            this.MaPhieuNhap = maPhieuNhap;
        }
    }
}
