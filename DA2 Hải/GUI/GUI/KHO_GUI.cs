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

namespace GUI
{
    public partial class KHO_GUI : MetroForm
    {
        BUS_KHO bus_kho = new BUS_KHO();
        public KHO_GUI()
        {
            InitializeComponent();
        }

        public void LoadKho()
        {
            grid_Kho.DataSource = bus_kho.layKho();
            grid_Kho.Columns[0].HeaderText = "ID";
            grid_Kho.Columns[1].HeaderText = "Mã Nguyên Liệu";
            grid_Kho.Columns[2].HeaderText = "Số Lượng Tồn";
            grid_Kho.Columns[0].Width = 300;
            grid_Kho.Columns[1].Width = 300;
            grid_Kho.Columns[2].Width = 300;
        }

        private void KHO_Load(object sender, EventArgs e)
        {
            LoadKho();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
