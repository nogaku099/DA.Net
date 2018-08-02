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
    public partial class QUANLYTAIKHOAN : MetroForm
    {
        BUS_TAIKHOAN bus_taiKhoan = new BUS_TAIKHOAN();
        
        public QUANLYTAIKHOAN()
        {
            InitializeComponent();
        }


        public void loadForm()
        {
            gridTaiKhoan.Columns[0].HeaderText = "Tên Tài Khoản";
            gridTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            gridTaiKhoan.Columns[2].HeaderText = "Mã Nhân Viên";
            gridTaiKhoan.Columns[0].Width = 300;
            gridTaiKhoan.Columns[1].Width = 300;
            gridTaiKhoan.Columns[2].Width = 300;
        }
        private void QUANLYTAIKHOAN_Load(object sender, EventArgs e)
        {
         
            gridTaiKhoan.DataSource = bus_taiKhoan.layTaiKhoan();
            loadForm();


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String maNhanVien = gridTaiKhoan.CurrentRow.Cells[2].Value.ToString();

            if (bus_taiKhoan.xoa(maNhanVien) == true)
            {
                MetroMessageBox.Show(this, "Xóa Thành Công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gridTaiKhoan.DataSource =  bus_taiKhoan.layTaiKhoan();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            TaiKhoan tk = new TaiKhoan();
        }
    }
}
