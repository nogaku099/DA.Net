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
    public partial class FormQuanLyNhanVien : MetroForm
    {
        #region BUS&DAL
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        #endregion
        int soDongLoad = 10;
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            phanTrangNhanVien();
            #region customGridNhanVien
            gridNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            gridNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            gridNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            gridNhanVien.Columns[3].HeaderText = "Địa Chỉ";
            gridNhanVien.Columns[4].HeaderText = "Chức Vụ";
            gridNhanVien.Columns[5].HeaderText = "Số Điện Thoại";

            gridNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //gridNhanVien.Columns[0].Width = 100;
            // gridNhanVien.Columns[1].Width = 200;
            //gridNhanVien.Columns[2].Width = 200;
            //gridNhanVien.Columns[3].Width = 200;
            //gridNhanVien.Columns[4].Width = 200;
            //gridNhanVien.Columns[5].Width = 200;

            #endregion
        }
        public void phanTrangNhanVien()
        {
            int tongSoTrang = bus_NhanVien.demTongNhanVien() % soDongLoad;
            if (tongSoTrang != 0)
            {
                tongSoTrang = bus_NhanVien.demTongNhanVien() / soDongLoad + 1;
            }
            else tongSoTrang = bus_NhanVien.demTongNhanVien() / soDongLoad;
            lblHienThiSoTrang.Text = "/" + tongSoTrang;
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            if (bus_NhanVien.demTongNhanVien() >= soDongLoad)
            {
                lstNhanVien = bus_NhanVien.layDanhSachNhanVien(((int)numericUpDownNhanVien.Value - 1) * soDongLoad, soDongLoad); // lay 10 trang dau tien
                numericUpDownNhanVien.Enabled = true;

            }
            else
            {
                lstNhanVien = bus_NhanVien.layDSNhanVien();
                numericUpDownNhanVien.Enabled = false;
            }

            numericUpDownNhanVien.Maximum = tongSoTrang;
            numericUpDownNhanVien.Minimum = 1;
            gridNhanVien.DataSource = lstNhanVien;
            lblHienThiSoTrang.Text = tongSoTrang.ToString();


        }
        private void txtSoTrangHienTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownNhanVien_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNhanVien.Value >= numericUpDownNhanVien.Minimum)
            {
                phanTrangNhanVien();
            }
        }

        private void txtHienThiMatKhau1_TextChanged(object sender, EventArgs e)
        {
            btnDoiMatKhau1.Visible = true;
        }

        private void btnDoiMatKhau1_Click(object sender, EventArgs e)
        {
            String matKhauMoi = txtHienThiMatKhau1.Text;
            if (matKhauMoi == "" || matKhauMoi == null)
            {
                MetroMessageBox.Show(Owner, "Mật khẩu mới không được để trống. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String taiKhoanHienThi = lblHienThiTenTaiKhoan.Text;
                bus_TaiKhoan.thayDoiMatKhauBangQuyenQL(taiKhoanHienThi, matKhauMoi);
            }
        }

        private void gridNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string maLop = gridLop.CurrentRow.Cells[0].Value.ToString();
            //gridSinhVien.DataSource = bus_SinhVien.laySinhVienTheoMaLop(maLop);
            String maNhanVien = gridNhanVien.CurrentRow.Cells[0].Value.ToString();
            TaiKhoan taiKhoanCuaNhanVienDangChon = bus_TaiKhoan.layTaiKhoanTheoMaNV(maNhanVien);
            if (taiKhoanCuaNhanVienDangChon == null)
            {
                MetroMessageBox.Show(Owner, "Nhân viên bạn chọn không có tài khoản. \n Vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtHienThiMatKhau1.Text = taiKhoanCuaNhanVienDangChon.MatKhau;
                lblHienThiTenTaiKhoan.Text = taiKhoanCuaNhanVienDangChon.TaiKhoan1;
            }
           
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
