using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CHITIETPHIEUNHAP:CONNECT
    {
        public List<ChiTietPhieuNhap> LayChiTietPhieuNhap()
        {
            try
            {
                var ketQua = (from item in ketNoi.ChiTietPhieuNhaps select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
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
        public bool them(ChiTietPhieuNhap item)
        {
            try
            {
                ketNoi.ChiTietPhieuNhaps.InsertOnSubmit(item);
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
