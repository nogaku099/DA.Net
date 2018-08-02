using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN dal_nhanVien = new DAL_NHANVIEN();
        public List<NhanVien> layNhanVien()
        {
            return dal_nhanVien.layNhanVien();

        }

        public bool isManager(String maNhanVien)
        {
            return dal_nhanVien.isManager(maNhanVien);
        }
        public bool xoaNhanVien(String manhanVien)
        {
            return dal_nhanVien.xoaNhanVien(manhanVien);
        }
        public bool themNhanVien(NhanVien nhanVien)
        {
            return dal_nhanVien.themNhanVien(nhanVien);
        }
        public String taoMa()
        {
            return dal_nhanVien.taoMa();
        }

        public bool capNhatNhanVien(NhanVien nhanVien)
        {
            return dal_nhanVien.capNhatNhanVien(nhanVien);
        }
    }
}
