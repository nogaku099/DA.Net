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
    public partial class NHAPKHO : MetroForm
    {

        BUS_NHACUNGCAP bus_nhaCungCap = new BUS_NHACUNGCAP();
        BUS_NGUYENLIEU bus_nguyenLieu = new BUS_NGUYENLIEU();
        BUS_CHITIETPHIEUNHAP bus_chiTietPhieuNhap = new BUS_CHITIETPHIEUNHAP();
        BUS_PHIEUNHAP bus_phieuNhap = new BUS_PHIEUNHAP();
        BUS_KHO bus_kho = new BUS_KHO();
        String maNhanVien = "";
        List<KHO> listNhapKho = new List<KHO>();
       
        public NHAPKHO()
        {
            InitializeComponent();
        }

        public void loadForm()
        {
            gridChiTietPhieuNhap.DataSource = bus_chiTietPhieuNhap.LayChiTietPhieuNhap();
            gridChiTietPhieuNhap.Columns[0].HeaderText = "Mã ChiTietPhieuNhap";
            gridChiTietPhieuNhap.Columns[1].HeaderText = "Mã Nguyên Liệu";
            gridChiTietPhieuNhap.Columns[2].HeaderText = "Số Lượng";
            gridChiTietPhieuNhap.Columns[3].HeaderText = "Nhà Cung Cấp";
            gridChiTietPhieuNhap.Columns[4].HeaderText = "Mã Phiếu Nhập";
            gridChiTietPhieuNhap.Columns[0].Width = 200;
            gridChiTietPhieuNhap.Columns[1].Width = 200;
            gridChiTietPhieuNhap.Columns[2].Width = 200;
            gridChiTietPhieuNhap.Columns[3].Width = 200;
            gridChiTietPhieuNhap.Columns[4].Width = 200;




        }


        private void NHAPKHO_Load(object sender, EventArgs e)
        {
            loadForm();
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
            listNhaCungCap = bus_nhaCungCap.LayNhaCungCap();
            listNguyenLieu = bus_nguyenLieu.layNguyenLieu();
            for(int i=0;i<=listNhaCungCap.Count - 1; i++)
            {
                box_nhaCungCap.Items.Add(listNhaCungCap[i].TenNhaCungCap);

            }
            for (int i = 0; i <= listNguyenLieu.Count - 1; i++)
            {
                box_nguyenLieu.Items.Add(listNguyenLieu[i].TenNguyenLieu);

            }
           
            gridChiTietPhieuNhap.DataSource = bus_chiTietPhieuNhap.LayChiTietPhieuNhap();
         

        }
        
        int count = 0;
        String maPhieuNhapct = "";
        private void btn_them_Click(object sender, EventArgs e)
        {
            MAIN mainForm = new MAIN();
            maNhanVien = mainForm.getMaNhanVien();
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
            listNhaCungCap = bus_nhaCungCap.LayNhaCungCap();
            listNguyenLieu = bus_nguyenLieu.layNguyenLieu();
            
            //TAO PHIEU NHAP
            
            if( count == 0)
            {
                
                String maPhieuNhap = bus_phieuNhap.taoMa();
                DateTime ngayLap = DateTime.Now.Date;
                float tongTien = 0;
                
                PhieuNhap phieunhap = new PhieuNhap(maPhieuNhap, ngayLap, tongTien, maNhanVien);
                bus_phieuNhap.Them(phieunhap);
                MessageBox.Show(ngayLap.ToString());


                count++;
                maPhieuNhapct = maPhieuNhap;
                String maChiTietPhieuNhap = bus_chiTietPhieuNhap.taoMa();
                String maNguyenLieu = listNguyenLieu[box_nguyenLieu.SelectedIndex].MaNguyenLieu;
                int soLuong = Int32.Parse(txt_soLuong.Text.ToString());
                String loaiDonVi = box_loaiDonVi.SelectedItem.ToString();
            
                String id = bus_kho.taoMa();
                KHO kho = new KHO(id,maNguyenLieu, soLuong,loaiDonVi);
                listNhapKho.Add(kho);
                String maNhaCungCap = listNhaCungCap[box_nhaCungCap.SelectedIndex].MaNhaCungCap;

                ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap(maChiTietPhieuNhap, maNguyenLieu, soLuong, maNhaCungCap, maPhieuNhapct);
                bus_chiTietPhieuNhap.Them(chiTiet);


            }
            else
            {

                String id = bus_kho.taoMa();
                String maChiTietPhieuNhap = bus_chiTietPhieuNhap.taoMa();
                String maNguyenLieu = listNguyenLieu[box_nguyenLieu.SelectedIndex].MaNguyenLieu;
                int soLuong = Int32.Parse(txt_soLuong.Text.ToString());
                String maNhaCungCap = listNhaCungCap[box_nhaCungCap.SelectedIndex].MaNhaCungCap;
                String loaiDonVi = box_loaiDonVi.SelectedItem.ToString();
                KHO kho = new KHO(id,maNguyenLieu, soLuong,loaiDonVi);
                listNhapKho.Add(kho);
                ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap(maChiTietPhieuNhap, maNguyenLieu, soLuong, maNhaCungCap,maPhieuNhapct);
                bus_chiTietPhieuNhap.Them(chiTiet);

            }


            gridChiTietPhieuNhap.DataSource = bus_chiTietPhieuNhap.LayChiTietPhieuNhap();





        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        public void nhapKho(List<NguyenLieu> list)
        {

           



        }


        private void btn_nhapKho_Click(object sender, EventArgs e)
        {
            // cap nhat lai tong tien phieu nhap
            // xuat phieu nhap

            // cap nhat lai nguyen lieu

            for(int i=0;i<=listNhapKho.Count - 1; i++)
            {
              
                bus_kho.them(listNhapKho[i]);
                
            }




        }
    }
}
