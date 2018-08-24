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
    public partial class FormDatMon : MetroForm
    {
        #region DAL&BUS
        BUS_Ban bus_Ban = new BUS_Ban();
        DAL_Ban dal_Ban = new DAL_Ban();

        BUS_SanPham bus_SanPham = new BUS_SanPham();
        DAL_SanPham dal_SanPham = new DAL_SanPham();

        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        DAL_ChiTietHoaDon dal_ChiTietHoaDon = new DAL_ChiTietHoaDon();

        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();
        #endregion
        List<Ban> lstBan = new List<Ban>();
        List<String> lstMaBan = new List<String>();
        List<SanPham> dsSanPhamHienTai = new List<SanPham>();
        List<SanPham> dsSanPhamChon = new List<SanPham>();
        List<ChiTietHoaDon> dsChiTietHoaDon = new List<ChiTietHoaDon>();

        String maBanDangChon = "";
        String trangThaiBanDangChon = "";
        String maNV = "";

        int soDongLoad = 14;
        
        DataTable dataChon = new DataTable();
        HoaDon hoaDon= new HoaDon();

        Ban banDangChon = new Ban();
        public FormDatMon()
        {
            InitializeComponent();
        }
        public FormDatMon(String maBan, String trangThai, String maNV)
        {
            InitializeComponent();
            this.maBanDangChon = maBan;
            this.trangThaiBanDangChon = trangThai;
            this.maNV = maNV;
            
        }

        public void capNhatHoaDonTheoMaBan()
        {

        }
        public void chuyenTrangThaiNutThanhToan(String trangThaiBan)
        {
            if(trangThaiBan == "Free")
            {
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnThanhToan.Enabled = true;
                
            }
        }
        public void customListViewSanPham()
        {
            lstViewSanPham.Items.Clear();
            lstViewSanPham.View = View.Details;
            lstViewSanPham.FullRowSelect = true;
            lstViewSanPham.GridLines = true;


            
            lstViewSanPham.Columns[0].Width = 250;
            lstViewSanPham.Columns[1].Width = 100;
            lstViewSanPham.Columns[2].Width = 100;
            //lstViewSanPham.Columns[0].Width = 0;



            lstViewSanPham.Columns[0].TextAlign = HorizontalAlignment.Right;
            lstViewSanPham.Columns[1].TextAlign = HorizontalAlignment.Center;
            lstViewSanPham.Columns[2].TextAlign = HorizontalAlignment.Center;
            
        }
        public void loadDataListViewSanPham()
        {
            for (int i = 0; i < dsSanPhamHienTai.Count; i++)
            {
                ListViewItem item = new ListViewItem(dsSanPhamHienTai[i].TenSanPham);
                //item.SubItems.Add(dsSanPhamHienTai[i].TenSanPham);
                item.SubItems.Add(dsSanPhamHienTai[i].LoaiSanPham);
                item.SubItems.Add(dsSanPhamHienTai[i].GiaSanPham.ToString());
                item.SubItems.Add(dsSanPhamHienTai[i].MaSanPham);
                lstViewSanPham.Items.Add(item);

            }
        }
        public void capNhatDataTableListChon()
        {
            dataChon.Clear();
            dataChon = taoDatatableChoListChon();
        }
        public DataTable taoDatatableChoListChon()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MaChiTietHoaDon");
            dt.Columns.Add("MaHoaDon");
            dt.Columns.Add("stt");
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenSanPham");
            //
            dt.Columns.Add("tang");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("giam");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("Xoa");
            foreach (var item in dsChiTietHoaDon)
            {
                var row = dt.NewRow();
                
                row["MaChiTietHoaDon"] = item.MaChiTietHoaDon;
                row["MaHoaDon"] = item.MaHoaDon;
                row["stt"] = dsChiTietHoaDon.IndexOf(item) + 1;
                row["MaSanPham"] = item.MaSanPham;
                row["TenSanPham"] = bus_SanPham.layTenSPTheoMaSP(item.MaSanPham);
                row["tang"] = "+";
                row["SoLuong"] = item.SoLuong;
                row["giam"] = "-";
                row["ThanhTien"] = item.ThanhTien;
                row["xoa"] ="x";
                dt.Rows.Add(row);
            }
            
            return dt;
        }
        public void layDSCTHDMoiSauKhiThayDoi()
        {
            dsChiTietHoaDon = bus_ChiTietHoaDon.layDSChiTietHoaDonTheoMaHoaDon(hoaDon.MaHoaDon);
        }
        public void customGridDanhSachMonDaChon()
        {
          
            gridListMonDaChon.Columns[0].Visible = false;  //MaCTHD
            gridListMonDaChon.Columns[1].Visible = false;  //MaHD
            gridListMonDaChon.Columns[2].HeaderText = "STT";
            gridListMonDaChon.Columns[3].HeaderText = "Mã món"; //Ma mon
            gridListMonDaChon.Columns[4].HeaderText = "Tên món";
            gridListMonDaChon.Columns[5].HeaderText = "";
            gridListMonDaChon.Columns[6].HeaderText = "Số lượng";
            gridListMonDaChon.Columns[7].HeaderText = "";
            gridListMonDaChon.Columns[8].HeaderText = "Thành tiền";
            gridListMonDaChon.Columns[9].HeaderText = "";



            gridListMonDaChon.Columns[5].Width = 20;
            gridListMonDaChon.Columns[7].Width = 20;
            gridListMonDaChon.Columns[9].Width = 20;

            gridListMonDaChon.Columns[2].Width = 50;
            gridListMonDaChon.Columns[3].Width = 80;
            gridListMonDaChon.Columns[4].Width = 250;
            gridListMonDaChon.Columns[6].Width = 60;
            gridListMonDaChon.Columns[8].Width = 180;

            gridListMonDaChon.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gridListMonDaChon.ScrollBars = ScrollBars.None;
            
        }
        private void FormDatMon_Load(object sender, EventArgs e)
        {

            reLoadForm();
        }
        public void reLoadForm()
        {
            lblMaBanDangPhucVu.Text = "Bàn " + maBanDangChon;
            String temp = maBanDangChon;
            banDangChon = bus_Ban.layBanTheoMaBan(maBanDangChon);
            chuyenTrangThaiNutThanhToan(trangThaiBanDangChon);
            if (banDangChon.TrangThai == "Free")
            {
                HoaDon hoaDonTemp = new HoaDon(bus_HoaDon.taoMaHDMoi(), DateTime.Now, 0, maNV, maBanDangChon, "Chưa thanh toán");
                hoaDon = hoaDonTemp;
                bus_HoaDon.themHoaDon(hoaDon);
                banDangChon.TrangThai = "Busy";
                bus_Ban.capNhatTrangThai(banDangChon);
            }
            else
            {
                hoaDon = bus_HoaDon.layHDTheoMaBanVaTrangThaiBusy(maBanDangChon);
                dsChiTietHoaDon = bus_ChiTietHoaDon.layDSChiTietHoaDonTheoMaHoaDon(hoaDon.MaHoaDon);
            }
            
            customListViewSanPham();
            phanTrangSanPham();
            processGridDSDaChon();
            banDangChon = bus_Ban.layBanTheoMaBan(maBanDangChon);
            txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
        }
        public void processGridDSDaChon()
        {
            dataChon = taoDatatableChoListChon();
            gridListMonDaChon.DataSource = dataChon;
            customGridDanhSachMonDaChon();
        }

        public void phanTrangSanPham()
        {
            int tongSoTrang = bus_SanPham.demTongSanPham() % soDongLoad;
            if (tongSoTrang != 0)
            {
                tongSoTrang = bus_SanPham.demTongSanPham() / soDongLoad + 1;
            }
            else tongSoTrang = bus_SanPham.demTongSanPham() / soDongLoad;
            lblHienThiSoTrang.Text = "/" + tongSoTrang;
            List<SanPham> lstSanPham = new List<SanPham>();
            if (bus_SanPham.demTongSanPham() >= soDongLoad)
            {
                
                lstSanPham = bus_SanPham.layDanhSachSanPham(((int)soTrangHienTai.Value - 1) * soDongLoad, soDongLoad);
                soTrangHienTai.Enabled = true;

            }
            else
            {
                lstSanPham= bus_SanPham.layDSSanPham();
                soTrangHienTai.Enabled = false;
            }

            soTrangHienTai.Maximum = tongSoTrang;
            soTrangHienTai.Minimum = 1;
            lblHienThiSoTrang.Text = tongSoTrang.ToString();

            dsSanPhamHienTai = lstSanPham;
            customListViewSanPham();
            loadDataListViewSanPham();
            
        }

        private void listBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            maBanDangChon = listBan.SelectedItem.ToString();
            lblMaBanDangPhucVu.Text = "Bàn " + maBanDangChon;
            dsChiTietHoaDon.Clear();
            reLoadForm();
        }

        private void soTrangHienTai_ValueChanged(object sender, EventArgs e)
        {
            if (soTrangHienTai.Value >= soTrangHienTai.Minimum)
            {
                phanTrangSanPham();
            }
        }

        
        private void lstViewSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool daChon = false;
            ListView lsv = sender as ListView;
            //Truong hop ban moi chua phuc vu == tao hoa don và chi tiết hoá đơn mới
            if (this.trangThaiBanDangChon == "Free")
            {
                //Tiến hành lấy giá trị mỗi dòng trên listview để add vào gridview gridListMonDaChon
                if (lsv.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lsv.SelectedItems)
                    {
                        SanPham sanPham = new SanPham(item.SubItems[3].Text, item.Text, item.SubItems[1].Text, "", float.Parse(item.SubItems[2].Text));
                        float giaSanPham = sanPham.getGiaSanPham();
                        foreach (ChiTietHoaDon cthd in dsChiTietHoaDon)
                        {
                            //Truong hop chon lai sp da chon
                            if (cthd.MaSanPham == sanPham.MaSanPham)
                            {
                                daChon = true;
                            }

                        }
                        if (daChon)
                        {
                            //MessageBox.Show("SP nay da chon roi");
                            DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Món này đã chọn rồi. Bạn có muốn tăng số lượng của món này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            //Đồng ý thay đổi
                            if (ketQuaChon == DialogResult.OK)
                            {
                                foreach(ChiTietHoaDon cthd in dsChiTietHoaDon)
                                {
                                    if(cthd.MaSanPham == sanPham.MaSanPham)
                                    {
                                        cthd.SoLuong = cthd.SoLuong + 1;
                                        cthd.ThanhTien = sanPham.GiaSanPham * cthd.SoLuong;
                                        bus_ChiTietHoaDon.chinhSuaSoLuongChiTietHoaDon(cthd);
                                        layDSCTHDMoiSauKhiThayDoi();
                                        capNhatHoaDonDangXuLy();
                                        btnThanhToan.Enabled = true;
                                        
                                    }
                                }
                            }
                            else
                            {

                            }
                        }
                        else //Trường hợp sản phẩm chưa được chọn sẽ được add vào dsChiTietHoaDon, gridListMonDaChon chính là danh sách các chi tiết hoá đon dc tạo từ dsChiTietHoaDon
                        {
                            //dsSanPhamChon.Add(sanPham);
                            //float giaSanPham = sanPham.getGiaSanPham();
                            ChiTietHoaDon cthd = new ChiTietHoaDon(bus_ChiTietHoaDon.taoMaCTHDMoi()+dsChiTietHoaDon.Count.ToString(),hoaDon.MaHoaDon,sanPham.MaSanPham,1,giaSanPham);
                            bus_ChiTietHoaDon.themCTHoaDon(cthd);
                            layDSCTHDMoiSauKhiThayDoi();
                            capNhatHoaDonDangXuLy();
                            btnThanhToan.Enabled = true;
                        }
                        //MessageBox.Show(sanPham.MaSanPham +" "+sanPham.TenSanPham+" "+sanPham.LoaiSanPham+" "+sanPham.DuongDan+" "+sanPham.GiaSanPham);
                        //MessageBox.Show(item.SubItems[3].Text);
                    }

                }

            }
            else //Truong hop load ban dang phuc vu
            {
                if (lsv.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lsv.SelectedItems)
                    {
                        SanPham sanPham = new SanPham(item.SubItems[3].Text, item.Text, item.SubItems[1].Text, "", float.Parse(item.SubItems[2].Text));
                        float giaSanPham = sanPham.getGiaSanPham();
                        foreach (ChiTietHoaDon cthd in dsChiTietHoaDon)
                        {
                            //Truong hop chon lai sp da chon
                            if (cthd.MaSanPham == sanPham.MaSanPham)
                            {
                                daChon = true;
                            }

                        }
                        if (daChon)
                        {
                            //MessageBox.Show("SP nay da chon roi");
                            DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Món này đã chọn rồi. Bạn có muốn tăng số lượng của món này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            //Đồng ý thay đổi
                            if (ketQuaChon == DialogResult.OK)
                            {
                                foreach (ChiTietHoaDon cthd in dsChiTietHoaDon)
                                {
                                    if (cthd.MaSanPham == sanPham.MaSanPham)
                                    {
                                        cthd.SoLuong = cthd.SoLuong + 1;
                                        cthd.ThanhTien = sanPham.GiaSanPham * cthd.SoLuong;
                                        bus_ChiTietHoaDon.chinhSuaSoLuongChiTietHoaDon(cthd);
                                        layDSCTHDMoiSauKhiThayDoi();
                                        capNhatHoaDonDangXuLy();
                                    }
                                }
                            }
                            else
                            {

                            }
                        }
                        else //Trường hợp sản phẩm chưa được chọn sẽ được add vào dsChiTietHoaDon, gridListMonDaChon chính là danh sách các chi tiết hoá đon dc tạo từ dsChiTietHoaDon
                        {
                            //dsSanPhamChon.Add(sanPham);
                            //float giaSanPham = sanPham.getGiaSanPham();
                            ChiTietHoaDon cthd = new ChiTietHoaDon(bus_ChiTietHoaDon.taoMaCTHDMoi() + dsChiTietHoaDon.Count.ToString(), hoaDon.MaHoaDon, sanPham.MaSanPham, 1, giaSanPham);
                            bus_ChiTietHoaDon.themCTHoaDon(cthd);
                            layDSCTHDMoiSauKhiThayDoi();
                            capNhatHoaDonDangXuLy();


                        }
                        //MessageBox.Show(sanPham.MaSanPham +" "+sanPham.TenSanPham+" "+sanPham.LoaiSanPham+" "+sanPham.DuongDan+" "+sanPham.GiaSanPham);
                        //MessageBox.Show(item.SubItems[3].Text);
                    }

                }
            }
            processGridDSDaChon();
            txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
        }

        
        
        public int layViTriHienTaiCuaMonTrongDSCTHD(List<ChiTietHoaDon> lstChiTietHoaDon, String maMon)
        {
            int viTri = 0;
            foreach(ChiTietHoaDon cthd in lstChiTietHoaDon)
            {
                if(cthd.MaSanPham == maMon)
                {
                    viTri = lstChiTietHoaDon.IndexOf(cthd);
                }
            }
            return viTri;
        }
        //Xu ly tang giam xoa mon tren gridListMonDaChon
        private void gridListMonDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                
                String maMonDangChinhSua = "";
                maMonDangChinhSua = gridListMonDaChon.CurrentRow.Cells[3].Value.ToString();
                int soLuong = int.Parse(gridListMonDaChon.CurrentRow.Cells[6].Value.ToString());
                int viTriCapNhatSoLuong = 0;
                float giaSanPham = bus_SanPham.layGiaSPTheoMaSP(maMonDangChinhSua);
                if (e.ColumnIndex == 5)
                {
                   
                    soLuong = soLuong + 1;
                    gridListMonDaChon.CurrentRow.Cells[6].Value = soLuong.ToString();
                    gridListMonDaChon.CurrentRow.Cells[8].Value = soLuong * giaSanPham;
                    viTriCapNhatSoLuong = layViTriHienTaiCuaMonTrongDSCTHD(dsChiTietHoaDon, maMonDangChinhSua);
                    dsChiTietHoaDon[viTriCapNhatSoLuong].SoLuong = soLuong;
                    dsChiTietHoaDon[viTriCapNhatSoLuong].ThanhTien = soLuong * giaSanPham;
                    processGridDSDaChon();
                    bus_ChiTietHoaDon.chinhSuaSoLuongChiTietHoaDon(dsChiTietHoaDon[viTriCapNhatSoLuong]);
                    layDSCTHDMoiSauKhiThayDoi();
                    capNhatHoaDonDangXuLy();
                    //MessageBox.Show(txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString());
                }
                if(e.ColumnIndex == 7)
                {
                    soLuong = soLuong - 1;
                    if(soLuong >= 1)
                    {
                        gridListMonDaChon.CurrentRow.Cells[6].Value = soLuong.ToString();
                        gridListMonDaChon.CurrentRow.Cells[8].Value = soLuong * bus_SanPham.layGiaSPTheoMaSP(maMonDangChinhSua);
                        viTriCapNhatSoLuong = layViTriHienTaiCuaMonTrongDSCTHD(dsChiTietHoaDon, maMonDangChinhSua);
                        dsChiTietHoaDon[viTriCapNhatSoLuong].SoLuong = soLuong;
                        dsChiTietHoaDon[viTriCapNhatSoLuong].ThanhTien = soLuong * giaSanPham;
                        processGridDSDaChon();
                        txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
                        bus_ChiTietHoaDon.chinhSuaSoLuongChiTietHoaDon(dsChiTietHoaDon[viTriCapNhatSoLuong]);
                        layDSCTHDMoiSauKhiThayDoi();
                        capNhatHoaDonDangXuLy();
                    }
                    else
                    {
                        DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Bạn muốn huỷ món này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(ketQuaChon == DialogResult.OK)
                        {
                            int viTriXoa = 0;
                            string maMonDangChon = gridListMonDaChon.CurrentRow.Cells[3].Value.ToString();
                            foreach (ChiTietHoaDon cthd in dsChiTietHoaDon)
                            {
                                if (cthd.MaSanPham == maMonDangChon)
                                {
                                    viTriXoa = dsChiTietHoaDon.IndexOf(cthd);
                                }

                            }
                            bus_ChiTietHoaDon.xoaCTHD(dsChiTietHoaDon[viTriXoa]);
                            layDSCTHDMoiSauKhiThayDoi();

                            txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
                            capNhatHoaDonDangXuLy();
                            processGridDSDaChon();
                        }
                    }
                    
                }
                if(e.ColumnIndex == 9)
                {
                    DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Bạn muốn huỷ món này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (ketQuaChon == DialogResult.OK)
                    {
                        int viTriXoa = 0;
                        string maMonDangChon = gridListMonDaChon.CurrentRow.Cells[3].Value.ToString();
                        foreach (ChiTietHoaDon cthd in dsChiTietHoaDon)
                        {
                            if (cthd.MaSanPham == maMonDangChon)
                            {
                                viTriXoa = dsChiTietHoaDon.IndexOf(cthd);
                            }

                        }
                        bus_ChiTietHoaDon.xoaCTHD(dsChiTietHoaDon[viTriXoa]);
                        layDSCTHDMoiSauKhiThayDoi();
                        txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
                        capNhatHoaDonDangXuLy();
                        processGridDSDaChon();
                    }

                }
                txtTongTien.Text = tongTienHoaDon(dsChiTietHoaDon).ToString();
                capNhatHoaDonDangXuLy();
                //processGridDSDaChon();
            }
        }

        public float tongTienHoaDon(List<ChiTietHoaDon> lstChiTietHoaDon)
        {
            float tongTien = 0;
            foreach(ChiTietHoaDon cthd in lstChiTietHoaDon)
            {
                tongTien += float.Parse(cthd.ThanhTien.ToString());
            }
            return tongTien;
        }
        int daThem = 0;
        public void capNhatHoaDonDangXuLy()
        {
            hoaDon.TongTien = tongTienHoaDon(dsChiTietHoaDon);
            bus_HoaDon.capNhatTongTienHoaDonTheoMaHoaDon(hoaDon.MaHoaDon, float.Parse(hoaDon.TongTien.ToString()));
            banDangChon.TrangThai = "Busy";
            bus_Ban.capNhatTrangThai(banDangChon);
        }
        

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan formThanhToan = new FormThanhToan(float.Parse(hoaDon.TongTien.ToString()),banDangChon.MaBan,hoaDon.MaHoaDon);
            formThanhToan.Show();
        }

        private void FormDatMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       

        private void FormDatMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(daThem == 0)
            {

            }
            DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Bạn sẽ được chuyển về giao diện quản lý bàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(ketQuaChon == DialogResult.OK)
            {
                FormQuanLyBan form = new FormQuanLyBan(maNV);
                form.Show();
                
            }
            else
            {

            }
        }
    }
}
