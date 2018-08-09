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
    }
}
