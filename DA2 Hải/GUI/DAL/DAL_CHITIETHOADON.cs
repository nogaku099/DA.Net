using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CHITIETHOADON:CONNECT
    {
        public bool themChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            int i = 0;
            try
            {
                

                var ketQua = (from chitiet in ketNoi.ChiTietHoaDons select chitiet).ToList();
                foreach (var tam in ketQua)
                {
                    if(tam.MaHoaDon == chiTietHoaDon.MaHoaDon &&tam.MaSanPham == chiTietHoaDon.MaSanPham)
                    {
                        i = 1;
                        tam.SoLuong = tam.SoLuong + 1;
                    }
               
                }

                if(i==0)
                {
                    ketNoi.ChiTietHoaDons.InsertOnSubmit(chiTietHoaDon);
                    ketNoi.SubmitChanges();
                }
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
            
           
        }

        public bool capNhat(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                var ketQua = (from chitiet in ketNoi.ChiTietHoaDons
                              where chitiet.MaChiTietHoaDon == chiTietHoaDon.MaChiTietHoaDon
                              select chitiet);

                foreach(var tam in ketQua)
                {
                 
                    tam.SoLuong = chiTietHoaDon.SoLuong;
                    tam.MaHoaDon = chiTietHoaDon.MaHoaDon;
                    tam.MaSanPham = chiTietHoaDon.MaSanPham;
                  
                }

                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ChiTietHoaDon laySanPhanTheoMa(String maChiTietHoaDon)
        {
            var ketQua = (from sanPham in ketNoi.ChiTietHoaDons
                          where sanPham.MaChiTietHoaDon == maChiTietHoaDon
                          select sanPham).FirstOrDefault();
            return ketQua;
        }

        public String taoMa()
        {
            try
            {

                String id = Guid.NewGuid().ToString();

                
                return id;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
