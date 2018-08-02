using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class SanPham:CONNECT
    {
        public SanPham(String maSanPham,String tenSanPham,String loaiSanPham,String duongDan,float giaSanPham)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.GiaSanPham = giaSanPham;
            this.LoaiSanPham = loaiSanPham;
            this.DuongDan = duongDan;
         
      
        }
    }
}
