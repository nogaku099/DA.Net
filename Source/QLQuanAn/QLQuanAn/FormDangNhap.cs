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

namespace QLQuanAn
{
    public partial class FormDangNhap : MetroForm
    {
        
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
         
        public int dangNhap(String taiKhoan, String matKhau)
        {
           

            //Ko rong
            if (taiKhoan != "" && taiKhoan != null && matKhau != "" && matKhau != null)
            {

            }
            return 1;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String taiKhoan = txtTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            if (taiKhoan == "" || taiKhoan == null || matKhau == "" || matKhau == null)
            {
                MetroMessageBox.Show(Owner,"Tài khoản hoặc mật khẩu không được để trống. \n Vui lòng kiểm tra lại","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
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

            }
        }
    }
}
