using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ban : KetNoi
    {
        public List<Ban> layDSBan()
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

        public bool capNhatTrangThai(Ban banCapNhat)
        {
            try
            {
                var ketQua = (from ban in ketNoi.Bans
                              where ban.MaBan == banCapNhat.MaBan
                              select ban).FirstOrDefault();
                ketQua.TrangThai = banCapNhat.TrangThai;
                ketNoi.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Ban layBanTheoMaBan(String maBan)
        {
            try
            {
                var ketQua = (from item in ketNoi.Bans
                              where item.MaBan == maBan
                              select item).FirstOrDefault();
                return ketQua;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public int demTongBan()
        {
            try
            {
                int count = 0;
                count = ketNoi.Bans.Count();
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public List<Ban> layDanhSachBan(int soDongBoQua, int soDongCanLay)
        {
            var ketQua = (from item in ketNoi.Bans.Skip(soDongBoQua).Take(soDongCanLay)
                          select item).ToList();

            return ketQua;
        }

        public List<Ban> layDSBanDangPhucVu()
        {
            try
            {
                var ketQua = (from item in ketNoi.Bans
                              where item.TrangThai == "Busy"
                              select item).ToList();
                return ketQua;
            }
            catch(Exception e)
            {
                return null;
            }
        }



    }
}
