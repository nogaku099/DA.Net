using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class HoaDon
    {
        public HoaDon(String maHoaDon, DateTime ngayLap, float tongTien, String maNhanVien, String maBan, String trangThaiHoaDon)
        {
            this.MaHoaDon = maHoaDon;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
            this.MaNhanVien = maNhanVien;
            this.MaBan = maBan;
            this.TrangThaiHoaDon = trangThaiHoaDon;
        }
    }
}
