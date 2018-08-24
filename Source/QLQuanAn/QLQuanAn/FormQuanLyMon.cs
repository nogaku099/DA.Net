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
    public partial class FormQuanLyMon : MetroForm
    {
        #region BUS&DAL
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        DAL_SanPham dal_SanPham = new DAL_SanPham();
        #endregion

        List<SanPham> dsSanPham = new List<SanPham>();

        int soDongLoad = 15;

        String maMon = "";
        public FormQuanLyMon()
        {
            InitializeComponent();
        }

        private void FormQuanLyMon_Load(object sender, EventArgs e)
        {
            phanTrangSanPham();
            customGridSanPham();

        }
        public void customGridSanPham()
        {
            gridSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            gridSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            gridSanPham.Columns[2].HeaderText = "Loại sản phẩm";
            gridSanPham.Columns[3].HeaderText = "";
            gridSanPham.Columns[4].HeaderText = "Giá sản phẩm";

            gridSanPham.Columns[3].Visible = false;
            gridSanPham.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            gridSanPham.Columns[0].Width= 200;
            gridSanPham.Columns[1].Width = 400;
            gridSanPham.Columns[2].Width = 300;
            gridSanPham.Columns[3].Width = 0;
            gridSanPham.Columns[4].Width = 205;
        }
        public void phanTrangSanPham()
        {
            int tongSoTrang = bus_SanPham.layDSSanPham().Count % soDongLoad;
            if (tongSoTrang != 0)
            {
                tongSoTrang = bus_SanPham.layDSSanPham().Count / soDongLoad + 1;
            }
            else tongSoTrang = bus_SanPham.layDSSanPham().Count / soDongLoad;
            lblHienThiSoTrang.Text = tongSoTrang.ToString();
            List<SanPham> lstSanPham = new List<SanPham>();
            if (bus_SanPham.layDSSanPham().Count >= soDongLoad)
            {
                lstSanPham = bus_SanPham.layDanhSachSanPham(((int)numericUpDownSanPham.Value - 1) * soDongLoad, soDongLoad); // lay 10 trang dau tien
                numericUpDownSanPham.Enabled = true;

            }
            else
            {
                lstSanPham = bus_SanPham.layDSSanPham();
                numericUpDownSanPham.Enabled = false;
            }

            numericUpDownSanPham.Maximum = tongSoTrang;
            numericUpDownSanPham.Minimum = 1;
            gridSanPham.DataSource = lstSanPham;
            lblHienThiSoTrang.Text = tongSoTrang.ToString();
        }

        

        private void numericUpDownSanPham_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSanPham.Value >= numericUpDownSanPham.Minimum)
            {
                phanTrangSanPham();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanPham sanPhamCapNhat = new SanPham(maMon,txtTenMon.Text,txtLoaiMon.Text,"",float.Parse(txtGiaSanPham.Text));
            bus_SanPham.capNhatSanPham(sanPhamCapNhat);
        }

        private void gridSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maMon = gridSanPham.CurrentRow.Cells[0].Value.ToString();
            //maNhanVienDangChon = maNhanVien;

            SanPham sanPham = bus_SanPham.laySanPhamTheoMaSP(maMon);
            lblMaMon.Text = "Mã món: " + sanPham.MaSanPham;
            txtTenMon.Text = sanPham.TenSanPham;
            txtLoaiMon.Text = sanPham.LoaiSanPham;
            txtGiaSanPham.Text = sanPham.GiaSanPham.ToString();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            FormThemMon form = new FormThemMon();
            form.Show();
        }
    }
}
