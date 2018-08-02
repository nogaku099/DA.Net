using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_KHO:CONNECT
    {

        public List<KHO> layKho()
        {
            try
            {
                var ketQua = (from item in ketNoi.KHOs select item).ToList();
                return ketQua;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool xoa(String maNguyenLieu)
        {
            try
            {
                var ketQua = (from item in ketNoi.KHOs
                              where item.MaNguyenLieu == maNguyenLieu
                              select item).FirstOrDefault();
                ketNoi.KHOs.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool capNhatKhoNguyenLieu(String maNguyenLieu, int soLuong)
        {
            var ketQua = (from kho in ketNoi.KHOs
                          where kho.MaNguyenLieu == maNguyenLieu
                          select kho).ToList();

           

         
            foreach(var tam in ketQua)
            {
                
             if(tam.SoLuongTon>= tam.SoLuongTon - soLuong)   
                    tam.SoLuongTon = tam.SoLuongTon - soLuong;
                
           
             
            }
            ketNoi.SubmitChanges();

            return true;
        }


        public bool kiemTraSoLuongTon(String maNguyenLieu, int soLuong)
        {
            var ketQua = (from kho in ketNoi.KHOs
                          where kho.MaNguyenLieu == maNguyenLieu
                          select kho).ToList();




            foreach (var tam in ketQua)
            {


                if (tam.SoLuongTon >= soLuong)
                    return true;
                else
                    return false;

            }

            return false;
        }
        public bool them(KHO kho)
        {
            try
            {

                ketNoi.KHOs.InsertOnSubmit(kho);
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CapNhat(KHO kho)
        {
            try
            {
                var ketQua = (from item in ketNoi.KHOs
                              where item.MaNguyenLieu == kho.MaNguyenLieu
                              select item).FirstOrDefault();
                ketQua.SoLuongTon = kho.SoLuongTon;
                ketNoi.SubmitChanges();

                return true;
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
