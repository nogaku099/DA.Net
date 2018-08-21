namespace QLQuanAn
{
    partial class FormThemNhanVien
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
            this.lblMaNhanVienRandom = new MetroFramework.Controls.MetroLabel();
            this.lblTaiKhoanRandom = new MetroFramework.Controls.MetroLabel();
            this.txtTenNhanVienMoi = new MetroFramework.Controls.MetroTextBox();
            this.txtDiaChiNVMoi = new MetroFramework.Controls.MetroTextBox();
            this.txtSoDienThoaiNVMoi = new MetroFramework.Controls.MetroTextBox();
            this.chonChucVu = new MetroFramework.Controls.MetroComboBox();
            this.matKhau1ChoNVMoi = new MetroFramework.Controls.MetroTextBox();
            this.btnThemNhanVien = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.chonNgaySinhNVMoi = new MetroFramework.Controls.MetroDateTime();
            this.matKhau2ChoNVMoi = new MetroFramework.Controls.MetroTextBox();
            this.cbTaoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblMaNhanVienRandom
            // 
            this.lblMaNhanVienRandom.AutoSize = true;
            this.lblMaNhanVienRandom.Location = new System.Drawing.Point(161, 82);
            this.lblMaNhanVienRandom.Name = "lblMaNhanVienRandom";
            this.lblMaNhanVienRandom.Size = new System.Drawing.Size(168, 19);
            this.lblMaNhanVienRandom.TabIndex = 1;
            this.lblMaNhanVienRandom.Text = "Hiện mã nhân viên random";
            // 
            // lblTaiKhoanRandom
            // 
            this.lblTaiKhoanRandom.AutoSize = true;
            this.lblTaiKhoanRandom.Location = new System.Drawing.Point(446, 193);
            this.lblTaiKhoanRandom.Name = "lblTaiKhoanRandom";
            this.lblTaiKhoanRandom.Size = new System.Drawing.Size(122, 19);
            this.lblTaiKhoanRandom.TabIndex = 1;
            this.lblTaiKhoanRandom.Text = "Hiện tên tk random";
            this.lblTaiKhoanRandom.Visible = false;
            // 
            // txtTenNhanVienMoi
            // 
            // 
            // 
            // 
            this.txtTenNhanVienMoi.CustomButton.Image = null;
            this.txtTenNhanVienMoi.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtTenNhanVienMoi.CustomButton.Name = "";
            this.txtTenNhanVienMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenNhanVienMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenNhanVienMoi.CustomButton.TabIndex = 1;
            this.txtTenNhanVienMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenNhanVienMoi.CustomButton.UseSelectable = true;
            this.txtTenNhanVienMoi.CustomButton.Visible = false;
            this.txtTenNhanVienMoi.Lines = new string[] {
        "Họ và tên nhân viên"};
            this.txtTenNhanVienMoi.Location = new System.Drawing.Point(89, 125);
            this.txtTenNhanVienMoi.MaxLength = 32767;
            this.txtTenNhanVienMoi.Name = "txtTenNhanVienMoi";
            this.txtTenNhanVienMoi.PasswordChar = '\0';
            this.txtTenNhanVienMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenNhanVienMoi.SelectedText = "";
            this.txtTenNhanVienMoi.SelectionLength = 0;
            this.txtTenNhanVienMoi.SelectionStart = 0;
            this.txtTenNhanVienMoi.ShortcutsEnabled = true;
            this.txtTenNhanVienMoi.Size = new System.Drawing.Size(219, 23);
            this.txtTenNhanVienMoi.TabIndex = 2;
            this.txtTenNhanVienMoi.Text = "Họ và tên nhân viên";
            this.txtTenNhanVienMoi.UseSelectable = true;
            this.txtTenNhanVienMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenNhanVienMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenNhanVienMoi.Enter += new System.EventHandler(this.txtTenNhanVienMoi_Enter);
            this.txtTenNhanVienMoi.Leave += new System.EventHandler(this.txtTenNhanVienMoi_Leave);
            // 
            // txtDiaChiNVMoi
            // 
            // 
            // 
            // 
            this.txtDiaChiNVMoi.CustomButton.Image = null;
            this.txtDiaChiNVMoi.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtDiaChiNVMoi.CustomButton.Name = "";
            this.txtDiaChiNVMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiaChiNVMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiaChiNVMoi.CustomButton.TabIndex = 1;
            this.txtDiaChiNVMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiaChiNVMoi.CustomButton.UseSelectable = true;
            this.txtDiaChiNVMoi.CustomButton.Visible = false;
            this.txtDiaChiNVMoi.Lines = new string[] {
        "Địa chỉ nhân viên"};
            this.txtDiaChiNVMoi.Location = new System.Drawing.Point(89, 220);
            this.txtDiaChiNVMoi.MaxLength = 32767;
            this.txtDiaChiNVMoi.Name = "txtDiaChiNVMoi";
            this.txtDiaChiNVMoi.PasswordChar = '\0';
            this.txtDiaChiNVMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiaChiNVMoi.SelectedText = "";
            this.txtDiaChiNVMoi.SelectionLength = 0;
            this.txtDiaChiNVMoi.SelectionStart = 0;
            this.txtDiaChiNVMoi.ShortcutsEnabled = true;
            this.txtDiaChiNVMoi.Size = new System.Drawing.Size(219, 23);
            this.txtDiaChiNVMoi.TabIndex = 4;
            this.txtDiaChiNVMoi.Text = "Địa chỉ nhân viên";
            this.txtDiaChiNVMoi.UseSelectable = true;
            this.txtDiaChiNVMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiaChiNVMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaChiNVMoi.Enter += new System.EventHandler(this.txtDiaChiNVMoi_Enter);
            this.txtDiaChiNVMoi.Leave += new System.EventHandler(this.txtDiaChiNVMoi_Leave);
            // 
            // txtSoDienThoaiNVMoi
            // 
            // 
            // 
            // 
            this.txtSoDienThoaiNVMoi.CustomButton.Image = null;
            this.txtSoDienThoaiNVMoi.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtSoDienThoaiNVMoi.CustomButton.Name = "";
            this.txtSoDienThoaiNVMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoDienThoaiNVMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoDienThoaiNVMoi.CustomButton.TabIndex = 1;
            this.txtSoDienThoaiNVMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoDienThoaiNVMoi.CustomButton.UseSelectable = true;
            this.txtSoDienThoaiNVMoi.CustomButton.Visible = false;
            this.txtSoDienThoaiNVMoi.Lines = new string[] {
        "Số điện thoại nhân viên"};
            this.txtSoDienThoaiNVMoi.Location = new System.Drawing.Point(89, 262);
            this.txtSoDienThoaiNVMoi.MaxLength = 32767;
            this.txtSoDienThoaiNVMoi.Name = "txtSoDienThoaiNVMoi";
            this.txtSoDienThoaiNVMoi.PasswordChar = '\0';
            this.txtSoDienThoaiNVMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoDienThoaiNVMoi.SelectedText = "";
            this.txtSoDienThoaiNVMoi.SelectionLength = 0;
            this.txtSoDienThoaiNVMoi.SelectionStart = 0;
            this.txtSoDienThoaiNVMoi.ShortcutsEnabled = true;
            this.txtSoDienThoaiNVMoi.Size = new System.Drawing.Size(219, 23);
            this.txtSoDienThoaiNVMoi.TabIndex = 5;
            this.txtSoDienThoaiNVMoi.Text = "Số điện thoại nhân viên";
            this.txtSoDienThoaiNVMoi.UseSelectable = true;
            this.txtSoDienThoaiNVMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoDienThoaiNVMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoDienThoaiNVMoi.Enter += new System.EventHandler(this.txtSoDienThoaiNVMoi_Enter);
            this.txtSoDienThoaiNVMoi.Leave += new System.EventHandler(this.txtSoDienThoaiNVMoi_Leave);
            // 
            // chonChucVu
            // 
            this.chonChucVu.FormattingEnabled = true;
            this.chonChucVu.ItemHeight = 23;
            this.chonChucVu.Items.AddRange(new object[] {
            "Chọn chức vụ",
            "NV",
            "QL"});
            this.chonChucVu.Location = new System.Drawing.Point(374, 125);
            this.chonChucVu.Name = "chonChucVu";
            this.chonChucVu.Size = new System.Drawing.Size(219, 29);
            this.chonChucVu.TabIndex = 6;
            this.chonChucVu.UseSelectable = true;
            // 
            // matKhau1ChoNVMoi
            // 
            // 
            // 
            // 
            this.matKhau1ChoNVMoi.CustomButton.Image = null;
            this.matKhau1ChoNVMoi.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.matKhau1ChoNVMoi.CustomButton.Name = "";
            this.matKhau1ChoNVMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matKhau1ChoNVMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matKhau1ChoNVMoi.CustomButton.TabIndex = 1;
            this.matKhau1ChoNVMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matKhau1ChoNVMoi.CustomButton.UseSelectable = true;
            this.matKhau1ChoNVMoi.CustomButton.Visible = false;
            this.matKhau1ChoNVMoi.Lines = new string[] {
        "Nhập mật khẩu 1...."};
            this.matKhau1ChoNVMoi.Location = new System.Drawing.Point(374, 229);
            this.matKhau1ChoNVMoi.MaxLength = 32767;
            this.matKhau1ChoNVMoi.Name = "matKhau1ChoNVMoi";
            this.matKhau1ChoNVMoi.PasswordChar = '\0';
            this.matKhau1ChoNVMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matKhau1ChoNVMoi.SelectedText = "";
            this.matKhau1ChoNVMoi.SelectionLength = 0;
            this.matKhau1ChoNVMoi.SelectionStart = 0;
            this.matKhau1ChoNVMoi.ShortcutsEnabled = true;
            this.matKhau1ChoNVMoi.Size = new System.Drawing.Size(219, 23);
            this.matKhau1ChoNVMoi.TabIndex = 8;
            this.matKhau1ChoNVMoi.Text = "Nhập mật khẩu 1....";
            this.matKhau1ChoNVMoi.UseSelectable = true;
            this.matKhau1ChoNVMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matKhau1ChoNVMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.matKhau1ChoNVMoi.Enter += new System.EventHandler(this.matKhau1ChoNVMoi_Enter);
            this.matKhau1ChoNVMoi.Leave += new System.EventHandler(this.matKhau1ChoNVMoi_Leave);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(202, 372);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(127, 55);
            this.btnThemNhanVien.TabIndex = 10;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseSelectable = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(472, 372);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 54);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // chonNgaySinhNVMoi
            // 
            this.chonNgaySinhNVMoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chonNgaySinhNVMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chonNgaySinhNVMoi.Location = new System.Drawing.Point(89, 169);
            this.chonNgaySinhNVMoi.MinimumSize = new System.Drawing.Size(0, 29);
            this.chonNgaySinhNVMoi.Name = "chonNgaySinhNVMoi";
            this.chonNgaySinhNVMoi.Size = new System.Drawing.Size(219, 29);
            this.chonNgaySinhNVMoi.TabIndex = 3;
            // 
            // matKhau2ChoNVMoi
            // 
            // 
            // 
            // 
            this.matKhau2ChoNVMoi.CustomButton.Image = null;
            this.matKhau2ChoNVMoi.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.matKhau2ChoNVMoi.CustomButton.Name = "";
            this.matKhau2ChoNVMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matKhau2ChoNVMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matKhau2ChoNVMoi.CustomButton.TabIndex = 1;
            this.matKhau2ChoNVMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matKhau2ChoNVMoi.CustomButton.UseSelectable = true;
            this.matKhau2ChoNVMoi.CustomButton.Visible = false;
            this.matKhau2ChoNVMoi.Lines = new string[] {
        "Nhập mật khẩu 2...."};
            this.matKhau2ChoNVMoi.Location = new System.Drawing.Point(374, 262);
            this.matKhau2ChoNVMoi.MaxLength = 32767;
            this.matKhau2ChoNVMoi.Name = "matKhau2ChoNVMoi";
            this.matKhau2ChoNVMoi.PasswordChar = '\0';
            this.matKhau2ChoNVMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matKhau2ChoNVMoi.SelectedText = "";
            this.matKhau2ChoNVMoi.SelectionLength = 0;
            this.matKhau2ChoNVMoi.SelectionStart = 0;
            this.matKhau2ChoNVMoi.ShortcutsEnabled = true;
            this.matKhau2ChoNVMoi.Size = new System.Drawing.Size(219, 23);
            this.matKhau2ChoNVMoi.TabIndex = 9;
            this.matKhau2ChoNVMoi.Text = "Nhập mật khẩu 2....";
            this.matKhau2ChoNVMoi.UseSelectable = true;
            this.matKhau2ChoNVMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matKhau2ChoNVMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.matKhau2ChoNVMoi.Enter += new System.EventHandler(this.matKhau2ChoNVMoi_Enter);
            this.matKhau2ChoNVMoi.Leave += new System.EventHandler(this.matKhau2ChoNVMoi_Leave);
            // 
            // cbTaoTaiKhoan
            // 
            this.cbTaoTaiKhoan.AutoSize = true;
            this.cbTaoTaiKhoan.Location = new System.Drawing.Point(374, 169);
            this.cbTaoTaiKhoan.Name = "cbTaoTaiKhoan";
            this.cbTaoTaiKhoan.Size = new System.Drawing.Size(92, 17);
            this.cbTaoTaiKhoan.TabIndex = 7;
            this.cbTaoTaiKhoan.Text = "Tạo tài khoản";
            this.cbTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.cbTaoTaiKhoan.CheckedChanged += new System.EventHandler(this.cbTaoTaiKhoan_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(374, 193);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Tài khoản:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(89, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Mã NV";
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbTaoTaiKhoan);
            this.Controls.Add(this.chonNgaySinhNVMoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.chonChucVu);
            this.Controls.Add(this.txtSoDienThoaiNVMoi);
            this.Controls.Add(this.matKhau2ChoNVMoi);
            this.Controls.Add(this.matKhau1ChoNVMoi);
            this.Controls.Add(this.txtDiaChiNVMoi);
            this.Controls.Add(this.txtTenNhanVienMoi);
            this.Controls.Add(this.lblTaiKhoanRandom);
            this.Controls.Add(this.lblMaNhanVienRandom);
            this.Name = "FormThemNhanVien";
            this.Load += new System.EventHandler(this.FormThemNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblMaNhanVienRandom;
        private MetroFramework.Controls.MetroLabel lblTaiKhoanRandom;
        private MetroFramework.Controls.MetroTextBox txtTenNhanVienMoi;
        private MetroFramework.Controls.MetroTextBox txtDiaChiNVMoi;
        private MetroFramework.Controls.MetroTextBox txtSoDienThoaiNVMoi;
        private MetroFramework.Controls.MetroComboBox chonChucVu;
        private MetroFramework.Controls.MetroTextBox matKhau1ChoNVMoi;
        private MetroFramework.Controls.MetroButton btnThemNhanVien;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroDateTime chonNgaySinhNVMoi;
        private MetroFramework.Controls.MetroTextBox matKhau2ChoNVMoi;
        private System.Windows.Forms.CheckBox cbTaoTaiKhoan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}