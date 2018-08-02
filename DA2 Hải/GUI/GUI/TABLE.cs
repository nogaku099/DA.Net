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

namespace GUI
{
    public partial class hinhBan5 : MetroForm
    {
        List<Ban> listBan = new List<Ban>();
        BUS_BAN bus_ban = new BUS_BAN();
        BUS_CHITIETHOADON bus_chiTietHoaDon = new BUS_CHITIETHOADON();
        BUS_HOADON bus_hoaDon = new BUS_HOADON();
        String tenNhanVien = "";
        

        public hinhBan5()
        {

            InitializeComponent();
        }

        public hinhBan5(String ten)
        {
            this.tenNhanVien = ten;

            InitializeComponent();
        }


        public void datTenBan(List<Ban> ban)
        {

            txtTenBan1.Text = ban[0].MaBan;
            txtTenBan2.Text = ban[1].MaBan;
            txtTenBan3.Text = ban[2].MaBan;
            txtTenBan4.Text = ban[3].MaBan;
            txtTenBan5.Text = ban[4].MaBan;
            txtTenBan6.Text = ban[5].MaBan;
            txtTenBan7.Text = ban[6].MaBan;
            txtTenBan8.Text = ban[7].MaBan;
            txtTenBan9.Text = ban[8].MaBan;
            txtTenBan10.Text = ban[9].MaBan;
            txt_TenBan11.Text = ban[10].MaBan;
            txt_TenBan12.Text = ban[11].MaBan;
            txt_TenBan13.Text = ban[12].MaBan;
            txt_TenBan14.Text = ban[13].MaBan;
            txt_TenBan15.Text = ban[14].MaBan;
        }

        public void datTenBan2()
        {
           
                    txtTenBan1.Text = "Bàn 1";
         
                    txtTenBan2.Text = "Bàn 2";
               
                    txtTenBan3.Text = "Bàn 3";
               
                    txtTenBan4.Text = "Bàn 4";
          
                    txtTenBan5.Text = "Bàn 5";
          
                    txtTenBan6.Text = "Bàn 6";
             
                    txtTenBan7.Text = "Bàn 7";
         
                    txtTenBan8.Text = "Bàn 8";
           
                    txtTenBan9.Text = "Bàn 9";
              
                    txtTenBan10.Text = "Bàn 10";
           
                    txt_TenBan11.Text = "Bàn 11";
        
                    txt_TenBan12.Text = "Bàn 12";
           
                    txt_TenBan13.Text = "Bàn 13";
            
                    txt_TenBan14.Text = "Bàn 14";
         
                    txt_TenBan15.Text = "Bàn 15";
  
        }


        public bool kiemTraHoaDonBan(String maban)
        {
            try
            {
                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maban);
                List<ChiTietHoaDon> chitiet = bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon);

