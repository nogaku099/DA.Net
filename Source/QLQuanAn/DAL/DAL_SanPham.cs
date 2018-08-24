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

        public String taoMaSPMoi()
        {
            try
            {

                int count = ketNoi.SanPhams.Count() + 1;
                int month = Int32.Parse(DateTime.Now.Month.ToString());
                int year = Int32.Parse(DateTime.Now.Year.ToString());
                int tong = month + year;
                String ma = "SP00" + tong + count.ToString();
                return ma;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool themSanPham(SanPham sanPham)
        {
            try
            {
                ketNoi.SanPhams.InsertOnSubmit(sanPham);
                ketNoi.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SanPham laySanPhamTheoMaSP(String maSP)
        {
            try
            {
                var ketQua = (from item in ketNoi.SanPhams
                              where item.MaSanPham == maSP
                              select item).FirstOrDefault();
                return ketQua;
            }
            catch
            {
                return null;
            }
        }

        public bool capNhatSanPham(SanPham sanPham)
        {
            try
            {
                var ketQua = (from item in ketNoi.SanPhams
                              where item.MaSanPham == sanPham.MaSanPham
                              select item).FirstOrDefault();
                ketQua.TenSanPham = sanPham.TenSanPham;
                ketQua.GiaSanPham = sanPham.GiaSanPham;
                ketQua.LoaiSanPham = sanPham.LoaiSanPham;
                ketNoi.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

    }
}
