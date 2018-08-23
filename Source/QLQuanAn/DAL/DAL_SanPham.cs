using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham : KetNoi
    {
        public List<SanPham> layDSSanPham()
        {
            try
            {
                var ketQua = (from sanPham in ketNoi.SanPhams select sanPham).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int demTongSanPham()
        {
            try
            {
                int count = 0;
                count = ketNoi.SanPhams.Count();
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public List<SanPham> layDanhSachSanPham(int soDongBoQua, int soDongCanLay)
        {
            var ketQua = (from item in ketNoi.SanPhams.Skip(soDongBoQua).Take(soDongCanLay)
                          select item).ToList();

            return ketQua;
        }

        public String layTenSPTheoMaSP(String maSP)
        {
            try
            {
                var ketQua = (from item in ketNoi.SanPhams
                              where item.MaSanPham == maSP
                              select item).FirstOrDefault().TenSanPham;
                return ketQua;
            }
            catch
            {
                return null;
            }
        }

        public float layGiaSPTheoMaSP(String maSP)
        {
            try
            {
                var ketQua = (from item in ketNoi.SanPhams
                              where item.MaSanPham == maSP
                              select item).FirstOrDefault().GiaSanPham;
                return float.Parse(ketQua.ToString());
            }
            catch
            {
                return 0;
            }
        }

    }
}
