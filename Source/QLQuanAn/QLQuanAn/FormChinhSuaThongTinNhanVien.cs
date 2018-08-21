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
using DAL;
using BUS;

namespace QLQuanAn
{
    public partial class FormChinhSuaThongTinNhanVien : MetroForm
    {
        #region BUS&DAL
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        #endregion
        String maNhanVienChinhSua = "";
        NhanVien nhanVienDangChinhSua = new NhanVien();
        public FormChinhSuaThongTinNhanVien()
        {
            InitializeComponent();
        }
        public FormChinhSuaThongTinNhanVien(String maNhanVien)
        {
            InitializeComponent();
            this.maNhanVienChinhSua = maNhanVien;
            lblMaNhanVien.Text = maNhanVien;
            nhanVienDangChinhSua = bus_NhanVien.layNVTheoMaNV(maNhanVien);
            txtTenNhanVienMoi.Text = nhanVienDangChinhSua.TenNhanVien;
            txtDiaChiNVMoi.Text = nhanVienDangChinhSua.DiaChi;
            txtSoDienThoaiNVMoi.Text = nhanVienDangChinhSua.SoDienThoai;
            DateTime myDate = DateTime.Parse(nhanVienDangChinhSua.NgaySinh);
            chonNgaySinhNVMoi.Value = new DateTime(myDate.Year,myDate.Month,myDate.Day);
            chonNgaySinhNVMoi.Format = DateTimePickerFormat.Custom;
            chonNgaySinhNVMoi.CustomFormat = "dd/MM/yyyy";
            if (nhanVienDangChinhSua.ChucVu == "QL")
            {
                radQL.Checked = true;
            }
            else
            {
                radQL.Checked = true;
            }

        }

        private void FormChinhSuaThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult ketQuaChon= MetroMessageBox.Show(Owner, "Bạn cần cập nhật thông tin nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Đồng ý thay đổi
            if(ketQuaChon == DialogResult.OK)
            {
                NhanVien nhanVienDuocCapNhat = new NhanVien();
                nhanVienDuocCapNhat.MaNhanVien = maNhanVienChinhSua;
                nhanVienDuocCapNhat.TenNhanVien = txtTenNhanVienMoi.Text;
                nhanVienDuocCapNhat.DiaChi = txtDiaChiNVMoi.Text;
                nhanVienDuocCapNhat.SoDienThoai = txtSoDienThoaiNVMoi.Text;

                nhanVienDuocCapNhat.NgaySinh = chonNgaySinhNVMoi.Text;
                if (radNV.Checked)
                {
                    nhanVienDuocCapNhat.ChucVu = "NV";
                }
                else
                {
                    nhanVienDuocCapNhat.ChucVu = "QL";
                }

                bus_NhanVien.capNhatNhanVien(nhanVienDuocCapNhat);
                MetroMessageBox.Show(Owner, "Thông tin nhân viên "+nhanVienDuocCapNhat.MaNhanVien+" đã được cập nhật", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {

            }
        }
    }
}
