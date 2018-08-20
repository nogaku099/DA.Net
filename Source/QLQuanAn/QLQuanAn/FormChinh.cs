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
    public partial class FormChinh : MetroForm
    {
        NhanVien nhanVienDangNhap = new NhanVien();

        #region kiemSoatForm
        int trangThaiMoForm = 0;

        #endregion
        public FormChinh()
        {
            InitializeComponent();
        }
        public FormChinh(NhanVien nhanVien)
        {
            this.nhanVienDangNhap = nhanVien;
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            lblHienThiUser.Text = nhanVienDangNhap.ChucVu + " " + nhanVienDangNhap.TenNhanVien;
            lblNgayThangHienTai.Text = DateTime.Today.ToString("dd-MM-yyyy");

            if (nhanVienDangNhap.ChucVu == "NhanVien")
            {
                chucNangQLNhanvien.Visible = false;
                chucNangQLMon.Visible = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }

        private void chucNangQLNhanvien_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien formQuanLyNhanVien = new FormQuanLyNhanVien();
            formQuanLyNhanVien.Show();
        }

        private void chucNangQLBan_Click(object sender, EventArgs e)
        {
            FormQuanLyBan formQuanLyBan = new FormQuanLyBan();
            formQuanLyBan.Show();
        }

        private void chucNangQLHoaDon_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon formQuanLyHoaDon = new FormQuanLyHoaDon();
            formQuanLyHoaDon.Show();
        }

        private void chucNangThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
        }

        private void chucNangQLMon_Click(object sender, EventArgs e)
        {
            FormQuanLyMon formQuanLyMon = new FormQuanLyMon();
            formQuanLyMon.Show();
        }
    }
}
