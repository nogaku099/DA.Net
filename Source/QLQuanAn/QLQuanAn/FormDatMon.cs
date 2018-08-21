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
        #endregion
        List<Ban> lstBan = new List<Ban>();
       
        List<String> lstMaBan = new List<String>();
        String maBanDangChon = "";
        String trangThaiBanDangChon = "";
        public FormDatMon()
        {
            InitializeComponent();
        }
        public FormDatMon(String maBan, String trangThai)
        {
            InitializeComponent();
            this.maBanDangChon = maBan;
            this.trangThaiBanDangChon = trangThai;
            
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
        private void FormDatMon_Load(object sender, EventArgs e)
        {
            lblMaBanDangPhucVu.Text = "Bàn " + maBanDangChon;
            String temp = maBanDangChon;
            lstBan = bus_Ban.layDSBan();
            foreach(Ban ban in lstBan)
            {
                lstMaBan.Add(ban.MaBan);
            }
            listBan.DataSource = lstMaBan;
            
            listBan.SelectedIndex = listBan.FindString(temp);
            //MessageBox.Show(trangThaiBanDangChon);
            chuyenTrangThaiNutThanhToan(trangThaiBanDangChon);
            
            
        }

        private void listBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            maBanDangChon = listBan.SelectedItem.ToString();
            lblMaBanDangPhucVu.Text = "Bàn " + maBanDangChon;
            //MessageBox.Show(maBanDangChon);
            chuyenTrangThaiNutThanhToan(trangThaiBanDangChon);
        }
    }
}
