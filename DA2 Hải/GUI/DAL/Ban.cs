using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Ban
    {
        public Ban(String maban, String trangThai)
        {
            this.MaBan = maban;
            this.TrangThai = trangThai;
        }
    }
}
