using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();

        public List<TaiKhoan> layDSTaiKhoan()
        {
            return dal_TaiKhoan.layDSTaiKhoan();
        }

        public bool dangNhap(String taiKhoan, String matKhau)
        {
            return dal_TaiKhoan.dangNhap(taiKhoan,matKhau);
        }

        public String layMaNhanVien(String taiKhoan)
        {
            return dal_TaiKhoan.layMaNhanVien(taiKhoan);
        }

        public bool thayDoiMatKhauBangMK2(String taiKhoan, String matKhau2, String matKhauMoi)
        {
            return dal_TaiKhoan.thayDoiMatKhauBangMK2(taiKhoan, matKhau2, matKhauMoi);
        }

        public bool kiemTraTaiKhoanCoTonTai(String taiKhoan)
        {
            return dal_TaiKhoan.kiemTraTaiKhoanCoTonTai(taiKhoan);
        }

        public bool kiemTraMatKhau2(String taiKhoan, String matKhau2)
        {
            return dal_TaiKhoan.kiemTraMatKhau2(taiKhoan, matKhau2);
        }
    }
}
