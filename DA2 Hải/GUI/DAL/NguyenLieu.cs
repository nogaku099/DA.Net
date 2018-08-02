using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NguyenLieu
    {
        public NguyenLieu(String maNguyenLieu, String tenNguyenLieu,String loaiDonVi)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.LoaiDonVi = loaiDonVi;
        }
    }
}