                if (chitiet != null)
                    return true;
                return false;

            }
            catch (Exception)
            {
                return false;
            }


        }

        public void setTrangThai(Label ten, PictureBox pic)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            if (kiemTraHoaDonBan(ten.Text) == true)
            {
                pic.BackgroundImage = Properties.Resources.Dinner_128;
                Ban item = new Ban();
                item.MaBan = ten.Text;
                item.TrangThai = "Có Người";
                ten.ForeColor = Color.DimGray;
                ten.Font = new Font("Bauhaus 93", 14, FontStyle.Bold);


                bus_ban.capNhatTrangThai(item);

            }
            else
            {
                pic.BackgroundImage = Properties.Resources.trong;
                Ban item = new Ban();
                item.MaBan = ten.Text;
                item.TrangThai = "Trống";
                ten.ForeColor = Color.DeepSkyBlue;
                ten.Font = new Font("Bauhaus 93", 14, FontStyle.Bold);
                bus_ban.capNhatTrangThai(item);
            }
        }


        private void TABLE_Load(object sender, EventArgs e)
        {
            MAIN mainForm = new MAIN();
            tenNhanVien = mainForm.getMaNhanVien();
           
            
            
            List<Ban> listBan = bus_ban.layTatCaBan();
            for(int i = 1; i <= listBan.Count; i++)
            {
                if(i<10)
                box_ChuyenBan.Items.Add("B00" + i);
                if (i == 10)
                    box_ChuyenBan.Items.Add("B010");
                if (i>10)
                    box_ChuyenBan.Items.Add("B0" + i);

            }


            panelChucNang.Visible = false;
            panelChuyeBan.Visible = false;
            listBan = bus_ban.layTatCaBan();


            datTenBan(listBan);
            setTrangThai(txtTenBan1, hinhBan1);
            setTrangThai(txtTenBan2, hinhBan2);
            setTrangThai(txtTenBan3, hinhBan3);
            setTrangThai(txtTenBan4, hinhBan4);
            setTrangThai(txtTenBan5, hinhBanSo5);
            setTrangThai(txtTenBan6, hinhBan6);
            setTrangThai(txtTenBan7, hinhBan7);
            setTrangThai(txtTenBan8, hinhBan8);
            setTrangThai(txtTenBan9, hinhBan9);
            setTrangThai(txtTenBan10, hinhBan10);
            setTrangThai(txt_TenBan11, hinhBan11);
            setTrangThai(txt_TenBan12, hinhBan12);
            setTrangThai(txt_TenBan13, hinhBan13);
            setTrangThai(txt_TenBan14, hinhBan14);
            setTrangThai(txt_TenBan15, hinhBan15);

    





        }

        public bool kiemTraBan(String maban)
        {
            if (bus_hoaDon.layHoaDonTheoMaBan(maban) == null)
                return true;
            else
                return false;


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //tao hoa don moi set chua thanh toan
            
            if (kiemTraBan(txtTenBan1.Text) == true)
            {
              
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = tenNhanVien;
                String khacHang = "";
       
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan1.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }


            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(1,tenNhanVien);
            form.Show();

           

     
            





        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan2.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan2.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }

            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(2,tenNhanVien);
            form.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan3.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
           
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan3.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(3,tenNhanVien);
            form.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan4.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
           
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan4.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(4,tenNhanVien);
            form.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan5.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan5.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(5,tenNhanVien);
            form.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan6.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan6.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(6,tenNhanVien);
            form.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan7.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan7.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(7,tenNhanVien);
            form.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan8.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan8.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(8,tenNhanVien);
            form.Show();
        }

        
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan9.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan9.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(9,tenNhanVien);
            form.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txtTenBan10.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txtTenBan10.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
         
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(10,tenNhanVien);
            form.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txt_TenBan11.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txt_TenBan11.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(11,tenNhanVien);
            form.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txt_TenBan12.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txt_TenBan12.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(12,tenNhanVien);
            form.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txt_TenBan13.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txt_TenBan13.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(13,tenNhanVien);
            form.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txt_TenBan14.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txt_TenBan14.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(14,tenNhanVien);
            form.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (kiemTraBan(txt_TenBan15.Text) == true)
            {
                //tao hoa don moi set chua thanh toan
                DateTime ngayLap = DateTime.Now.Date;
                String nhanVien = "";
                String khacHang = "";
                float phuThu = 0;
                float tongTien = 0;
                String trangThai = "Chưa Thanh Toán";
                String maBan = txt_TenBan15.Text;
                String maHoaDon = bus_hoaDon.taoMa();
                HoaDon hoadon = new HoaDon(maHoaDon, ngayLap, tongTien, nhanVien, maBan, trangThai);
                bus_hoaDon.themHoaDon(hoadon);
            }
            this.Close();
            SELLECT_MENNU form = new SELLECT_MENNU(15,tenNhanVien);
            form.Show();
            
        }

        private void hinhBan3_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan3.Bounds.X + 113, hinhBan3.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan3.Bounds.X, hinhBan3.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan3_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void hinhBan1_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan1.Bounds.X + 113, hinhBan1.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan1.Bounds.X, hinhBan1.Bounds.Y, panelChucNang.Width, panelChucNang.Height);

        }

        private void hinhBan1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        int dem = 0;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (dem % 2 == 0)
            {
                panelChucNang.Visible = true;
                
                dem++;
            }
            else
            {
                panelChucNang.Visible = false;
                dem++;
            }
        }

  
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            panelChuyeBan.Visible = true;
            panelChucNang.Visible = false;
            panelChuyeBan.Bounds = panelChucNang.Bounds;
            
   
           
                //HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan("B001");
                //hoadon.MaBan = maChuyenBan;
                //bus_hoaDon.capNhatHoaDon(hoadon);
                //Ban item = new Ban(txtTenBan1.Text, "Trống");
                //bus_ban.capNhatTrangThai(item);
                //Ban item2 = new Ban(maChuyenBan, "Có Người");
                //bus_ban.capNhatTrangThai(item2);

           






        }

        public String xacDinhBan()
        {
            String maBan = "";
            if (panelChuyeBan.Bounds == hinhBan1.Bounds)
                maBan = txtTenBan1.Text;
            if (panelChuyeBan.Bounds == hinhBan2.Bounds)
                maBan = txtTenBan2.Text;
            if (panelChuyeBan.Bounds == hinhBan3.Bounds)
                maBan = txtTenBan3.Text;
            if (panelChuyeBan.Bounds == hinhBan4.Bounds)
                maBan = txtTenBan4.Text;
            if (panelChuyeBan.Bounds == hinhBanSo5.Bounds)
                maBan = txtTenBan5.Text;
            if (panelChuyeBan.Bounds == hinhBan6.Bounds)
                maBan = txtTenBan6.Text;
            if (panelChuyeBan.Bounds == hinhBan7.Bounds)
                maBan = txtTenBan7.Text;
            if (panelChuyeBan.Bounds == hinhBan8.Bounds)
                maBan = txtTenBan8.Text;
            if (panelChuyeBan.Bounds == hinhBan9.Bounds)
                maBan = txtTenBan9.Text;
            if (panelChuyeBan.Bounds == hinhBan10.Bounds)
                maBan = txtTenBan10.Text;
            if (panelChuyeBan.Bounds == hinhBan11.Bounds)
                maBan = txt_TenBan11.Text;
            if (panelChuyeBan.Bounds == hinhBan12.Bounds)
                maBan = txt_TenBan12.Text;
            if (panelChuyeBan.Bounds == hinhBan13.Bounds)
                maBan = txt_TenBan13.Text;
            if (panelChuyeBan.Bounds == hinhBan14.Bounds)
                maBan = txt_TenBan14.Text;
            if (panelChuyeBan.Bounds == hinhBan15.Bounds)
                maBan = txt_TenBan15.Text;


            return maBan;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {


                String maban = xacDinhBan();
                String maChuyenBan = box_ChuyenBan.SelectedItem.ToString();
                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maban);
                hoadon.MaBan = maChuyenBan;
                bus_hoaDon.capNhatHoaDon(hoadon);
                Ban item = new Ban(maban, "Trống");
                bus_ban.capNhatTrangThai(item);
                Ban item2 = new Ban(maChuyenBan, "Có Người");
                bus_ban.capNhatTrangThai(item2);


            

        }

        private void hinhBan2_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan2.Bounds.X + 113, hinhBan2.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan2.Bounds.X, hinhBan2.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
           
        }

        private void hinhBan4_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan4.Bounds.X + 113, hinhBan4.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan4.Bounds.X, hinhBan4.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBanSo5_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBanSo5.Bounds.X + 113, hinhBanSo5.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBanSo5.Bounds.X, hinhBanSo5.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan6_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan6.Bounds.X + 113, hinhBan6.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan6.Bounds.X, hinhBan6.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan7_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Ban.SetBounds(hinhBan7.Bounds.X + 113, hinhBan7.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan7.Bounds.X, hinhBan7.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan8_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan8.Bounds.X + 113, hinhBan8.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan8.Bounds.X, hinhBan8.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan9_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan9.Bounds.X + 113, hinhBan9.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan9.Bounds.X, hinhBan9.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan10_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan10.Bounds.X + 113, hinhBan10.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan10.Bounds.X, hinhBan10.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan11_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan11.Bounds.X + 113, hinhBan11.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan11.Bounds.X, hinhBan11.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan12_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan12.Bounds.X + 113, hinhBan12.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan12.Bounds.X, hinhBan12.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan13_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan13.Bounds.X + 113, hinhBan13.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan13.Bounds.X, hinhBan13.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan14_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan14.Bounds.X + 113, hinhBan14.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan14.Bounds.X, hinhBan14.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void hinhBan15_MouseHover(object sender, EventArgs e)
        {
            btn_Ban.SetBounds(hinhBan15.Bounds.X + 113, hinhBan15.Bounds.Y + 101, btn_Ban.Width, btn_Ban.Height);
            panelChucNang.SetBounds(hinhBan15.Bounds.X, hinhBan15.Bounds.Y, panelChucNang.Width, panelChucNang.Height);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            panelChuyeBan.Visible = false;
        }
    }
}
