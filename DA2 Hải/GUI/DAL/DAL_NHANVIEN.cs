using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NHANVIEN:CONNECT
    {
        public List<NhanVien> layNhanVien()
        {
            try
            {
                var result = (from nhanVien in ketNoi.NhanViens select nhanVien).ToList();
                return result;

                
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool themNhanVien(NhanVien nhanVien)
        {
            try
            {
                ketNoi.NhanViens.InsertOnSubmit(nhanVien);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool xoaNhanVien(String manhanVien)
        {
            try
            {
                var result = from nhanvien in ketNoi.NhanViens
                             where nhanvien.MaNhanVien == manhanVien
                             select nhanvien;
                foreach(var tam in result)
                {
                    ketNoi.NhanViens.DeleteOnSubmit(tam);
                }
                
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool isManager(String maNhanVien)
        {
            try
            {
                var ketQua = (from nv in ketNoi.NhanViens where nv.MaNhanVien == maNhanVien select nv).FirstOrDefault();
                if (ketQua.ChucVu == "Quan Ly")
                {
                    return true;
                }
                else return false;
             
            }
            catch (Exception)
            {
                return false;
            }
        }
        public String taoMa()
        {
            try
            {

                int count = ketNoi.NhanViens.Count() + 1;
              
                int moth = Int32.Parse(DateTime.Now.Month.ToString());
                int year = Int32.Parse(DateTime.Now.Year.ToString());
                int tong = moth + year;
                String ma = "NV00" +tong+ count.ToString();
                return ma;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool capNhatNhanVien(NhanVien nhanVien)
        {
            try
            {
                var result = (from tam in ketNoi.NhanViens
                             where tam.MaNhanVien == nhanVien.MaNhanVien
                             select tam).FirstOrDefault();

                result.TenNhanVien = nhanVien.TenNhanVien;
                result.DiaChi = nhanVien.DiaChi;
                result.ChucVu = nhanVien.ChucVu;
                result.NgaySinh = nhanVien.NgaySinh;
                result.SoDienThoai = nhanVien.SoDienThoai;

                ketNoi.SubmitChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
