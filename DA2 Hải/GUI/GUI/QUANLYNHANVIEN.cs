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
    public partial class QUANLYNHANVIEN : MetroForm
    {
        BUS_NHANVIEN bus_nhanVien = new BUS_NHANVIEN();
        BUS_TAIKHOAN bus_taiKhoan = new BUS_TAIKHOAN();
        int demSoLanXoa = 0;

        public QUANLYNHANVIEN()
        {
            InitializeComponent();
        }

        public void hienThiGridNhanVien()
        {
            grid_nhanVien.DataSource = bus_nhanVien.layNhanVien();

            grid_nhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            grid_nhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            grid_nhanVien.Columns[2].HeaderText = "Ngày Sinh";
            grid_nhanVien.Columns[3].HeaderText = "Địa Chỉ";
            grid_nhanVien.Columns[4].HeaderText = "Chức Vụ";
            grid_nhanVien.Columns[5].HeaderText = "Số Điện Thoại";

            grid_nhanVien.Columns[0].Width = 150;
            grid_nhanVien.Columns[1].Width = 150;
            grid_nhanVien.Columns[2].Width = 150;
            grid_nhanVien.Columns[3].Width = 150;
            grid_nhanVien.Columns[4].Width = 250;
            grid_nhanVien.Columns[5].Width = 150;



        }

        private void QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
                
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(w, h);
            this.Location = new Point(0, 0);
            hienThiGridNhanVien();
           

        }

        private void grid_nhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            String tenNhanVien = grid_nhanVien.CurrentRow.Cells[1].Value.ToString();
            String ngaySinh = grid_nhanVien.CurrentRow.Cells[2].Value.ToString();
            String chucVu = grid_nhanVien.CurrentRow.Cells[4].Value.ToString();
            String diaChi = grid_nhanVien.CurrentRow.Cells[3].Value.ToString();
            String soDienThoai = grid_nhanVien.CurrentRow.Cells[5].Value.ToString();

            txtTenNhanVien.Text = tenNhanVien;
            txt_ngaySinh.Text = ngaySinh;
            txt_chucVu.Text = chucVu;
            txt_diaChi.Text = diaChi;
            txt_soDienThoai.Text = soDienThoai;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            demSoLanXoa++;
            String maNhanVien = grid_nhanVien.CurrentRow.Cells[0].Value.ToString();
            bus_nhanVien.xoaNhanVien(maNhanVien);
            bus_taiKhoan.xoa(maNhanVien);
            hienThiGridNhanVien();

        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            String tenNhanVien = txtTenNhanVien.Text;
            String diaChi = txt_diaChi.Text;
            String chucVu = txt_chucVu.Text;
            String soDienThoai = txt_soDienThoai.Text;
            String ngaySinh = txt_ngaySinh.Text;
            String maNhanVien = "NV" + (bus_nhanVien.layNhanVien().Count + 1 + demSoLanXoa);

            NhanVien nhanVien = new NhanVien(maNhanVien, tenNhanVien, ngaySinh, diaChi, chucVu, soDienThoai);
            bus_nhanVien.themNhanVien(nhanVien);
            bus_taiKhoan.them(new TaiKhoan("", "", maNhanVien));




            hienThiGridNhanVien();

           

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            String tenNhanVien = txtTenNhanVien.Text;
            String diaChi = txt_diaChi.Text;
            String soDienThoai = txt_soDienThoai.Text;
            String ngaySinh = txt_ngaySinh.Text;
            String chucVu = txt_chucVu.Text;
            String maNhanVien = grid_nhanVien.CurrentRow.Cells[0].Value.ToString();

            NhanVien nhanVien = new NhanVien(maNhanVien, tenNhanVien, ngaySinh, diaChi, chucVu, soDienThoai);
            bus_nhanVien.capNhatNhanVien(nhanVien);
            hienThiGridNhanVien();

            if(bus_nhanVien.capNhatNhanVien(nhanVien) == true)
            {
                MetroMessageBox.Show(this, "Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_taiKhoan_Click(object sender, EventArgs e)
        {
            QUANLYTAIKHOAN form = new QUANLYTAIKHOAN();
            form.Show();
        }
    }
}
