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
    public partial class MAIN : MetroForm
    {
        BUS_TAIKHOAN bus_TaiKhoan = new BUS_TAIKHOAN();
        public static String maNhanVien = "";

   
        public String getMaNhanVien()
        {
            return maNhanVien;
        }
        public MAIN()
        {
            
            InitializeComponent();
           
  
        }
    

        private void MAIN_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWords = txtPassWords.Text;
            maNhanVien = userName;

            if (bus_TaiKhoan.DangNhap(userName, passWords) == true)
            {
                maNhanVien = bus_TaiKhoan.layMaNhanVienTuTenTaiKhoan(userName);

        
                
                MetroMessageBox.Show(Owner, "Welcome "+userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                COFFEE_MANAGER form = new COFFEE_MANAGER(maNhanVien);
                form.Show();
                this.Hide();
                

            }
            else
                MetroMessageBox.Show(Owner, "Login Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String userName = txtUserName.Text;
                String passWords = txtPassWords.Text;

                if (bus_TaiKhoan.DangNhap(userName, passWords) == true)
                {




                    MetroMessageBox.Show(Owner, "Welcome " + userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    COFFEE_MANAGER form = new COFFEE_MANAGER(maNhanVien);
                    form.Show();
                    this.Hide();


                }
                else
                    MetroMessageBox.Show(Owner, "Login Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
