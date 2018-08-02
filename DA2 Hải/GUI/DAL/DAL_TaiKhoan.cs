using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    

    public class DAL_TaiKhoan:CONNECT
    {
       public List<TaiKhoan> layTaiKhoan()
        {
            try
            {
                var ketQua = (from tk in ketNoi.TaiKhoans select tk).ToList();
                return ketQua;
       
            }
            catch (Exception)
            {
                return null;
            }
        }

        
        public String layMaNhanVienTuTenTaiKhoan(String tenTaikhoan)
        {
            try
            {
                String maNhanVien = "";
                var ketQua = (from tk in ketNoi.TaiKhoans
                              where tk.TaiKhoan1 == tenTaikhoan
                              select tk).FirstOrDefault();
                maNhanVien = ketQua.MaNhanVien;
                return maNhanVien;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool them(TaiKhoan taiKhoan)
        {
            try
            {
                ketNoi.TaiKhoans.InsertOnSubmit(taiKhoan);
                ketNoi.SubmitChanges();
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool xoa(String maNhanVien)
        {
            try
            {
                var ketQua = (from tk in ketNoi.TaiKhoans
                             where tk.MaNhanVien == maNhanVien
                             select tk).FirstOrDefault();
                ketNoi.TaiKhoans.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

     
       public bool DangNhap(String userName, String passWords)
        {
            try
            {
                var result = from dangnhap in ketNoi.TaiKhoans
                             where (dangnhap.TaiKhoan1 == userName && dangnhap.MatKhau == passWords)
                             select dangnhap;
                if (result.Any())
                    return true;
                else
                    return false;
                        
           

            }
            catch
            {

                return false;
            }

            

        }



    }
}
