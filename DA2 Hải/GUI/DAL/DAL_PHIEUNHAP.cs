using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PHIEUNHAP:CONNECT
    {
        public List<PhieuNhap> LayPhieuNhap()
        {
            try
            {
                var ketQua = (from item in ketNoi.PhieuNhaps select item).ToList();
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
        public bool Them(PhieuNhap item)
        {
            try
            {
                ketNoi.PhieuNhaps.InsertOnSubmit(item);
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
