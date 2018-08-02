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
    public partial class QuanLySanPham : MetroForm
    {
        BUS_SANPHAM bus_sanPham = new BUS_SANPHAM();
        BUS_NGUYENLIEU bus_nguyenLieu = new BUS_NGUYENLIEU();
        BUS_CHITIETSANPHAM bus_chiTietSanPham = new BUS_CHITIETSANPHAM();
        String duongDanHinh = "";
        List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
        List<ChiTietSanPham> listChiTietSanPham = new List<ChiTietSanPham>();
        int demSoLanXoa = 0;
        String maNguyenLieu = "";

        public QuanLySanPham()
        {
            InitializeComponent();
        }

        public void hienThiSanPham()
        {
            gridSanPham.DataSource = bus_sanPham.laySanPham();

            gridSanPham.Columns[0].Width = 200;
            gridSanPham.Columns[1].Width = 150;
            gridSanPham.Columns[2].Width = 100;
            gridSanPham.Columns[3].Width = 100;
            gridSanPham.Columns[4].Width = 200;
          


            gridSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            gridSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            gridSanPham.Columns[2].HeaderText = "Loại Sản Phẩm";
            gridSanPham.Columns[3].HeaderText = "Đường Dẫn";
            gridSanPham.Columns[4].HeaderText = "Giá Sản Phẩm";
          

           


        }

        public String layMaNguyenLieuTheoTen(String ten)
        {
            String maNguyenLieu = "";
            listNguyenLieu = bus_nguyenLieu.layNguyenLieu();
            for (int i = 0; i <= listNguyenLieu.Count - 1; i++)
            {
                if (listNguyenLieu[i].TenNguyenLieu == ten)
                   maNguyenLieu =  listNguyenLieu[i].MaNguyenLieu;
            }
            return maNguyenLieu;
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            gridChiTietSanPham.Columns.Add("tensanpham", "Tên Nguyên Liệu");

            gridChiTietSanPham.Columns[0].Width = 150;
            hienThiSanPham();
            listNguyenLieu =  bus_nguyenLieu.layNguyenLieu();
            for (int i = 0; i <= listNguyenLieu.Count - 1; i++)
            {
                box_NguyenLieu.Items.Add(listNguyenLieu[i].TenNguyenLieu);

            }




        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog themHinh = new OpenFileDialog();
            themHinh.Title = "Chọn Đường Dẫn Của Hình";
            themHinh.FilterIndex = 3;
            themHinh.Filter = "PNG file(*.PNG)|*.PNG|JPG file(*.JPG)|*.JPG|All files (*.*)|*.*";
            if (themHinh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                String duongDan = themHinh.FileName;
                duongDanHinh = duongDan;
                txt_duongDan.Text = themHinh.FileName;




            }
            
        }

        private void btn_themSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                String tenSanPham = txtTenSanPham.Text;
                String loaiSanPham = txtLoaiSanPham.Text;

                String duongDan = duongDanHinh;
                String maSanPham = "SP"+(bus_sanPham.laySanPham().Count + 1+demSoLanXoa);
                float giaSanPham = float.Parse(txtGiaSanPham.Text);

                SanPham item = new SanPham(maSanPham, tenSanPham, loaiSanPham, duongDan, giaSanPham);
                bus_sanPham.themSanPham(item);
                gridSanPham.DataSource = bus_sanPham.laySanPham();
            }
            catch (Exception ex)
            {

            }
          

           

            
        

        
           
           
            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            demSoLanXoa++;
            String maSanPham = gridSanPham.SelectedCells[0].Value.ToString();
            bus_sanPham.xoaSanPham(maSanPham);
            gridSanPham.DataSource = bus_sanPham.laySanPham();
            MetroMessageBox.Show(Owner, "Đã Xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            String maSanpham = gridSanPham.CurrentRow.Cells[0].Value.ToString();
            SanPham sanPham = bus_sanPham.laySanPhanTheoMa(maSanpham);

            sanPham.TenSanPham = txtTenSanPham.Text;
            sanPham.LoaiSanPham = txtLoaiSanPham.Text;
 
            sanPham.GiaSanPham = float.Parse(txtGiaSanPham.Text);
            sanPham.DuongDan = txt_duongDan.Text;

            bus_sanPham.capNhatSanPham(sanPham);
            gridSanPham.DataSource = bus_sanPham.laySanPham();

            MetroMessageBox.Show(this, "Câp Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
       

        }

        public void taiChiTietSanPham()
        {
        


            for (int i = 0; i <= listChiTietSanPham.Count - 1; i++)
            {
                String maNguyenLieu = "";
                maNguyenLieu = listChiTietSanPham[i].MaNguyenLieu;

                gridChiTietSanPham.Rows.Add(bus_nguyenLieu.layNguyenLieuTheoMa(maNguyenLieu).TenNguyenLieu);

            }

        }

        private void gridSanPham_MouseClick(object sender, MouseEventArgs e)
        {

            gridChiTietSanPham.Rows.Clear();
            try
            {

                
                String tenSanPham = gridSanPham.CurrentRow.Cells[1].Value.ToString();
                float giaSanPham = float.Parse(gridSanPham.CurrentRow.Cells[4].Value.ToString());
                String loaiSanPham = gridSanPham.CurrentRow.Cells[2].Value.ToString();
                String maSanPham = gridSanPham.CurrentRow.Cells[0].Value.ToString();
                listChiTietSanPham = bus_chiTietSanPham.layChiTietSanPhamTheoMaSanPham(maSanPham);


                String duongDan = gridSanPham.CurrentRow.Cells[3].Value.ToString();
                picshow.BackgroundImage = new Bitmap(duongDan);

                txtTenSanPham.Text = tenSanPham;
                txtGiaSanPham.Text = giaSanPham.ToString();
                txtLoaiSanPham.Text = loaiSanPham;
               
                txt_duongDan.Text = duongDan;

                taiChiTietSanPham();
                
            }
            catch(Exception)
            {

            }
        }

        private void gridSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_themChiTietSanPham_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(txt_soLuongSuDung.Text);
            String maCuaNguyenLieu = maNguyenLieu;
            String maSanPham = gridSanPham.CurrentRow.Cells[0].Value.ToString();
            String maChiTietSanPham = bus_chiTietSanPham.taoMa();

            ChiTietSanPham chitiet = new ChiTietSanPham(maChiTietSanPham, maSanPham, maCuaNguyenLieu, soLuong);
            bus_chiTietSanPham.themChiTietSanPham(chitiet);
            
           
            
        }

        private void box_NguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            maNguyenLieu = layMaNguyenLieuTheoTen(box_NguyenLieu.SelectedItem.ToString());

        }
    }
}
