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
    public partial class FormThanhToan : MetroForm
    {
        float tongTien = 0;
        String maBan = "";
        String maHoaDon = "";
        #region BUS&DAL
        BUS_Ban bus_Ban = new BUS_Ban();
        DAL_Ban dal_Ban = new DAL_Ban();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();
        #endregion
        public FormThanhToan()
        {
            InitializeComponent();
        }
        public FormThanhToan(float tongTien, string maBan, string maHoaDon)
        {
            InitializeComponent();
            this.tongTien = tongTien;
            this.maBan = maBan;
            this.maHoaDon = maHoaDon;
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
            char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
            char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
            char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MetroMessageBox.Show(Owner, "Chỉ được phép nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTienKhachDua_TabStopChanged(object sender, EventArgs e)
        {
            float tienTraLai = 0;

            float tienKhachDua = float.Parse(txtTienKhachDua.Text);//float.parseFloat(txtTienKhachDua.Text);
            tienTraLai = tongTien - tienKhachDua;
            lblTienTraLai.Text = tienTraLai.ToString();
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Xác nhận thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ketQuaChon == DialogResult.OK)
            {
                List<Ban> dsBan = bus_Ban.layDSBan();
                Ban banDangThanhToan = bus_Ban.layBanTheoMaBan(maBan);
                HoaDon hoaDonDangThanhToan = bus_HoaDon.layHoaDonTheoMaHoaDon(maHoaDon);
                //Tien hanh cap nhat trang thai ban va hoa don
                hoaDonDangThanhToan.TrangThaiHoaDon = "Đã Thanh toán";
                banDangThanhToan.TrangThai = "Free";
                bus_Ban.capNhatTrangThai(banDangThanhToan);
                bus_HoaDon.capNhatTrangThaiHoaDon(hoaDonDangThanhToan);

                DialogResult ketQuaChonOK = MetroMessageBox.Show(Owner, "Đã thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ketQuaChonOK == DialogResult.OK)
                {
                    this.Dispose();
                    FormQuanLyBan form = new FormQuanLyBan();
                    form.Show();
                }
                else
                {

                }
            }
            else
            {

            }
        }
    }
}
