using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NhaCungCap
    {
        public NhaCungCap(String maNhaCungCap, String teNhaCungCap, String dienThoai,String diaChi,String maNguyenLieu, float giaNhap)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNhaCungCap = teNhaCungCap;
            this.DiaChiNhaCungCap = diaChi;
            this.DienThoaiNhaCungCap = dienThoai;
            this.MaNhaCungCap = maNhaCungCap;
            this.GiaNhap = giaNhap;
        }
    }
}
