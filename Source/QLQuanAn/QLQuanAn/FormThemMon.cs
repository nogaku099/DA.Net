using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using MetroFramework;
using MetroFramework.Forms;
namespace QLQuanAn
{
    public partial class FormThemMon : MetroForm
    {
        #region BUS&DAL
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        DAL_SanPham dal_SanPham = new DAL_SanPham();
        #endregion
        public FormThemMon()
        {
            InitializeComponent();
        }

        private void FormThemMon_Load(object sender, EventArgs e)
        {
            lblMaMonRandom.Text = bus_SanPham.taoMaSPMoi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtTenMon.Text = "";
            txtLoaiMon.Text = "";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(txtTenMon.Text=="" || txtTenMon.Text==null || txtLoaiMon.Text=="" || txtLoaiMon.Text==null
                || txtGia.Text=="" || txtGia.Text == null)
            {
                SanPham sanPham = new SanPham(lblMaMonRandom.Text, txtTenMon.Text, txtLoaiMon.Text, "", float.Parse(txtGia.Text));
                DialogResult ketQuaChon = MetroMessageBox.Show(Owner, "Bạn muốn thêm món này vào danh sách ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(ketQuaChon == DialogResult.OK)
                {
                    bus_SanPham.themSanPham(sanPham);
                    MetroMessageBox.Show(Owner, "Đã thêm món thành công bạn sẽ được chuyển về giao diện quản lý món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dongFormQuanLyMon();
                    FormQuanLyMon form = new FormQuanLyMon();
                    form.Show();
                }
               
            }
            
        }

        public void dongFormQuanLyMon()
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "FormQuanLyMon")
                {
                    Application.OpenForms[index].Close();
                }
            }
        }

    }
}
