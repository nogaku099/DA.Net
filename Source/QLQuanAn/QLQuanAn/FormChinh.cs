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
            if (nhanVienDangNhap.ChucVu == "NhanVien")
            {
                chucNangQLNhanvien.Visible = false;
                chucNangQLMon.Visible = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
