using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan : KetNoi
    {
        public List<TaiKhoan> layDSTaiKhoan()
        {
            try
            {
                var ketQua = (from taiKhoan in ketNoi.TaiKhoans select taiKhoan).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public String layMaNhanVien(String taiKhoan)
        {
            try
            {
                var ketQua = (from item in ketNoi.TaiKhoans
                              where item.TaiKhoan1 == taiKhoan
                              select item).FirstOrDefault().MaNhanVien;
                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool thayDoiMatKhauBangMK2(String taiKhoan, String matKhau2, String matKhauMoi)
        {
            try
            {
                var ketQua = (from item in ketNoi.TaiKhoans
                              where item.TaiKhoan1 == taiKhoan
                              select item).FirstOrDefault();


                if (ketQua.MatKhau2 == matKhau2)
                {
                    ketQua.MatKhau = matKhauMoi;
                    ketNoi.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                

               
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool kiemTraTaiKhoanCoTonTai(String taiKhoan)
        {
            try
            {
                var ketQua = (from item in ketNoi.TaiKhoans
                              where item.TaiKhoan1 == taiKhoan
                              select item).Any();
                if (ketQua)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool kiemTraMatKhau2(String taiKhoan, String matKhau2)
        {
            try
            {
                var ketQua = (from item in ketNoi.TaiKhoans
                              where item.TaiKhoan1 == taiKhoan && item.MatKhau2 == matKhau2
                              select item).Any();
                if (ketQua)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool dangNhap(String taiKhoan, String matKhau)
        {
            try
            {
                var ketQua = (from item in ketNoi.TaiKhoans
                              where item.TaiKhoan1 == taiKhoan && item.MatKhau == matKhau
                              select item);
                if (ketQua.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
