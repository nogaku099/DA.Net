using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LISTHOADON
    {
        public String tenSanPham;
        public float donGia;
        public int soLuong;
        public float thanhTien;

        public LISTHOADON(String tenSanPham,float donGia,int soLuong,float thanhTien)
        {
            this.tenSanPham = tenSanPham;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }
    }
}
