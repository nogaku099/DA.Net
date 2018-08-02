using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_NHACUNGCAP
    {
        DAL_NHACUNGCAP dal_nhaCungCap = new DAL_NHACUNGCAP();

        public String taoMa()
        {
            return dal_nhaCungCap.taoMa();
        }
        public List<NhaCungCap> LayNhaCungCap()
        {
            return dal_nhaCungCap.LayNhaCungCap();
        }
        public bool Them(NhaCungCap nhaCungCap)
        {
            return dal_nhaCungCap.Them(nhaCungCap);
        }

        public bool Xoa(String maNhaCungCap)
        {
            return dal_nhaCungCap.Xoa(maNhaCungCap);
            
        }

        public bool CapNhat(NhaCungCap nhaCungCap)
        {
            return dal_nhaCungCap.CapNhat(nhaCungCap);
        }
          

    
}
}
