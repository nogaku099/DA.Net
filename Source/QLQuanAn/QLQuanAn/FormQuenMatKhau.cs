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
    public partial class FormQuenMatKhau : MetroForm
    {
        #region khoiTao
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        #endregion
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            String taiKhoan = txtTaiKhoanLayLai.Text;
            String matKhau2 = txtMatKhau2LayLai.Text;
            String matKhauMoi = txtMatKhauMoi.Text;
            String matKhauMoiLapLap = txtMatKhauMoiLapLai.Text;

            //Truong hop de trong
            if (taiKhoan == null || taiKhoan == "" || matKhau2==null || matKhau2=="" || matKhauMoi==null || matKhauMoi == "" || matKhauMoiLapLap == null || matKhauMoiLapLap == "")
            {
                MetroMessageBox.Show(Owner, "Tất cả các trường không được để trống. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bus_TaiKhoan.kiemTraTaiKhoanCoTonTai(taiKhoan)) //Truong hop co tai khoan nay
            {
                if (bus_TaiKhoan.kiemTraMatKhau2(taiKhoan,matKhau2)) //Truong hop co tk va mk2 dung
                {
                    //Tien hanh kiem tra mat khau moi va mat khau moi lap lai co giong nhau hay ko
                    if (matKhauMoi == matKhauMoiLapLap)
                    {
                        //Tien hanh thay doi mat khau
                        bus_TaiKhoan.thayDoiMatKhauBangMK2(taiKhoan, matKhau2, matKhauMoi);
                        MetroMessageBox.Show(Owner,"Đã thay đổi mật khẩu thành công","Thông báo",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "Mật khẩu nhập lại không chính xác. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Truong hop mk2 ko dung
                {
                    MetroMessageBox.Show(Owner, "Tài khoản hoặc mật khẩu 2 không chính xác. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(Owner, "Tài khoản hoặc mật khẩu 2 không chính xác. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTaiKhoanLayLai.Text = "";
            txtMatKhau2LayLai.Text = "";
            txtMatKhauMoiLapLai.Text = "";
            txtMatKhauMoi.Text = "";
        }
    }
}
