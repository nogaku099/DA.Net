using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using MetroFramework;
using MetroFramework.Forms;


namespace GUI
{
    public partial class QUANLYNGUYENLIEU : MetroForm
    {
        BUS_NGUYENLIEU bus_NguyenLieu = new BUS_NGUYENLIEU();
        int demSoLanXoa = 0;

        public QUANLYNGUYENLIEU()
        {
            InitializeComponent();
        }

        public void LoadNguyenLieu()
        {
         

            grid_NguyenLieu.DataSource = bus_NguyenLieu.layNguyenLieu();
            grid_NguyenLieu.Columns[0].HeaderText = "Mã Nguyên Liệu";
            grid_NguyenLieu.Columns[1].HeaderText = "Tên Nguyên Liệu";
            grid_NguyenLieu.Columns[0].Width = 400;
            grid_NguyenLieu.Columns[1].Width = 400;

        }
        private void QUANLYNGUYENLIEU_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            LoadNguyenLieu();
        }

        private void grid_NguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_NguyenLieu_MouseClick(object sender, MouseEventArgs e)
        {
            String maNguyenLieu = grid_NguyenLieu.CurrentRow.Cells[0].Value.ToString();
            String tenNguyenLieu = grid_NguyenLieu.CurrentRow.Cells[1].Value.ToString();

            txtTenNguyenLieu.Text = tenNguyenLieu;


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            String maNguyenLieu = "NL" + (bus_NguyenLieu.layNguyenLieu().Count + 1 + demSoLanXoa);
            String tenNguyenLieu = txtTenNguyenLieu.Text;
            String loaiDonVi = txt_loaiDonVi.Text;
            nguyenLieu.TenNguyenLieu = tenNguyenLieu;
            nguyenLieu.MaNguyenLieu = maNguyenLieu;
            nguyenLieu.LoaiDonVi = loaiDonVi;
            bus_NguyenLieu.them(nguyenLieu);
            grid_NguyenLieu.DataSource = bus_NguyenLieu.layNguyenLieu();


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            demSoLanXoa++;
            String maNguyenLieu = grid_NguyenLieu.CurrentRow.Cells[0].Value.ToString();
            bus_NguyenLieu.xoa(maNguyenLieu);
            grid_NguyenLieu.DataSource = bus_NguyenLieu.layNguyenLieu();
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.TenNguyenLieu = txtTenNguyenLieu.Text;
            nguyenLieu.MaNguyenLieu = grid_NguyenLieu.CurrentRow.Cells[0].Value.ToString();
            bus_NguyenLieu.CapNhat(nguyenLieu);
            grid_NguyenLieu.DataSource = bus_NguyenLieu.layNguyenLieu();
        }
    }
}
