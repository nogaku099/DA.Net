namespace QLQuanAn
{
    partial class FormDatMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel56 = new MetroFramework.Controls.MetroPanel();
            this.lstViewSanPham = new MetroFramework.Controls.MetroListView();
            this.colTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHienThiSoTrang = new MetroFramework.Controls.MetroLabel();
            this.txtTongTien = new MetroFramework.Controls.MetroLabel();
            this.btnThanhToan = new MetroFramework.Controls.MetroButton();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.gridListMonDaChon = new MetroFramework.Controls.MetroGrid();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.soTrangHienTai = new System.Windows.Forms.NumericUpDown();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.lblMaBanDangPhucVu = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.listBan = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel56.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListMonDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTrangHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel56
            // 
            this.metroPanel56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel56.Controls.Add(this.lstViewSanPham);
            this.metroPanel56.Controls.Add(this.lblHienThiSoTrang);
            this.metroPanel56.Controls.Add(this.txtTongTien);
            this.metroPanel56.Controls.Add(this.btnThanhToan);
            this.metroPanel56.Controls.Add(this.metroLabel40);
            this.metroPanel56.Controls.Add(this.gridListMonDaChon);
            this.metroPanel56.Controls.Add(this.metroLabel38);
            this.metroPanel56.Controls.Add(this.soTrangHienTai);
            this.metroPanel56.Controls.Add(this.btnTim);
            this.metroPanel56.Controls.Add(this.txtTimKiem);
            this.metroPanel56.Controls.Add(this.lblMaBanDangPhucVu);
            this.metroPanel56.Controls.Add(this.metroLabel36);
            this.metroPanel56.Controls.Add(this.listBan);
            this.metroPanel56.HorizontalScrollbarBarColor = true;
            this.metroPanel56.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel56.HorizontalScrollbarSize = 10;
            this.metroPanel56.Location = new System.Drawing.Point(51, 49);
            this.metroPanel56.Name = "metroPanel56";
            this.metroPanel56.Size = new System.Drawing.Size(1242, 639);
            this.metroPanel56.TabIndex = 12;
            this.metroPanel56.VerticalScrollbarBarColor = true;
            this.metroPanel56.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel56.VerticalScrollbarSize = 10;
            // 
            // lstViewSanPham
            // 
            this.lstViewSanPham.AllowSorting = true;
            this.lstViewSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenSanPham,
            this.colLoaiSanPham,
            this.colGia,
            this.colMaSanPham});
            this.lstViewSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstViewSanPham.FullRowSelect = true;
            this.lstViewSanPham.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewSanPham.Location = new System.Drawing.Point(24, 112);
            this.lstViewSanPham.Name = "lstViewSanPham";
            this.lstViewSanPham.OwnerDraw = true;
            this.lstViewSanPham.Scrollable = false;
            this.lstViewSanPham.Size = new System.Drawing.Size(453, 398);
            this.lstViewSanPham.TabIndex = 18;
            this.lstViewSanPham.UseCompatibleStateImageBehavior = false;
            this.lstViewSanPham.UseSelectable = true;
            this.lstViewSanPham.SelectedIndexChanged += new System.EventHandler(this.lstViewSanPham_SelectedIndexChanged);
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Text = "Tên món";
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.Text = "Loại món";
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.Text = "";
            this.colMaSanPham.Width = 0;
            // 
            // lblHienThiSoTrang
            // 
            this.lblHienThiSoTrang.AutoSize = true;
            this.lblHienThiSoTrang.Location = new System.Drawing.Point(298, 516);
            this.lblHienThiSoTrang.Name = "lblHienThiSoTrang";
            this.lblHienThiSoTrang.Size = new System.Drawing.Size(81, 19);
            this.lblHienThiSoTrang.TabIndex = 17;
            this.lblHienThiSoTrang.Text = "metroLabel1";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtTongTien.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtTongTien.Location = new System.Drawing.Point(857, 446);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(94, 25);
            this.txtTongTien.TabIndex = 16;
            this.txtTongTien.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(697, 529);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(362, 76);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseCustomBackColor = true;
            this.btnThanhToan.UseSelectable = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel40.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel40.Location = new System.Drawing.Point(697, 446);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(108, 25);
            this.metroLabel40.TabIndex = 12;
            this.metroLabel40.Text = "Tổng cộng:";
            // 
            // gridListMonDaChon
            // 
            this.gridListMonDaChon.AllowUserToResizeColumns = false;
            this.gridListMonDaChon.AllowUserToResizeRows = false;
            this.gridListMonDaChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListMonDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListMonDaChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListMonDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListMonDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListMonDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListMonDaChon.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridListMonDaChon.EnableHeadersVisualStyles = false;
            this.gridListMonDaChon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridListMonDaChon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListMonDaChon.Location = new System.Drawing.Point(495, 56);
            this.gridListMonDaChon.Name = "gridListMonDaChon";
            this.gridListMonDaChon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListMonDaChon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridListMonDaChon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridListMonDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListMonDaChon.Size = new System.Drawing.Size(729, 387);
            this.gridListMonDaChon.TabIndex = 11;
            this.gridListMonDaChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListMonDaChon_CellContentClick);
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Location = new System.Drawing.Point(249, 517);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(14, 19);
            this.metroLabel38.TabIndex = 10;
            this.metroLabel38.Text = "/";
            // 
            // soTrangHienTai
            // 
            this.soTrangHienTai.Location = new System.Drawing.Point(161, 516);
            this.soTrangHienTai.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soTrangHienTai.Name = "soTrangHienTai";
            this.soTrangHienTai.Size = new System.Drawing.Size(57, 20);
            this.soTrangHienTai.TabIndex = 9;
            this.soTrangHienTai.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soTrangHienTai.ValueChanged += new System.EventHandler(this.soTrangHienTai_ValueChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTim.Location = new System.Drawing.Point(385, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 23);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseCustomBackColor = true;
            this.btnTim.UseSelectable = true;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(333, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(24, 56);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PromptText = "Nhập tên món cần tìm";
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(355, 23);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Nhập tên món cần tìm";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaBanDangPhucVu
            // 
            this.lblMaBanDangPhucVu.AutoSize = true;
            this.lblMaBanDangPhucVu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMaBanDangPhucVu.Location = new System.Drawing.Point(473, 12);
            this.lblMaBanDangPhucVu.Name = "lblMaBanDangPhucVu";
            this.lblMaBanDangPhucVu.Size = new System.Drawing.Size(42, 19);
            this.lblMaBanDangPhucVu.TabIndex = 4;
            this.lblMaBanDangPhucVu.Text = "Bàn: ";
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel36.Location = new System.Drawing.Point(9, 12);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(80, 19);
            this.metroLabel36.TabIndex = 3;
            this.metroLabel36.Text = "Chọn bàn: ";
            this.metroLabel36.Visible = false;
            // 
            // listBan
            // 
            this.listBan.FormattingEnabled = true;
            this.listBan.ItemHeight = 23;
            this.listBan.Location = new System.Drawing.Point(125, 12);
            this.listBan.Name = "listBan";
            this.listBan.Size = new System.Drawing.Size(121, 29);
            this.listBan.TabIndex = 2;
            this.listBan.UseSelectable = true;
            this.listBan.Visible = false;
            this.listBan.SelectedIndexChanged += new System.EventHandler(this.listBan_SelectedIndexChanged);
            // 
            // FormDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.metroPanel56);
            this.Name = "FormDatMon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatMon_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDatMon_FormClosed);
            this.Load += new System.EventHandler(this.FormDatMon_Load);
            this.metroPanel56.ResumeLayout(false);
            this.metroPanel56.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListMonDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTrangHienTai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel56;
        private MetroFramework.Controls.MetroButton btnThanhToan;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroGrid gridListMonDaChon;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private System.Windows.Forms.NumericUpDown soTrangHienTai;
        private MetroFramework.Controls.MetroButton btnTim;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private MetroFramework.Controls.MetroLabel lblMaBanDangPhucVu;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroComboBox listBan;
        private MetroFramework.Controls.MetroLabel txtTongTien;
        private MetroFramework.Controls.MetroLabel lblHienThiSoTrang;
        private MetroFramework.Controls.MetroListView lstViewSanPham;
        private System.Windows.Forms.ColumnHeader colTenSanPham;
        private System.Windows.Forms.ColumnHeader colLoaiSanPham;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colMaSanPham;
    }
}