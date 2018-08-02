namespace GUI
{
    partial class NHAPKHO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.box_nhaCungCap = new MetroFramework.Controls.MetroComboBox();
            this.box_nguyenLieu = new MetroFramework.Controls.MetroComboBox();
            this.btn_them = new MetroFramework.Controls.MetroTile();
            this.gridChiTietPhieuNhap = new MetroFramework.Controls.MetroGrid();
            this.btn_nhapKho = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dALBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.box_loaiDonVi = new MetroFramework.Controls.MetroComboBox();
            this.txt_soLuong = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietPhieuNhap)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dALBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // box_nhaCungCap
            // 
            this.box_nhaCungCap.FormattingEnabled = true;
            this.box_nhaCungCap.ItemHeight = 23;
            this.box_nhaCungCap.Location = new System.Drawing.Point(143, 124);
            this.box_nhaCungCap.Name = "box_nhaCungCap";
            this.box_nhaCungCap.Size = new System.Drawing.Size(121, 29);
            this.box_nhaCungCap.TabIndex = 0;
            this.box_nhaCungCap.UseSelectable = true;
            // 
            // box_nguyenLieu
            // 
            this.box_nguyenLieu.FormattingEnabled = true;
            this.box_nguyenLieu.ItemHeight = 23;
            this.box_nguyenLieu.Location = new System.Drawing.Point(385, 124);
            this.box_nguyenLieu.Name = "box_nguyenLieu";
            this.box_nguyenLieu.Size = new System.Drawing.Size(121, 29);
            this.box_nguyenLieu.TabIndex = 1;
            this.box_nguyenLieu.UseSelectable = true;
            // 
            // btn_them
            // 
            this.btn_them.ActiveControl = null;
            this.btn_them.Location = new System.Drawing.Point(918, 113);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(120, 40);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseSelectable = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gridChiTietPhieuNhap
            // 
            this.gridChiTietPhieuNhap.AllowUserToResizeRows = false;
            this.gridChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridChiTietPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridChiTietPhieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridChiTietPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridChiTietPhieuNhap.EnableHeadersVisualStyles = false;
            this.gridChiTietPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridChiTietPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridChiTietPhieuNhap.Location = new System.Drawing.Point(32, 185);
            this.gridChiTietPhieuNhap.Name = "gridChiTietPhieuNhap";
            this.gridChiTietPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChiTietPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridChiTietPhieuNhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChiTietPhieuNhap.Size = new System.Drawing.Size(1143, 331);
            this.gridChiTietPhieuNhap.TabIndex = 5;
            // 
            // btn_nhapKho
            // 
            this.btn_nhapKho.ActiveControl = null;
            this.btn_nhapKho.Location = new System.Drawing.Point(871, 522);
            this.btn_nhapKho.Name = "btn_nhapKho";
            this.btn_nhapKho.Size = new System.Drawing.Size(126, 39);
            this.btn_nhapKho.TabIndex = 6;
            this.btn_nhapKho.Text = "Nhập Kho";
            this.btn_nhapKho.UseSelectable = true;
            this.btn_nhapKho.Click += new System.EventHandler(this.btn_nhapKho_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Nhà Cung Cấp";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(287, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Nguyên Liệu";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(685, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Số Lượng";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(1051, 522);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(126, 39);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Quay Lại";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1400, 58);
            this.metroPanel1.TabIndex = 85;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AllowDrop = true;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.Location = new System.Drawing.Point(498, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(192, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "QUẢN LÝ NHẬP KHO";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // dALBANBindingSource
            // 
            this.dALBANBindingSource.DataSource = typeof(DAL.DAL_BAN);
            // 
            // box_loaiDonVi
            // 
            this.box_loaiDonVi.FormattingEnabled = true;
            this.box_loaiDonVi.ItemHeight = 23;
            this.box_loaiDonVi.Items.AddRange(new object[] {
            "Gói",
            "Gram",
            "Chai"});
            this.box_loaiDonVi.Location = new System.Drawing.Point(523, 124);
            this.box_loaiDonVi.Name = "box_loaiDonVi";
            this.box_loaiDonVi.Size = new System.Drawing.Size(121, 29);
            this.box_loaiDonVi.TabIndex = 86;
            this.box_loaiDonVi.UseSelectable = true;
            // 
            // txt_soLuong
            // 
            // 
            // 
            // 
            this.txt_soLuong.CustomButton.Image = null;
            this.txt_soLuong.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txt_soLuong.CustomButton.Name = "";
            this.txt_soLuong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_soLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_soLuong.CustomButton.TabIndex = 1;
            this.txt_soLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_soLuong.CustomButton.UseSelectable = true;
            this.txt_soLuong.CustomButton.Visible = false;
            this.txt_soLuong.Lines = new string[0];
            this.txt_soLuong.Location = new System.Drawing.Point(756, 130);
            this.txt_soLuong.MaxLength = 32767;
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.PasswordChar = '\0';
            this.txt_soLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_soLuong.SelectedText = "";
            this.txt_soLuong.SelectionLength = 0;
            this.txt_soLuong.SelectionStart = 0;
            this.txt_soLuong.ShortcutsEnabled = true;
            this.txt_soLuong.Size = new System.Drawing.Size(138, 23);
            this.txt_soLuong.TabIndex = 87;
            this.txt_soLuong.UseSelectable = true;
            this.txt_soLuong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_soLuong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NHAPKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.box_loaiDonVi);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_nhapKho);
            this.Controls.Add(this.gridChiTietPhieuNhap);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.box_nguyenLieu);
            this.Controls.Add(this.box_nhaCungCap);
            this.Name = "NHAPKHO";
            this.Load += new System.EventHandler(this.NHAPKHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietPhieuNhap)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dALBANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox box_nhaCungCap;
        private MetroFramework.Controls.MetroComboBox box_nguyenLieu;
        private MetroFramework.Controls.MetroTile btn_them;
        private MetroFramework.Controls.MetroGrid gridChiTietPhieuNhap;
        private MetroFramework.Controls.MetroTile btn_nhapKho;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource dALBANBindingSource;
        private MetroFramework.Controls.MetroComboBox box_loaiDonVi;
        private MetroFramework.Controls.MetroTextBox txt_soLuong;
    }
}