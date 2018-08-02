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
using System.Threading;

namespace GUI
{
    public partial class COFFEE_MANAGER : MetroForm
    {
        String tenNhanvien = "";
        BUS_NHANVIEN bus_nhanVien = new BUS_NHANVIEN();
        BUS_TAIKHOAN bus_taiKhoan = new BUS_TAIKHOAN();
       
        public COFFEE_MANAGER()
        {
            InitializeComponent();
        }
        public COFFEE_MANAGER(String ten)
        {
            this.tenNhanvien = ten;
            InitializeComponent();
        }

        private void COFFEE_MANAGER_Load(object sender, EventArgs e)
        {

        
;

            if (bus_nhanVien.isManager(tenNhanvien) == false)
            {
                btn_QuanLyDanhMuc.Visible = false;
                
            }
                
           

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            hinhBan5 form = new hinhBan5(tenNhanvien);
            form.Show();
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            QuanLySanPham form = new QuanLySanPham();
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            QUANLYNHANVIEN form = new QUANLYNHANVIEN();
            form.Show();
        }

        private void COFFEE_MANAGER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            QUANLYDANHMUC form = new QUANLYDANHMUC();
            form.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            QUANLYHOADON form = new QUANLYHOADON();
            form.Show();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            NHAPKHO form = new NHAPKHO();
            form.Show();

        }
    }
}
