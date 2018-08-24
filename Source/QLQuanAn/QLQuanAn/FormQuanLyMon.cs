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
    public partial class FormQuanLyMon : MetroForm
    {
        #region BUS&DAL
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        DAL_SanPham dal_SanPham = new DAL_SanPham();
        #endregion

        List<SanPham> dsSanPham = new List<SanPham>();
        public FormQuanLyMon()
        {
            InitializeComponent();
        }

        private void FormQuanLyMon_Load(object sender, EventArgs e)
        {

        }

        public void phanTrangSanPham()
        {

        }

        public void customGridSanPham()
        {

        }
    }
}
