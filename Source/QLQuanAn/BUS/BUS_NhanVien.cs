using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();

        public NhanVien layNVTheoMaNV(String maNhanVien)
        {
            return dal_NhanVien.layNVTheoMaNV(maNhanVien);
        }
        public List<NhanVien> layDSNhanVien()
        {
            return dal_NhanVien.layDSNhanVien();
        }

        public int demTongNhanVien()
        {
            return dal_NhanVien.demTongNhanVien();
        }

        public List<NhanVien> layDanhSachNhanVien(int soDongBoQua, int soDongCanLay)
        {
            return dal_NhanVien.layDanhSachNhanVien(soDongBoQua,soDongCanLay);
        }

        public String taoMaNhanVienMoi()
        {
            return dal_NhanVien.taoMaNhanVienMoi();
        }

        public bool themNhanVien(NhanVien nhanVienMoi)
        {
            return dal_NhanVien.themNhanVien(nhanVienMoi);
        }

        public bool capNhatNhanVien(NhanVien nhanVien)
        {
            return dal_NhanVien.capNhatNhanVien(nhanVien);
        }
    }
}
