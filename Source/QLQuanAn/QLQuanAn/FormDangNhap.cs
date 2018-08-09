using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using DAL;
using BUS;
namespace QLQuanAn
{
    public partial class FormDangNhap : MetroForm
    {
        //Khoi tao BUS va DAL
        #region khoiTao
        BUS_Ban bus_Ban = new BUS_Ban();
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        #endregion

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        public void dangNhap(String taiKhoan, String matKhau)
        {
            //De trong
            if (taiKhoan == "" || taiKhoan == null || matKhau == "" || matKhau == null)
            {
                MetroMessageBox.Show(Owner, "Tài khoản hoặc mật khẩu không được để trống. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bus_TaiKhoan.dangNhap(taiKhoan, matKhau))
            {
                String maNhanVienDangNhap = bus_TaiKhoan.layMaNhanVien(taiKhoan);
                NhanVien nhanVienDangNhap = bus_NhanVien.layNVTheoMaNV(maNhanVienDangNhap);
     
                MetroMessageBox.Show(Owner, "Chào "+nhanVienDangNhap.ChucVu+" " + nhanVienDangNhap.TenNhanVien, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormChinh form = new FormChinh(nhanVienDangNhap);
                form.ShowDialog();
                this.Hide();
            }

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String taiKhoan = txtTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            dangNhap(taiKhoan, matKhau);
        }

        private void btnXoaDangNhap_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text="";
            txtTaiKhoan.Text="";
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String taiKhoan = txtTaiKhoan.Text;
                String matKhau = txtMatKhau.Text;
                dangNhap(taiKhoan, matKhau);
            }
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau form = new FormQuenMatKhau();
            form.Show();
        }
    }
}
