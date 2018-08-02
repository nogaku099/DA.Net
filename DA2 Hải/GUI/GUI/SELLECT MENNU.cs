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
    public partial class SELLECT_MENNU : MetroForm
    {
        #region khaibaobien
        String maNhanVien = "";

        BUS_SANPHAM bus_sanPham = new BUS_SANPHAM();
        BUS_HOADON bus_hoaDon = new BUS_HOADON();
        BUS_CHITIETHOADON bus_chiTietHoaDon = new BUS_CHITIETHOADON();
        BUS_CHITIETSANPHAM bus_chiTietSanPham = new BUS_CHITIETSANPHAM();
        BUS_KHO bus_kho = new BUS_KHO();
        String tenNhanVien = "";

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;

        String ma = "";

        int soTrang = 1;
        int ban = 0;
        String maCuaBan = "";
       
        List<SanPham> currentList = new List<SanPham>();
        List<ChiTietHoaDon> myListHoaDon = new List<ChiTietHoaDon>();
        List<LISTHOADON> listhienthihoadon = new List<LISTHOADON>();
        List<ChiTietHoaDon> chiTietHoaDo = new List<ChiTietHoaDon>();
        List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();


        List<ChiTietHoaDon> listSanPhamOrder = new List<ChiTietHoaDon>();



        #endregion

        #region hamCustom

        public void loadSanPham(List<SanPham> trangdau)
        {
            try
            {

                for (int i = 0; i <= trangdau.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        txtTenSanPham1.Text = trangdau[0].TenSanPham;
                        txtGiaSanPham1.Text = trangdau[0].GiaSanPham.ToString();
                        hinhSanPham1.BackgroundImage = new Bitmap(@trangdau[0].DuongDan);

                    }
                    else if (i == 1)
                    {
                        tenSanPham2.Text = trangdau[1].TenSanPham;
                        giaSanPham2.Text = trangdau[1].GiaSanPham.ToString();
                        hinhSanPham2.BackgroundImage = new Bitmap(@trangdau[1].DuongDan);

                    }
                    else if (i == 2)
                    {
                        tenSanPham3.Text = trangdau[2].TenSanPham;
                        giaSanPham3.Text = trangdau[2].GiaSanPham.ToString();
                        hinhSanPham3.BackgroundImage = new Bitmap(@trangdau[2].DuongDan);

                    }
                    else if (i == 3)
                    {
                        tenSanPham4.Text = trangdau[3].TenSanPham;
                        giaSanPham4.Text = trangdau[3].GiaSanPham.ToString();
                        picSanPham4.BackgroundImage = new Bitmap(@trangdau[3].DuongDan);

                    }
                    else if (i == 4)
                    {
                        tenSanPham5.Text = trangdau[4].TenSanPham;
                        giaSanPham5.Text = trangdau[4].GiaSanPham.ToString();
                        picSanPham5.BackgroundImage = new Bitmap(@trangdau[4].DuongDan);

                    }
                    else if (i == 5)
                    {
                        tenSanPham6.Text = trangdau[5].TenSanPham;
                        giaSanPham6.Text = trangdau[5].GiaSanPham.ToString();
                        picSanPham6.BackgroundImage = new Bitmap(@trangdau[5].DuongDan);
                    }
                }
            }



            catch (Exception)
            {

            }
        }


       

        #endregion

        #region hamHeThong


      

        public SELLECT_MENNU()
        {
            
           
            InitializeComponent();
        }

      
        public SELLECT_MENNU(int ban,String ten)
        {
            this.ban = ban;
            this.tenNhanVien = ten;
            InitializeComponent();
        }


        public void hienThiBan(String ban)
        {

            try{
                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(ban);
                List<ChiTietHoaDon> chitiet = bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon);
                listhienthihoadon.Clear();
             
                //gridSelectMenu.DataSource = chitiet;
                myListHoaDon = chitiet;

                for (int i = 0; i <= myListHoaDon.Count - 1; i++)
                {
                    String tenSanpham = bus_sanPham.laySanPhanTheoMa(myListHoaDon[i].MaSanPham).TenSanPham;
                    float gia = (float)bus_sanPham.laySanPhanTheoMa(myListHoaDon[i].MaSanPham).GiaSanPham;
                   
                    int soLuong = (int)bus_chiTietHoaDon.laySanPhanTheoMa(myListHoaDon[i].MaChiTietHoaDon).SoLuong;
                    float thanhTien = (float)(soLuong * gia);
                    listhienthihoadon.Add(new LISTHOADON(tenSanpham, gia,soLuong,thanhTien));
                 

                }
                hienthitest(listhienthihoadon);

            }
            catch(Exception)
            {

            }
        }

        public void layMaBan()
        {
            if (this.ban == 1)
            {
                maCuaBan = "B001";

            }
            if (this.ban == 2)
            {
                maCuaBan = "B002";

            }
            if (this.ban == 3)
            {
                maCuaBan = "B003";

            }
            if (this.ban == 4)
            {
                maCuaBan = "B004";

            }
            if (this.ban == 5)
            {
                maCuaBan = "B005";

            }
            if (this.ban == 6)
            {
                maCuaBan = "B006";

            }
            if (this.ban == 7)
            {
                maCuaBan = "B007";

            }
            if (this.ban == 8)
            {
                maCuaBan = "B008";

            }
            if (this.ban == 9)
            {
                maCuaBan = "B009";

            }
            if (this.ban == 10)
            {
                maCuaBan = "B010";

            }
            if (this.ban == 11)
            {
                maCuaBan = "B011";

            }
            if (this.ban == 12)
            {
                maCuaBan = "B012";

            }
            if (this.ban == 13)
            {
                maCuaBan = "B013";

            }
            if (this.ban == 14)
            {
                maCuaBan = "B014";

            }
            if (this.ban == 15)
            {
                maCuaBan = "B015";

            }
        }

        public void hienthitest(List<LISTHOADON> list)
        {
            gridtesthienthihoadon.Rows.Clear();



            for (int i=0;i<=list.Count - 1; i++)
            {
               
                gridtesthienthihoadon.Rows.Add(list[i].tenSanPham,list[i].soLuong, list[i].donGia,list[i].thanhTien);
            



            }
       
          
        }

        private void SELLECT_MENNU_Load(object sender, EventArgs e)
        {
            MAIN mainForm = new MAIN();
            maNhanVien = mainForm.getMaNhanVien();
            gridtesthienthihoadon.Visible = true;
            gridHoaDonThanhToan.Visible = false;
            gridtesthienthihoadon.Columns.Add("tensanpham", "Tên Sản Phẩm");
            gridtesthienthihoadon.Columns.Add("soluong", "Số Lượng");
            gridtesthienthihoadon.Columns.Add("dongia", "Đơn Giá");
            gridtesthienthihoadon.Columns.Add("thanhtien", "Thành Tiền");

            layMaBan();
            hienThiBan(maCuaBan);
            hienthitest(listhienthihoadon);


            if (tongTien() == 0)
                btn_thanhToan.Visible = false;

         
         

            

            List<SanPham> trangdau = bus_sanPham.laySanPhamTrangDau();
            loadSanPham(trangdau);

            currentList = trangdau;

            int tongSanPham = bus_sanPham.laySanPham().Count();
            soTrang = tongSanPham / 6;
            if (tongSanPham % 6 != 0)
                soTrang = soTrang + 1;
            for (int i = 1; i <= soTrang; i++)
                boxPhanTrang.Items.Add(i);
            tongTien();

         

           
            
        }

        public void kiemTraList(List<SanPham> list)
        {
            for(int i = 0; i <= list.Count - 1; i++)
            {
                if (i == 0)
                {
                    txtTenSanPham1.Visible = true;
                    txtGiaSanPham1.Visible = true;
                    hinhSanPham1.Visible = true;
                }
                else if (i == 1)
                {
                    tenSanPham2.Visible = true;
                    giaSanPham2.Visible = true;
                    hinhSanPham2.Visible = true;
                }
                else if(i == 2)
                {
                    tenSanPham3.Visible = true;
                    giaSanPham3.Visible = true;
                    hinhSanPham3.Visible = true;
                }
                else if (i == 3)
                {
                    tenSanPham4.Visible = true;
                    giaSanPham4.Visible = true;
                    picSanPham4.Visible = true;
                }
                else if (i == 4)
                {
                    tenSanPham5.Visible = true;
                    giaSanPham5.Visible = true;
                    picSanPham5.Visible = true;
                }
                else if (i == 5)
                {
                    tenSanPham6.Visible = true;
                    giaSanPham6.Visible = true;
                    picSanPham6.Visible = true;
                }
            }
        }

        public void reset()
        {
            txtTenSanPham1.Visible = false;
            tenSanPham2.Visible = false;
            tenSanPham3.Visible = false;
            tenSanPham4.Visible = false;
            tenSanPham5.Visible = false;
            tenSanPham6.Visible = false;

            txtGiaSanPham1.Visible = false;
            giaSanPham2.Visible = false;
            giaSanPham3.Visible = false;
            giaSanPham4.Visible = false;
            giaSanPham5.Visible = false;
            giaSanPham6.Visible = false;

            hinhSanPham1.Visible = false;
            hinhSanPham2.Visible = false;
            hinhSanPham3.Visible = false;
            picSanPham4.Visible = false;
            picSanPham5.Visible = false;
            picSanPham6.Visible = false;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxPhanTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
            int trang = Int32.Parse(boxPhanTrang.SelectedItem.ToString());
            if (trang == 1)
            {
                List<SanPham> trangdau = bus_sanPham.laySanPhamTrangDau();
                kiemTraList(trangdau);
                currentList = trangdau;

            }
            else
            {
                
                List<SanPham> sangPhamTheoTrang = bus_sanPham.laySanPhamTheoTrang(6 * (trang-1), 6);
                kiemTraList(sangPhamTheoTrang);
                currentList = sangPhamTheoTrang;
            }

            loadSanPham(currentList);
           

        }

 

        private void hinhSanPham1_Click(object sender, EventArgs e)
        {
            try
            {
                

                String maSanPham = currentList[0].MaSanPham;
         
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
            
            
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();
       


                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
               
               
                hienThiBan(maCuaBan);

                tongTien();




            }
            catch (Exception)
            {

            }
          
        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void hinhSanPham2_Click(object sender, EventArgs e)
        {
           
            try
            {

                count2++;

                String maSanPham = currentList[1].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();
              
               
                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
                tongTien();
                if (tongTien() != 0)
                    btn_thanhToan.Visible = true;


                hienThiBan(maCuaBan);
            }
            catch (Exception)
            {

            }
        }

        private void hinhSanPham3_Click(object sender, EventArgs e)
        {
            count3++;
            try
            {
                
                String maSanPham = currentList[2].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();
              
                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
                tongTien();
                if (tongTien() != 0)
                    btn_thanhToan.Visible = true;

                hienThiBan(maCuaBan);
            }
            catch (Exception)
            {

            }
        }

        private void picSanPham4_Click(object sender, EventArgs e)
        {
            count4++;
            try
            {
                String maSanPham = currentList[3].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();

                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
                tongTien();

                if (tongTien() != 0)
                    btn_thanhToan.Visible = true;

                hienThiBan(maCuaBan);
            }
            catch (Exception)
            {

            }
        }

        private void picSanPham5_Click(object sender, EventArgs e)
        {
            try
            {
                count5++;
                String maSanPham = currentList[4].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();

                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
                tongTien();
                if (tongTien() != 0)
                    btn_thanhToan.Visible = true;

                hienThiBan(maCuaBan);
            }
            catch (Exception)
            {

            }
        }

        private void picSanPham6_Click(object sender, EventArgs e)
        {
            count6++;
            try
            {
                String maSanPham = currentList[5].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();

                ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                bus_chiTietHoaDon.themChiTietHoaDon(chitiet);
                tongTien();
                if (tongTien() != 0)
                    btn_thanhToan.Visible = true;

                hienThiBan(maCuaBan);
            }
            catch (Exception)
            {

            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                capNhatSoLuongTonTrongKho();

                gridtesthienthihoadon.Visible = false;
                panelHoaDon.Visible = true;
                txtpanel_tongTien.Text = tongTien().ToString();
                txtpanel_ngayLap.Text = DateTime.Now.Date.ToString();
                txtpanel_tenNhanVien.Text = tenNhanVien;

                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan);
                hoadon.TrangThai = "Đã Thanh Toán";
                hoadon.TongTien = tongTien();
                hoadon.MaNhanVien = maNhanVien;
                
                bus_hoaDon.capNhatHoaDon(hoadon);
                gridHoaDonThanhToan.Visible = true;
                gridHoaDonThanhToan.Columns.Add("tensanpham", "Tên Sản Phẩm");
                gridHoaDonThanhToan.Columns.Add("soluong", "Số Lượng");
                gridHoaDonThanhToan.Columns.Add("dongia", "Đơn Giá");
                gridHoaDonThanhToan.Columns.Add("thanhtien", "Thành Tiền");
                gridHoaDonThanhToan.Columns[0].Width = 85;
                gridHoaDonThanhToan.Columns[1].Width = 85;
                gridHoaDonThanhToan.Columns[2].Width = 85;
                gridHoaDonThanhToan.Columns[3].Width = 85;


                for (int i = 0; i <= listhienthihoadon.Count - 1; i++)
                {

                    gridHoaDonThanhToan.Rows.Add(listhienthihoadon[i].tenSanPham, listhienthihoadon[i].soLuong, listhienthihoadon[i].donGia, listhienthihoadon[i].thanhTien);




                }

              


            }
            catch (Exception)
            {

            }


           // gridSelectMenu.DataSource = null;
            
        }

        private void SELLECT_MENNU_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan);
                List<ChiTietHoaDon> chiTietHoaDo = bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon);



                if (bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon).Count == 0)
                {

                    bus_hoaDon.xoaHoaDon(hoadon.MaHoaDon);




                }
            }
            catch (Exception)
            {

            }
          
            hinhBan5 form = new hinhBan5();
            form.Show();
        }
        public double tongTien()
        {
            double tongTien = 0;
            try
            {

                

                for (int i = 0; i <= listhienthihoadon.Count - 1; i++)
                {
                    tongTien = tongTien + listhienthihoadon[i].thanhTien;

                    txt_tongTien.Text = tongTien.ToString();

                }
            }
            catch (Exception)
            {
                
            }

          
            return tongTien;


        }



        public void capNhatSoLuongTonTrongKho()
        {
        
            int soluongTrongHoaDon = 0;

            int soLuongCanDungThanhPham = 0;

            int tongSoLuong = 0;


            HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan);
            List<ChiTietHoaDon> listChiTietHoaDon = bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon);

            List<ChiTietSanPham> listchitietsanpham = new List<ChiTietSanPham>();
            for(int i=0;i<=listChiTietHoaDon.Count - 1; i++)
            {
                listchitietsanpham = bus_chiTietSanPham.layListChiTietSanPhamTheoMaSanPham(listChiTietHoaDon[i].MaSanPham);
                soluongTrongHoaDon = listChiTietHoaDon[i].SoLuong;
                for (int j=0;j<=listchitietsanpham.Count - 1; j++)
                {
                 
                    String maNguyenLieu = listchitietsanpham[j].MaNguyenLieu;
                    soLuongCanDungThanhPham = Convert.ToInt32 (listchitietsanpham[j].SoLuongDung);
                    tongSoLuong = soluongTrongHoaDon * soLuongCanDungThanhPham;
                    if (bus_kho.kiemTraSoLuongTon(maNguyenLieu, tongSoLuong) == true)
                        bus_kho.capNhatSoLuongTonKho(maNguyenLieu, tongSoLuong);
                  

                }
                


                
            }
        }
        
        private void bt_back_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoadon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan);
                List<ChiTietHoaDon> chiTietHoaDo = bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon);
         
               
               
                if (bus_hoaDon.layChiTietHoaDon(hoadon.MaHoaDon).Count == 0)
                {
   
                    bus_hoaDon.xoaHoaDon(hoadon.MaHoaDon);
                  
                        
                    
                    
                }
            }
            catch (Exception)
            {

            }
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = false;
            this.Close();

        }

        public bool kiemTraNguyenLieuTonKho(String maSanPham, int soLuong)
        {
            //chua cap nhat duoc soluong san phamchon
            List<ChiTietSanPham> listChiTietSanPham = bus_chiTietSanPham.layListChiTietSanPhamTheoMaSanPham(maSanPham);
            int soChiTietSanPham = listChiTietSanPham.Count;
            for(int i=0;i<=soChiTietSanPham - 1; i++)
            {
                if (bus_kho.kiemTraSoLuongTon(listChiTietSanPham[i].MaNguyenLieu, Convert.ToInt32(listChiTietSanPham[i].SoLuongDung*soLuong)) == true)
                    return true;
                else
                {
                    MessageBox.Show("Không Đủ Nguyên Liệu" + listChiTietSanPham[i].MaNguyenLieu.ToString());
                    return false;
                }
                    
            }

            return false;

        }

        int dem = 0;
     
        private void hinhSanPham1_Click_1(object sender, EventArgs e)
        {

            dem++;
       

            try
            {
                               
                String maSanPham = currentList[0].MaSanPham;
                String maHoaDon = bus_hoaDon.layHoaDonTheoMaBan(maCuaBan).MaHoaDon;
                String maChiTietHoaDon = bus_chiTietHoaDon.taoMa();

                if (kiemTraNguyenLieuTonKho(maSanPham, dem)==true)
                {
                    ChiTietHoaDon chitiet = new ChiTietHoaDon(maChiTietHoaDon, maHoaDon, maSanPham, 1);
                    bus_chiTietHoaDon.themChiTietHoaDon(chitiet);


                    if (tongTien() != 0)
                        btn_thanhToan.Visible = true;


                    hienThiBan(maCuaBan);
                    tongTien();
                }
                


            }
            catch (Exception)
            {

            }
        }

        private void panelHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
