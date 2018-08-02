using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class KHO
    {
        public KHO(String iD,String maNguyenLieu,int soLuongTon,String loaiDonVi)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.SoLuongTon = soLuongTon;
            this.ID = iD;
            this.LoaiDonVi = loaiDonVi;
        }
    }
}
