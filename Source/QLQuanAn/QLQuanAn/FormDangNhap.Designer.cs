namespace QLQuanAn
{
    partial class FormDangNhap
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.btnXoaDangNhap = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(112, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Mật khẩu";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(112, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTaiKhoan.CustomButton.Image = null;
            this.txtTaiKhoan.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtTaiKhoan.CustomButton.Name = "";
            this.txtTaiKhoan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaiKhoan.CustomButton.TabIndex = 1;
            this.txtTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaiKhoan.CustomButton.UseSelectable = true;
            this.txtTaiKhoan.CustomButton.Visible = false;
            this.txtTaiKhoan.Lines = new string[0];
            this.txtTaiKhoan.Location = new System.Drawing.Point(224, 124);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.SelectionLength = 0;
            this.txtTaiKhoan.SelectionStart = 0;
            this.txtTaiKhoan.ShortcutsEnabled = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(210, 23);
            this.txtTaiKhoan.TabIndex = 0;
            this.txtTaiKhoan.UseSelectable = true;
            this.txtTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaiKhoan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(224, 193);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PromptText = "******";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(210, 23);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.WaterMark = "******";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(224, 265);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnXoaDangNhap
            // 
            this.btnXoaDangNhap.Location = new System.Drawing.Point(339, 265);
            this.btnXoaDangNhap.Name = "btnXoaDangNhap";
            this.btnXoaDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDangNhap.TabIndex = 4;
            this.btnXoaDangNhap.Text = "Xóa";
            this.btnXoaDangNhap.UseSelectable = true;
            this.btnXoaDangNhap.Click += new System.EventHandler(this.btnXoaDangNhap_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 382);
            this.Controls.Add(this.btnXoaDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTaiKhoan;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Controls.MetroButton btnXoaDangNhap;
    }
}

