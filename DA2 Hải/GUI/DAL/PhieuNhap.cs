using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class PhieuNhap
    {
        public PhieuNhap(String maPhieuLap, DateTime ngayLap, float tongTien, String maNhanVien)
        {
            this.MaNhanVien = maNhanVien;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
            this.MaPhieuNhap = maPhieuLap;
        }
    }
}
