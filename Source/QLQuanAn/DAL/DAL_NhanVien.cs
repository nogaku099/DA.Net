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

        public int demTongNhanVien()
        {
            try
            {
                int count = 0;
                count = ketNoi.NhanViens.Count();
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public List<NhanVien> layDanhSachNhanVien(int soDongBoQua, int soDongCanLay)
        {
            var ketQua = (from item in ketNoi.NhanViens.Skip(soDongBoQua).Take(soDongCanLay)
                          select item).ToList();

            return ketQua;
        }

        public String taoMaNhanVienMoi()
        {
            try
            {

                int count = ketNoi.NhanViens.Count() + 1;
                int month = Int32.Parse(DateTime.Now.Month.ToString());
                int year = Int32.Parse(DateTime.Now.Year.ToString());
                int tong = month + year;
                String ma = "NV00" + tong + count.ToString();
                return ma;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool themNhanVien(NhanVien nhanVienMoi)
        {
            try
            {
                ketNoi.NhanViens.InsertOnSubmit(nhanVienMoi);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool capNhatNhanVien(NhanVien nhanVien)
        {
            try
            {
                var ketQua = (from item in ketNoi.NhanViens
                              where item.MaNhanVien == nhanVien.MaNhanVien
                              select item).FirstOrDefault();

                ketQua.TenNhanVien = nhanVien.TenNhanVien;
                ketQua.DiaChi = nhanVien.DiaChi;
                ketQua.ChucVu = nhanVien.ChucVu;
                ketQua.NgaySinh = nhanVien.NgaySinh;
                ketQua.SoDienThoai = nhanVien.SoDienThoai;

                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
