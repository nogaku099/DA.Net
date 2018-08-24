using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using BUS;
using DAL;
namespace QLQuanAn
{
    public partial class FormQuanLyHoaDon : MetroForm
    {
        #region Bus&DAL
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        DAL_ChiTietHoaDon dal_ChiTietHoaDon = new DAL_ChiTietHoaDon();

        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();


        #endregion

        List<ChiTietHoaDon> dsChiTietHoaDonDangLoad = new List<ChiTietHoaDon>();
        List<HoaDon> dsHoaDon = new List<HoaDon>();

        int soDongLoadHoaDon = 20;
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public void customGridHoaDon()
        {
            gridHoaDon.Columns[0].HeaderText = "Mã hoá đơn";
            gridHoaDon.Columns[1].HeaderText = "Ngày lập";
            gridHoaDon.Columns[2].HeaderText = "Tổng tiền";
            gridHoaDon.Columns[3].HeaderText = "Mã nhân viên";
            gridHoaDon.Columns[4].HeaderText = "Mã bàn";
            gridHoaDon.Columns[5].HeaderText = "Trạng thái";

            gridHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        public void phanTrangHoaDon()
        {
            int tongSoTrang = bus_HoaDon.layDSHoaDon().Count % soDongLoadHoaDon;
            if (tongSoTrang != 0)
            {
                tongSoTrang = bus_HoaDon.layDSHoaDon().Count / soDongLoadHoaDon + 1;
            }
            else tongSoTrang = bus_HoaDon.layDSHoaDon().Count / soDongLoadHoaDon;
            lblHienThiSoTrangHoaDon.Text = tongSoTrang.ToString();
            List<HoaDon> lstHoaDon = new List<HoaDon>();
            if (bus_HoaDon.layDSHoaDon().Count >= soDongLoadHoaDon)
            {
                lstHoaDon = bus_HoaDon.layDanhSachHoaDon(((int)numericUpDownHoaDon.Value - 1) * soDongLoadHoaDon, soDongLoadHoaDon); // lay 10 trang dau tien
                numericUpDownHoaDon.Enabled = true;

            }
            else
            {
                lstHoaDon = bus_HoaDon.layDSHoaDon();
                numericUpDownHoaDon.Enabled = false;
            }

            numericUpDownHoaDon.Maximum = tongSoTrang;
            numericUpDownHoaDon.Minimum = 1;
            gridHoaDon.DataSource = lstHoaDon;
            lblHienThiSoTrangHoaDon.Text = tongSoTrang.ToString();
        }

        public void phanTrangChiTietHoaDon()
        {

        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            phanTrangHoaDon();
            customGridHoaDon();
        }
        public void customGridChiTietHoaDon()
        {
            gridChiTietHoaDon.Columns[0].HeaderText = "Mã chi tiết hoá đơn";
            gridChiTietHoaDon.Columns[1].HeaderText = "Mã hoá đơn";
            gridChiTietHoaDon.Columns[2].HeaderText = "Mã sản phẩm";
            gridChiTietHoaDon.Columns[3].HeaderText = "Số lượng";
            gridChiTietHoaDon.Columns[4].HeaderText = "Thành tiền";


            gridChiTietHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        
        private void gridHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String maHoaDon = gridHoaDon.CurrentRow.Cells[0].Value.ToString();
            //maNhanVienDangChon = maNhanVien;

            dsChiTietHoaDonDangLoad = bus_ChiTietHoaDon.layDSChiTietHoaDonTheoMaHoaDon(maHoaDon);
            gridChiTietHoaDon.DataSource = dsChiTietHoaDonDangLoad;
            customGridChiTietHoaDon();
        }

        private void numericUpDownHoaDon_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownHoaDon.Value >= numericUpDownHoaDon.Minimum)
            {
                phanTrangHoaDon();
            }
        }

        private void numericUpDownChiTietHoaDon_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownChiTietHoaDon.Value >= numericUpDownChiTietHoaDon.Minimum)
            {
                phanTrangChiTietHoaDon();
            }
        }
    }
}
