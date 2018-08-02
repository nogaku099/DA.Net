using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NHACUNGCAP:CONNECT
    {
     
        public String taoMa()
        {
            try
            {
          

                String id = Guid.NewGuid().ToString();


                return id;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<NhaCungCap> LayNhaCungCap()
        {
            try
            {
                var ketQua = (from item in ketNoi.NhaCungCaps select item).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Them(NhaCungCap nhaCungCap)
        {
            try
            {
                ketNoi.NhaCungCaps.InsertOnSubmit(nhaCungCap);
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Xoa(String maNhaCungCap)
        {
            try
            {
                var ketQua = (from item in ketNoi.NhaCungCaps
                              where item.MaNhaCungCap == maNhaCungCap
                              select item).FirstOrDefault();
                ketNoi.NhaCungCaps.DeleteOnSubmit(ketQua);
                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CapNhat(NhaCungCap nhaCungCap)
        {
            try
            {
                var ketQua = (from item in ketNoi.NhaCungCaps where item.MaNhaCungCap == nhaCungCap.MaNhaCungCap select item).FirstOrDefault();

                ketQua.MaNguyenLieu = nhaCungCap.MaNguyenLieu;
                ketQua.GiaNhap = nhaCungCap.GiaNhap;
                ketQua.TenNhaCungCap = nhaCungCap.TenNhaCungCap;
                ketQua.DiaChiNhaCungCap = nhaCungCap.DiaChiNhaCungCap;
                ketQua.DienThoaiNhaCungCap = nhaCungCap.DienThoaiNhaCungCap;
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
