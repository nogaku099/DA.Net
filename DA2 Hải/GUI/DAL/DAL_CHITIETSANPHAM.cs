using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CHITIETSANPHAM:CONNECT
    {
        public List<ChiTietSanPham> layChiTietSanPhamTheoMaSanPham(String maSanPham)
        {
           
            try
            {
                var ketQua = (from chiTiet in ketNoi.ChiTietSanPhams
                              where chiTiet.MaSanPham == maSanPham
                              select chiTiet).ToList();

                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }

         
        }



        public List<ChiTietSanPham> layListChiTietSanPhamTheoMaSanPham(String maSanPham)
        {

            List<ChiTietSanPham> listNguyenLieu = null;


            try
            {
                var ketQua = (from nguyenlieu in ketNoi.ChiTietSanPhams
                             where nguyenlieu.MaSanPham == maSanPham
                             select nguyenlieu).ToList();
                listNguyenLieu = ketQua;
            }
            catch (Exception)
            {
                return listNguyenLieu = null;
            }

            return listNguyenLieu;

        }


        public bool themChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            try
            {
                ketNoi.ChiTietSanPhams.InsertOnSubmit(chiTietSanPham);
                ketNoi.SubmitChanges();
                
                return true;
            }
            catch(Exception)
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
    }
}

