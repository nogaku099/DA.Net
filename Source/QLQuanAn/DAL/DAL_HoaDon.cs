using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : KetNoi
    {
        public List<HoaDon> layDSHoaDon()
        {
            try
            {
                var ketQua = (from item in ketNoi.HoaDons select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
