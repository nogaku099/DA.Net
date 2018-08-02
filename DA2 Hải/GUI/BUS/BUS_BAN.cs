using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_BAN
    {
        DAL_BAN dal_ban = new DAL_BAN();

        public List<Ban> layTatCaBan()
        {
            return dal_ban.layTatCaBan();
        }
        public bool capNhatTrangThai(Ban ban)
        {
            return dal_ban.capNhatTrangThai(ban);
        }
    }
}
