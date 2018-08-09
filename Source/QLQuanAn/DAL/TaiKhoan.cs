using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class TaiKhoan
    {
        public TaiKhoan(String taiKhoan, String matKhau, String maNhanVien, String matKhau2)
        {
            this.TaiKhoan1 = taiKhoan;
            this.MatKhau = matKhau;
            this.MaNhanVien = maNhanVien;
            this.MatKhau2 = matKhau2;
        }
    }
}
