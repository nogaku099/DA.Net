using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ban : KetNoi
    {
        public List<Ban> layDSBan()
        {
            try
            {
                var ketQua = (from ban in ketNoi.Bans select ban).ToList();
                return ketQua;


            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool capNhatTrangThai(Ban banCapNhat)
        {
            try
            {
                var ketQua = (from ban in ketNoi.Bans
                              where ban.MaBan == banCapNhat.MaBan
                              select ban).FirstOrDefault();
                ketQua.TrangThai = banCapNhat.TrangThai;
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
