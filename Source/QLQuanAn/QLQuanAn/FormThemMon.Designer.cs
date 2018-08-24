namespace QLQuanAn
{
    partial class FormThemMon
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
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.btnThemMon = new MetroFramework.Controls.MetroButton();
            this.txtLoaiMon = new MetroFramework.Controls.MetroTextBox();
            this.txtTenMon = new MetroFramework.Controls.MetroTextBox();
            this.lblMaMonRandom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtGia = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(234, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Mã món:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Location = new System.Drawing.Point(448, 318);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 54);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.Green;
            this.btnThemMon.Location = new System.Drawing.Point(234, 317);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(127, 55);
            this.btnThemMon.TabIndex = 24;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseSelectable = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtLoaiMon
            // 
            // 
            // 
            // 
            this.txtLoaiMon.CustomButton.Image = null;
            this.txtLoaiMon.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtLoaiMon.CustomButton.Name = "";
            this.txtLoaiMon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoaiMon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoaiMon.CustomButton.TabIndex = 1;
            this.txtLoaiMon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoaiMon.CustomButton.UseSelectable = true;
            this.txtLoaiMon.CustomButton.Visible = false;
            this.txtLoaiMon.Lines = new string[0];
            this.txtLoaiMon.Location = new System.Drawing.Point(350, 184);
            this.txtLoaiMon.MaxLength = 32767;
            this.txtLoaiMon.Name = "txtLoaiMon";
            this.txtLoaiMon.PasswordChar = '\0';
            this.txtLoaiMon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoaiMon.SelectedText = "";
            this.txtLoaiMon.SelectionLength = 0;
            this.txtLoaiMon.SelectionStart = 0;
            this.txtLoaiMon.ShortcutsEnabled = true;
            this.txtLoaiMon.Size = new System.Drawing.Size(219, 23);
            this.txtLoaiMon.TabIndex = 17;
            this.txtLoaiMon.UseSelectable = true;
            this.txtLoaiMon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoaiMon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenMon
            // 
            // 
            // 
            // 
            this.txtTenMon.CustomButton.Image = null;
            this.txtTenMon.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtTenMon.CustomButton.Name = "";
            this.txtTenMon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenMon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenMon.CustomButton.TabIndex = 1;
            this.txtTenMon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenMon.CustomButton.UseSelectable = true;
            this.txtTenMon.CustomButton.Visible = false;
            this.txtTenMon.Lines = new string[0];
            this.txtTenMon.Location = new System.Drawing.Point(350, 140);
            this.txtTenMon.MaxLength = 32767;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.SelectionLength = 0;
            this.txtTenMon.SelectionStart = 0;
            this.txtTenMon.ShortcutsEnabled = true;
            this.txtTenMon.Size = new System.Drawing.Size(219, 23);
            this.txtTenMon.TabIndex = 15;
            this.txtTenMon.UseSelectable = true;
            this.txtTenMon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenMon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaMonRandom
            // 
            this.lblMaMonRandom.AutoSize = true;
            this.lblMaMonRandom.Location = new System.Drawing.Point(350, 92);
            this.lblMaMonRandom.Name = "lblMaMonRandom";
            this.lblMaMonRandom.Size = new System.Drawing.Size(140, 19);
            this.lblMaMonRandom.TabIndex = 14;
            this.lblMaMonRandom.Text = "Hiện mã món random";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(234, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Tên món:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(234, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Loại món:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(234, 235);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Giá món:";
            // 
            // txtGia
            // 
            // 
            // 
            // 
            this.txtGia.CustomButton.Image = null;
            this.txtGia.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtGia.CustomButton.Name = "";
            this.txtGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGia.CustomButton.TabIndex = 1;
            this.txtGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGia.CustomButton.UseSelectable = true;
            this.txtGia.CustomButton.Visible = false;
            this.txtGia.Lines = new string[0];
            this.txtGia.Location = new System.Drawing.Point(350, 231);
            this.txtGia.MaxLength = 32767;
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGia.SelectedText = "";
            this.txtGia.SelectionLength = 0;
            this.txtGia.SelectionStart = 0;
            this.txtGia.ShortcutsEnabled = true;
            this.txtGia.Size = new System.Drawing.Size(219, 23);
            this.txtGia.TabIndex = 17;
            this.txtGia.UseSelectable = true;
            this.txtGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtLoaiMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblMaMonRandom);
            this.Name = "FormThemMon";
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.FormThemMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnThemMon;
        private MetroFramework.Controls.MetroTextBox txtLoaiMon;
        private MetroFramework.Controls.MetroTextBox txtTenMon;
        private MetroFramework.Controls.MetroLabel lblMaMonRandom;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtGia;
    }
}