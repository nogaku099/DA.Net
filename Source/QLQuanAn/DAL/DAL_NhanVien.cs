using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien : KetNoi
    {
        public List<NhanVien> layDSNhanVien()
        {
            try
            {
                var ketQua = (from item in ketNoi.NhanViens select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public NhanVien layNVTheoMaNV(String maNhanVien)
        {
            try
            {
                var ketQua = (from item in ketNoi.NhanViens
                              where item.MaNhanVien == maNhanVien
                              select item).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
