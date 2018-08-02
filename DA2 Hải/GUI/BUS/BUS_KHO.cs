using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_KHO
    {
        DAL_KHO dal_Kho = new DAL_KHO();


        public List<KHO> layKho()
        {
            return dal_Kho.layKho();

        }

        public bool capNhatSoLuongTonKho(String maNguyenLieu, int soLuong)
        {
            return dal_Kho.capNhatKhoNguyenLieu(maNguyenLieu, soLuong);
        }
        public bool kiemTraSoLuongTon(String maNguyenLieu, int soLuong)
        {
            return dal_Kho.kiemTraSoLuongTon(maNguyenLieu,soLuong);
        }

        public bool xoa(String maNguyenLieu)
        {
            return dal_Kho.xoa(maNguyenLieu);
        }

        public bool them(KHO kho)
        {
            return dal_Kho.them(kho);
        }

        public bool CapNhat(KHO kho)
        {
            return dal_Kho.CapNhat(kho);
        }
        public String taoMa()
        {
            return dal_Kho.taoMa();
        }

    }
}
