using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BAN : CONNECT { 
    

        public bool capNhatTrangThai(Ban item)
    {
        try
        {
                var ketQua = (from ban in ketNoi.Bans
                              where ban.MaBan == item.MaBan
                              select ban).FirstOrDefault();
                ketQua.TrangThai = item.TrangThai;
                ketNoi.SubmitChanges();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
        public List<Ban> layTatCaBan()
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
    }
}
