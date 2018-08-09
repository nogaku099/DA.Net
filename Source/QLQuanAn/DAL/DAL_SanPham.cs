using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham : KetNoi
    {
        public List<SanPham> layDSSanPham()
        {
            try
            {
                var ketQua = (from sanPham in ketNoi.SanPhams select sanPham).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
