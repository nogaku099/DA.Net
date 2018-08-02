using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NhanVien:CONNECT
    {
        public NhanVien(String maNhanVien,String tenNhanVien, String ngaySinh, String diaChi, String chucVu,String soDienThoai)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.ChucVu = chucVu;
            this.SoDienThoai = soDienThoai;
        }
    }
}
