namespace GUI
{
    partial class KHO_GUI
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
            this.txtTenNguyenLieu = new MetroFramework.Controls.MetroTextBox();
            this.btn_capNhat = new MetroFramework.Controls.MetroTile();
            this.btn_xoa = new MetroFramework.Controls.MetroTile();
            this.btn_them = new MetroFramework.Controls.MetroTile();
            this.grid_Kho = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kho)).BeginInit();
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
            this.txtTenNguyenLieu.TabIndex = 29;
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
            this.btn_capNhat.TabIndex = 28;
            this.btn_capNhat.Text = "Cập Nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_capNhat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_capNhat.UseSelectable = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveControl = null;
            this.btn_xoa.Location = new System.Drawing.Point(291, 107);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(146, 45);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_xoa.UseSelectable = true;
            // 
            // btn_them
            // 
            this.btn_them.ActiveControl = null;
            this.btn_them.Location = new System.Drawing.Point(90, 107);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(146, 45);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm Nguyên Liệu";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_them.UseSelectable = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grid_Kho
            // 
            this.grid_Kho.AllowUserToResizeColumns = false;
            this.grid_Kho.AllowUserToResizeRows = false;
            this.grid_Kho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Kho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Kho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Kho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Kho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Kho.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Kho.EnableHeadersVisualStyles = false;
            this.grid_Kho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Kho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Kho.Location = new System.Drawing.Point(81, 245);
            this.grid_Kho.Name = "grid_Kho";
            this.grid_Kho.ReadOnly = true;
            this.grid_Kho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Kho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Kho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Kho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Kho.Size = new System.Drawing.Size(1205, 416);
            this.grid_Kho.TabIndex = 25;
            // 
            // KHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grid_Kho);
            this.Name = "KHO";
            this.Text = "KHO";
            this.Load += new System.EventHandler(this.KHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTenNguyenLieu;
        private MetroFramework.Controls.MetroTile btn_capNhat;
        private MetroFramework.Controls.MetroTile btn_xoa;
        private MetroFramework.Controls.MetroTile btn_them;
        private MetroFramework.Controls.MetroGrid grid_Kho;
    }
}