using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class TaiKhoan
    {
        public TaiKhoan(String username, String passWords,String maNhanVien)
        {
            this.TaiKhoan1 = username;
            this.MatKhau = passWords;
            this.MaNhanVien = maNhanVien;
        }

    }
}
