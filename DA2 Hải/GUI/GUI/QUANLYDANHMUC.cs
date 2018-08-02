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

namespace GUI
{
    public partial class QUANLYDANHMUC : MetroForm
    {
        public QUANLYDANHMUC()
        {
            InitializeComponent();
        }

        private void QUANLYDANHMUC_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            QUANLYNGUYENLIEU form = new QUANLYNGUYENLIEU();
            form.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            QuanLySanPham form = new QuanLySanPham();
            form.Show();
        }

        private void btn_quanLyNhanVien_Click(object sender, EventArgs e)
        {
            QUANLYNHANVIEN form = new QUANLYNHANVIEN();
            form.Show();
        }

        private void btn_quanLySanPham_Click(object sender, EventArgs e)
        {
            NHACUNGCAP form = new NHACUNGCAP();
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            KHO_GUI form = new KHO_GUI();
            form.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
