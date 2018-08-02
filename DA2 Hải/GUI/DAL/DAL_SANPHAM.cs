using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SANPHAM:CONNECT
    {
        public List<SanPham> laySanPham()
        {
            var ketQua = (from sanPham in ketNoi.SanPhams select sanPham).ToList();
            return ketQua;
        }

        public SanPham laySanPhanTheoMa(String maSanPham)
        {
            var ketQua = (from sanPham in ketNoi.SanPhams
                         where sanPham.MaSanPham == maSanPham
                         select sanPham).FirstOrDefault();
            return ketQua;
        }
        public List<SanPham> laySanPhamTrangDau()
        {
            var ketQua = (from sanPham in ketNoi.SanPhams select sanPham).Take(6).ToList();
            return ketQua;
        }
        public bool themSanPham(SanPham sanpham)
        {
            try
            {      
                ketNoi.SanPhams.InsertOnSubmit(sanpham);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;   
            }
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

        public List<SanPham> laySanPhamTheoTrang(int boQua, int lay)
        {
            try
            {
                var ketQua = (from sanPham in ketNoi.SanPhams
                              select sanPham).Skip(boQua).Take(lay).ToList();

                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool xoaSanPham(String maSanPham)
        {
            try
            {
                var ketQua = (from sanPham in ketNoi.SanPhams
                             where sanPham.MaSanPham == maSanPham
                             select sanPham).FirstOrDefault();

                ketNoi.SanPhams.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool capNhatSanPham(SanPham sanPham)
        {
            try
            {
                var result = from item in ketNoi.SanPhams
                              where item.MaSanPham == sanPham.MaSanPham
                              select item;

                foreach(var tam in result)
                {
                    tam.GiaSanPham = sanPham.GiaSanPham;
                    tam.LoaiSanPham = sanPham.LoaiSanPham;
                    tam.TenSanPham = sanPham.TenSanPham;
                    tam.DuongDan = sanPham.DuongDan;                      
                }

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
