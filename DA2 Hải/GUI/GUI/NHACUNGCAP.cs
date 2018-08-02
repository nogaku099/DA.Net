using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using MetroFramework;
using MetroFramework.Forms;

namespace GUI
{
    public partial class NHACUNGCAP : MetroForm
    {
        BUS_NHACUNGCAP bus_nhaCungCap = new BUS_NHACUNGCAP();
        BUS_NGUYENLIEU bus_nguyenLieu = new BUS_NGUYENLIEU();
        int demSoLanXoa = 0;
        public NHACUNGCAP()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            grid_nhaCungCap.DataSource = bus_nhaCungCap.LayNhaCungCap();
            grid_nhaCungCap.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            grid_nhaCungCap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            grid_nhaCungCap.Columns[2].HeaderText = "ĐSố Điện Thoại ";
            grid_nhaCungCap.Columns[3].HeaderText = "Địa Chỉ";
            grid_nhaCungCap.Columns[4].HeaderText = "Mã Nguyên Liệu";
            grid_nhaCungCap.Columns[5].HeaderText = "Giá";

            grid_nhaCungCap.Columns[0].Width = 150;
            grid_nhaCungCap.Columns[1].Width = 150;
            grid_nhaCungCap.Columns[2].Width = 150;
            grid_nhaCungCap.Columns[3].Width = 150;
            grid_nhaCungCap.Columns[4].Width = 150;
            grid_nhaCungCap.Columns[5].Width = 150;
        }
        private void NHACUNGCAP_Load(object sender, EventArgs e)
        {
            List<NguyenLieu> listNguyenLieu = bus_nguyenLieu.layNguyenLieu();

            
            for(int i=0;i<listNguyenLieu.Count ; i++)
            {
                box_nguyenLieu.Items.Insert(i, listNguyenLieu[i].TenNguyenLieu);
              
            }
           
               

            
               
               

            
            LoadForm();
        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                List<NguyenLieu> listNguyenLieu = bus_nguyenLieu.layNguyenLieu();
                String maNhaCungCap = "NCC" + (bus_nhaCungCap.LayNhaCungCap().Count + 1 + demSoLanXoa);
                String tenNhaCungCap = txtTenNhaCungCap.Text;
                String diaChi = txt_diaChi.Text;
                String dienThoai = txt_soDienThoai.Text;
                String maNguyenLieu = listNguyenLieu[box_nguyenLieu.SelectedIndex].MaNguyenLieu;
                float gia = float.Parse(txt_giaNhap.Text);
                NhaCungCap nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, dienThoai, diaChi, maNguyenLieu, gia);
                if (bus_nhaCungCap.Them(nhaCungCap) == true)
                    MetroMessageBox.Show(this, "Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

            }
       

            LoadForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String maNhaCungCap = grid_nhaCungCap.CurrentRow.Cells[0].Value.ToString();
            demSoLanXoa++;

            if (bus_nhaCungCap.Xoa(maNhaCungCap) == true)
                MetroMessageBox.Show(this, "Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadForm();
        }

        private void grid_nhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_nhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenNhaCungCap.Text = grid_nhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txt_soDienThoai.Text = grid_nhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txt_diaChi.Text = grid_nhaCungCap.CurrentRow.Cells[3].Value.ToString();
            txt_giaNhap.Text = grid_nhaCungCap.CurrentRow.Cells[5].Value.ToString();
        }

        private void box_nguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
