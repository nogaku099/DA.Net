namespace GUI
{
    partial class QUANLYNGUYENLIEU
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTenNguyenLieu = new MetroFramework.Controls.MetroTextBox();
            this.btn_capNhat = new MetroFramework.Controls.MetroTile();
            this.btn_xoa = new MetroFramework.Controls.MetroTile();
            this.btn_them = new MetroFramework.Controls.MetroTile();
            this.grid_NguyenLieu = new MetroFramework.Controls.MetroGrid();
            this.txt_loaiDonVi = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNguyenLieu
            // 
            // 
            // 
            // 
            this.txtTenNguyenLieu.CustomButton.Image = null;
            this.txtTenNguyenLieu.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtTenNguyenLieu.CustomButton.Name = "";
            this.txtTenNguyenLieu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenNguyenLieu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenNguyenLieu.CustomButton.TabIndex = 1;
            this.txtTenNguyenLieu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenNguyenLieu.CustomButton.UseSelectable = true;
            this.txtTenNguyenLieu.CustomButton.Visible = false;
            this.txtTenNguyenLieu.Lines = new string[0];
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(90, 174);
            this.txtTenNguyenLieu.MaxLength = 32767;
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.PasswordChar = '\0';
            this.txtTenNguyenLieu.PromptText = "Tên Nguyên Liệu";
            this.txtTenNguyenLieu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenNguyenLieu.SelectedText = "";
            this.txtTenNguyenLieu.SelectionLength = 0;
            this.txtTenNguyenLieu.SelectionStart = 0;
            this.txtTenNguyenLieu.ShortcutsEnabled = true;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(165, 23);
            this.txtTenNguyenLieu.TabIndex = 24;
            this.txtTenNguyenLieu.UseSelectable = true;
            this.txtTenNguyenLieu.WaterMark = "Tên Nguyên Liệu";
            this.txtTenNguyenLieu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenNguyenLieu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.ActiveControl = null;
            this.btn_capNhat.Location = new System.Drawing.Point(496, 107);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(146, 45);
            this.btn_capNhat.TabIndex = 23;
            this.btn_capNhat.Text = "Cập Nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_capNhat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_capNhat.UseSelectable = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveControl = null;
            this.btn_xoa.Location = new System.Drawing.Point(291, 107);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(146, 45);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_xoa.UseSelectable = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.ActiveControl = null;
            this.btn_them.Location = new System.Drawing.Point(90, 107);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(146, 45);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm Nguyên Liệu";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_them.UseSelectable = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grid_NguyenLieu
            // 
            this.grid_NguyenLieu.AllowUserToResizeColumns = false;
            this.grid_NguyenLieu.AllowUserToResizeRows = false;
            this.grid_NguyenLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_NguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_NguyenLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_NguyenLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_NguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_NguyenLieu.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_NguyenLieu.EnableHeadersVisualStyles = false;
            this.grid_NguyenLieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_NguyenLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_NguyenLieu.Location = new System.Drawing.Point(81, 245);
            this.grid_NguyenLieu.Name = "grid_NguyenLieu";
            this.grid_NguyenLieu.ReadOnly = true;
            this.grid_NguyenLieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_NguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_NguyenLieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_NguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_NguyenLieu.Size = new System.Drawing.Size(1205, 416);
            this.grid_NguyenLieu.TabIndex = 20;
            this.grid_NguyenLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_NguyenLieu_CellContentClick);
            this.grid_NguyenLieu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_NguyenLieu_MouseClick);
            // 
            // txt_loaiDonVi
            // 
            // 
            // 
            // 
            this.txt_loaiDonVi.CustomButton.Image = null;
            this.txt_loaiDonVi.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_loaiDonVi.CustomButton.Name = "";
            this.txt_loaiDonVi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_loaiDonVi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_loaiDonVi.CustomButton.TabIndex = 1;
            this.txt_loaiDonVi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_loaiDonVi.CustomButton.UseSelectable = true;
            this.txt_loaiDonVi.CustomButton.Visible = false;
            this.txt_loaiDonVi.Lines = new string[0];
            this.txt_loaiDonVi.Location = new System.Drawing.Point(291, 174);
            this.txt_loaiDonVi.MaxLength = 32767;
            this.txt_loaiDonVi.Name = "txt_loaiDonVi";
            this.txt_loaiDonVi.PasswordChar = '\0';
            this.txt_loaiDonVi.PromptText = "Loại Đơn Vị";
            this.txt_loaiDonVi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_loaiDonVi.SelectedText = "";
            this.txt_loaiDonVi.SelectionLength = 0;
            this.txt_loaiDonVi.SelectionStart = 0;
            this.txt_loaiDonVi.ShortcutsEnabled = true;
            this.txt_loaiDonVi.Size = new System.Drawing.Size(165, 23);
            this.txt_loaiDonVi.TabIndex = 25;
            this.txt_loaiDonVi.UseSelectable = true;
            this.txt_loaiDonVi.WaterMark = "Loại Đơn Vị";
            this.txt_loaiDonVi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_loaiDonVi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QUANLYNGUYENLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txt_loaiDonVi);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grid_NguyenLieu);
            this.Name = "QUANLYNGUYENLIEU";
            this.Text = "QUANLYNGUYENLIEU";
            this.Load += new System.EventHandler(this.QUANLYNGUYENLIEU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtTenNguyenLieu;
        private MetroFramework.Controls.MetroTile btn_capNhat;
        private MetroFramework.Controls.MetroTile btn_xoa;
        private MetroFramework.Controls.MetroTile btn_them;
        private MetroFramework.Controls.MetroGrid grid_NguyenLieu;
        private MetroFramework.Controls.MetroTextBox txt_loaiDonVi;
    }
}