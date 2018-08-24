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
namespace QLQuanAn
{
    public partial class FormQuanLyBan : MetroForm
    {
        #region BUS&DAL
        BUS_Ban bus_Ban = new BUS_Ban();
        DAL_Ban dal_Ban = new DAL_Ban();
        List<Ban> dsBanHienTai = new List<Ban>();
        #endregion
        int soDongLoad = 6;
        List<Label> lstLabel = new List<Label>();
        List<Panel> lstPanel = new List<Panel>();
        String maNV = "";
        public FormQuanLyBan()
        {
            InitializeComponent();
        }

        public FormQuanLyBan(String maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void FormQuanLyBan_Load(object sender, EventArgs e)
        {
            phanTrangBan();


        }
        public void hienThiBanLenGiaoDien()
        {
            
            lstLabel.Add(txtMaBan1);
            lstLabel.Add(txtMaBan2);
            lstLabel.Add(txtMaBan3);
            lstLabel.Add(txtMaBan4);
            lstLabel.Add(txtMaBan5);
            lstLabel.Add(txtMaBan6);

            lstPanel.Add(ban1);
            lstPanel.Add(ban2);
            lstPanel.Add(ban3);
            lstPanel.Add(ban4);
            lstPanel.Add(ban5);
            lstPanel.Add(ban6);
            //xu ly ma ban
            if (dsBanHienTai.Count>=6)
            {
                for (int i = 0; i < 6; i++)
                {
                    lstLabel[i].Text = dsBanHienTai[i].MaBan;
                    //this.Controls.Add(lstLabel[i]);// them controls vaof Form1
                }
                
                //txtMaBan1.BackColor = Color.White;
                //Lay tinh trang tung ban hien tai
                //dsBanHienTai[i].TrangThai
                for(int i = 0; i < 6; i++)
                {
                    if(dsBanHienTai[i].TrangThai == "Free")
                    {
                        lstPanel[i].BackColor = Color.Green;
                    }
                    else
                    {
                        lstPanel[i].BackColor = Color.Red;
                    }
                }
                
            }
            else // Truong hop sang trang ko du 6 dong
            {
                for (int i = 0; i < dsBanHienTai.Count; i++)
                {
                    lstLabel[i].Text = dsBanHienTai[i].MaBan;
                    if (dsBanHienTai[i].TrangThai == "Free")
                    {
                        lstPanel[i].BackColor = Color.Green;
                    }
                    else
                    {
                        lstPanel[i].BackColor = Color.Red;
                    }
                    //this.Controls.Add(lstLabel[i]);// them controls vaof Form1
                } 
                //int soDongConThieu = 6 - dsBanHienTai.Count;
                
                for (int i = dsBanHienTai.Count + 1; i <= 6; i++)
                {
                    lstLabel[i-1].Text = "";
                    lstPanel[i-1].Enabled = false;
                    lstPanel[i - 1].BackColor = Color.Black;
                }



            }
            //xu ly trang thai
            

        }
        public void phanTrangBan()
        {
            int tongSoTrang = bus_Ban.demTongBan() % soDongLoad;
            if (tongSoTrang != 0)
            {
                tongSoTrang = bus_Ban.demTongBan() / soDongLoad + 1;
            }
            else tongSoTrang = bus_Ban.demTongBan() / soDongLoad;
            lblHienThiSoTrang.Text = "/" + tongSoTrang;
            List<Ban> lstBan = new List<Ban>();
            if (bus_Ban.demTongBan() >= soDongLoad)
            {
                //lstNhanVien = bus_NhanVien.layDanhSachNhanVien(((int)numericUpDownNhanVien.Value - 1) * soDongLoad, soDongLoad);
                lstBan = bus_Ban.layDanhSachBan(((int)numericUpDownBan.Value - 1) * soDongLoad, soDongLoad); 
                numericUpDownBan.Enabled = true;

            }
            else
            {
                lstBan = bus_Ban.layDSBan();
                numericUpDownBan.Enabled = false;
            }

            numericUpDownBan.Maximum = tongSoTrang;
            numericUpDownBan.Minimum = 1;
            //gridNhanVien.DataSource = lstNhanVien;
            lblHienThiSoTrang.Text = tongSoTrang.ToString();

            dsBanHienTai = lstBan;
            
            hienThiBanLenGiaoDien();
        }

        private void numericUpDownBan_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownBan.Value >= numericUpDownBan.Minimum)
            {
                phanTrangBan();
            }
        }

        
        private void ban1_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[0].MaBan, dsBanHienTai[0].TrangThai,maNV);
            form.Show();
            this.Hide();
        }

        private void ban2_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[1].MaBan, dsBanHienTai[1].TrangThai, maNV);
            form.Show();
            this.Hide();
        }

        private void ban3_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[2].MaBan, dsBanHienTai[2].TrangThai, maNV);
            form.Show();
            this.Hide();
        }

        private void ban4_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[3].MaBan, dsBanHienTai[3].TrangThai, maNV);
            form.Show();
            this.Hide();
        }

        private void ban5_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[4].MaBan, dsBanHienTai[4].TrangThai, maNV);
            form.Show();
            this.Hide();
        }

        private void ban6_Click(object sender, EventArgs e)
        {
            FormDatMon form = new FormDatMon(dsBanHienTai[5].MaBan, dsBanHienTai[5].TrangThai, maNV);
            form.Show();
            this.Hide();
        }

        private void FormQuanLyBan_Enter(object sender, EventArgs e)
        {
            phanTrangBan();
        }
    }
}
