using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NGUYENLIEU:CONNECT
    {


        public List<NguyenLieu> layNguyenLieu()
        {
            try
            {
                var ketQua = (from item in ketNoi.NguyenLieus select item).ToList();
                return ketQua;
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        public NguyenLieu layNguyenLieuTheoMa(String maNguyenLieu)
        {
            try
            {
                var ketQua = (from result in ketNoi.NguyenLieus
                              where result.MaNguyenLieu == maNguyenLieu
                              select result).FirstOrDefault();
                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool xoa(String maNguyenLieu)
        {
            try
            {
                var ketQua = (from item in ketNoi.NguyenLieus
                              where item.MaNguyenLieu == maNguyenLieu
                              select item).FirstOrDefault();
                ketNoi.NguyenLieus.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool them(NguyenLieu nguyenLieu)
        {
            try
            {

                ketNoi.NguyenLieus.InsertOnSubmit(nguyenLieu);
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CapNhat(NguyenLieu nguyenLieu)
        {
            try
            {
                var ketQua = (from item in ketNoi.NguyenLieus
                             where item.MaNguyenLieu == nguyenLieu.MaNguyenLieu
                             select item).FirstOrDefault();
                ketQua.TenNguyenLieu = nguyenLieu.TenNguyenLieu;
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
