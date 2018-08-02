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
    public partial class QUANLYHOADON : MetroForm
    {
        BUS_HOADON bus_hoaDon = new BUS_HOADON();
        BUS_PHIEUNHAP bus_phieuNhap = new BUS_PHIEUNHAP();
        public QUANLYHOADON()
        {
            InitializeComponent();
        }

        public void loadForm()
        {
            grid_hoaDon.Columns[0].Width = 110;
            grid_hoaDon.Columns[1].Width = 110;
            grid_hoaDon.Columns[2].Width = 110;
            grid_hoaDon.Columns[3].Width = 110;
            grid_hoaDon.Columns[4].Width = 110;
            grid_hoaDon.Columns[5].Width = 110;
     
            grid_hoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            grid_hoaDon.Columns[1].HeaderText = "Ngày Lập";
            grid_hoaDon.Columns[2].HeaderText = "Tổng Tiền";
            grid_hoaDon.Columns[3].HeaderText = "Mã Nhân Viên";
            grid_hoaDon.Columns[4].HeaderText = "Mã Bàn";
            grid_hoaDon.Columns[5].HeaderText = "Trạng Thái";

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = Screen.PrimaryScreen.Bounds.Size;


        }
        private void QUANLYHOADON_Load(object sender, EventArgs e)
        {
            grid_hoaDon.DataSource = bus_hoaDon.layHoaDon();
            loadForm();
        }

        private void grid_hoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void grid_hoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridPhieuNhap.DataSource = bus_phieuNhap.LayPhieuNhap();
            
        }
    }
}
