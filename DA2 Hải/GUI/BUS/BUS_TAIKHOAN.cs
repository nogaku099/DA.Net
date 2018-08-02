using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_TAIKHOAN
    {
        DAL_TaiKhoan dal_taiKhoan = new DAL_TaiKhoan();

        public bool DangNhap(String username,String passWord)
        {
            return dal_taiKhoan.DangNhap(username,passWord);
        }

        public bool them(TaiKhoan tk)
        {
            return dal_taiKhoan.them(tk);
        }
        public bool xoa(String maNhanVien)
        {
            return dal_taiKhoan.xoa(maNhanVien);
        }
        public List<TaiKhoan> layTaiKhoan()
        {
            return dal_taiKhoan.layTaiKhoan();
        }
        public String layMaNhanVienTuTenTaiKhoan(String tenTaikhoan)
        {
            return dal_taiKhoan.layMaNhanVienTuTenTaiKhoan(tenTaikhoan);
        }



    }
}
