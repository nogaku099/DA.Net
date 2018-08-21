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
    public partial class FormThemNhanVien : MetroForm
    {
        bool taoTaiKhoan = false;
        String ngayThangNamHienTai = DateTime.Today.ToString("dd-MM-yyyy");
        #region BUS&DAL
        BUS_NhanVien bus_Nhanvien = new BUS_NhanVien();
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        DAL_TaiKhoan DAL_TaiKhoan = new DAL_TaiKhoan();
        #endregion
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        #region anHienTaoTK
        public void hienTaoTaiKhoan()
        {
            matKhau1ChoNVMoi.Visible = true;
            matKhau2ChoNVMoi.Visible = true;
            lblTaiKhoanRandom.Visible = true;
            //Random tai khoan
            lblTaiKhoanRandom.Text = bus_TaiKhoan.taoMaTKMoi();
            taoTaiKhoan = true;
        }
        public void anTaoTaiKhoan()
        {
            matKhau1ChoNVMoi.Visible = false;
            matKhau2ChoNVMoi.Visible = false;
            lblTaiKhoanRandom.Visible = false;
            taoTaiKhoan = false;
        }
        #endregion
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            anTaoTaiKhoan();
            chonChucVu.Text = "Chọn chức vụ";
            lblMaNhanVienRandom.Text = bus_Nhanvien.taoMaNhanVienMoi();
            chonNgaySinhNVMoi.Format= DateTimePickerFormat.Custom;
            chonNgaySinhNVMoi.CustomFormat = "dd/MM/yyyy";

        }

        private void matKhau1ChoNVMoi_Leave(object sender, EventArgs e)
        {
            if (matKhau1ChoNVMoi.Text.Equals("Nhập mật khẩu 1...."))
            {
                matKhau1ChoNVMoi.Text = "";
            }
        }

        private void matKhau1ChoNVMoi_Enter(object sender, EventArgs e)
        {
            if (matKhau1ChoNVMoi.Text.Equals("Nhập mật khẩu 1...."))
            {
                matKhau1ChoNVMoi.Text = "";
            }
        }

        private void matKhau2ChoNVMoi_Enter(object sender, EventArgs e)
        {
            if (matKhau2ChoNVMoi.Text.Equals("Nhập mật khẩu 2...."))
            {
                matKhau2ChoNVMoi.Text = "";
            }
        }

        private void matKhau2ChoNVMoi_Leave(object sender, EventArgs e)
        {
            if (matKhau2ChoNVMoi.Text.Equals("Nhập mật khẩu 2...."))
            {
                matKhau2ChoNVMoi.Text = "";
            }
        }

        private void cbTaoTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            cbTaoTaiKhoan.ThreeState = false;
            if (cbTaoTaiKhoan.CheckState == CheckState.Checked)
            {
                hienTaoTaiKhoan();
            }
            else if (cbTaoTaiKhoan.CheckState == CheckState.Unchecked)
            {
                anTaoTaiKhoan();
            }
            
        }

        private void txtTenNhanVienMoi_Leave(object sender, EventArgs e)
        {
            if (txtTenNhanVienMoi.Text.Equals("Họ và tên nhân viên"))
            {
                txtTenNhanVienMoi.Text = "";
            }
        }

        private void txtTenNhanVienMoi_Enter(object sender, EventArgs e)
        {
            if (txtTenNhanVienMoi.Text.Equals("Họ và tên nhân viên"))
            {
                txtTenNhanVienMoi.Text = "";
            }
        }

        private void txtDiaChiNVMoi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiNVMoi.Text.Equals("Địa chỉ nhân viên"))
            {
                txtDiaChiNVMoi.Text = "";
            }
        }

        private void txtDiaChiNVMoi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChiNVMoi.Text.Equals("Địa chỉ nhân viên"))
            {
                txtDiaChiNVMoi.Text = "";
            }
        }

        private void txtSoDienThoaiNVMoi_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoaiNVMoi.Text.Equals("Số điện thoại nhân viên"))
            {
                txtSoDienThoaiNVMoi.Text = "";
            }
        }

        private void txtSoDienThoaiNVMoi_Enter(object sender, EventArgs e)
        {
            if (txtSoDienThoaiNVMoi.Text.Equals("Số điện thoại nhân viên"))
            {
                txtSoDienThoaiNVMoi.Text = "";
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
           

            //Tạo nhân viên kèm tài khoản
            if (taoTaiKhoan)
            {
                if (txtDiaChiNVMoi.Text == "" || txtDiaChiNVMoi.Text == "Địa chỉ nhân viên"
                    || txtSoDienThoaiNVMoi.Text == "" || txtSoDienThoaiNVMoi.Text == "Số điện thoại nhân viên"
                    || txtTenNhanVienMoi.Text == "" || txtTenNhanVienMoi.Text == "Họ và tên nhân viên"
                    || chonNgaySinhNVMoi.Text == ngayThangNamHienTai
                    || chonChucVu.Text == "Chọn chức vụ"
                    || matKhau1ChoNVMoi.Text == "" || matKhau1ChoNVMoi.Text == "Nhập mật khẩu 1...."
                    || matKhau2ChoNVMoi.Text == "" || matKhau2ChoNVMoi.Text == "Nhập mật khẩu 2....")
                {
                    MetroMessageBox.Show(Owner, "Tất cả các trường không được để trống hoặc để mặc định. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Thêm nv mới vào DB
                    NhanVien nhanVienMoi = new NhanVien();
                    nhanVienMoi.MaNhanVien = lblMaNhanVienRandom.Text;
                    nhanVienMoi.TenNhanVien = txtTenNhanVienMoi.Text;
                    nhanVienMoi.SoDienThoai = txtSoDienThoaiNVMoi.Text;
                    nhanVienMoi.DiaChi = txtDiaChiNVMoi.Text;
                    nhanVienMoi.NgaySinh = chonNgaySinhNVMoi.Text;
                    nhanVienMoi.ChucVu = chonChucVu.Text;

                    bus_Nhanvien.themNhanVien(nhanVienMoi);

                    //Tạo tk mới tương ứng với nhân viên mới
                    TaiKhoan taiKhoanNVMoi = new TaiKhoan();
                    taiKhoanNVMoi.MaNhanVien = lblMaNhanVienRandom.Text;
                    taiKhoanNVMoi.TaiKhoan1 = lblTaiKhoanRandom.Text;
                    taiKhoanNVMoi.MatKhau = matKhau1ChoNVMoi.Text;
                    taiKhoanNVMoi.MatKhau2 = matKhau2ChoNVMoi.Text;
                    bus_TaiKhoan.themTaiKhoan(taiKhoanNVMoi);

                    MetroMessageBox.Show(Owner, "Đã tạo nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (txtDiaChiNVMoi.Text == "" || txtDiaChiNVMoi.Text == "Địa chỉ nhân viên"
                    || txtSoDienThoaiNVMoi.Text == "" || txtSoDienThoaiNVMoi.Text == "Số điện thoại nhân viên"
                    || txtTenNhanVienMoi.Text == "" || txtTenNhanVienMoi.Text == "Họ và tên nhân viên"
                    || chonNgaySinhNVMoi.Text == ngayThangNamHienTai
                    || chonChucVu.Text == "Chọn chức vụ")
                {
                    MetroMessageBox.Show(Owner, "Tất cả các trường không được để trống hoặc để mặc định. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Thêm nv mới vào DB
                    NhanVien nhanVienMoi = new NhanVien();
                    nhanVienMoi.MaNhanVien = lblMaNhanVienRandom.Text;
                    nhanVienMoi.TenNhanVien = txtTenNhanVienMoi.Text;
                    nhanVienMoi.SoDienThoai = txtSoDienThoaiNVMoi.Text;
                    nhanVienMoi.DiaChi = txtDiaChiNVMoi.Text;
                    nhanVienMoi.NgaySinh = chonNgaySinhNVMoi.Text;
                    nhanVienMoi.ChucVu = chonChucVu.Text;

                    bus_Nhanvien.themNhanVien(nhanVienMoi);
                    MetroMessageBox.Show(Owner, "Đã tạo nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDiaChiNVMoi.Text = "Địa chỉ nhân viên";
            txtSoDienThoaiNVMoi.Text = "Số điện thoại nhân viên";
            txtTenNhanVienMoi.Text = "Họ và tên nhân viên";
            anTaoTaiKhoan();
            cbTaoTaiKhoan.Checked = false;
        }
    }
}
