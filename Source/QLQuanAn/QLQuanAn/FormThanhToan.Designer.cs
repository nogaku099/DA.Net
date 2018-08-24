namespace QLQuanAn
{
    partial class FormThanhToan
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTienKhachDua = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblTongTien = new MetroFramework.Controls.MetroLabel();
            this.btnXacNhanThanhToan = new MetroFramework.Controls.MetroButton();
            this.lblTienTraLai = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(38, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(195, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nhập vào số tiền khách đưa";
            // 
            // txtTienKhachDua
            // 
            // 
            // 
            // 
            this.txtTienKhachDua.CustomButton.Image = null;
            this.txtTienKhachDua.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtTienKhachDua.CustomButton.Name = "";
            this.txtTienKhachDua.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTienKhachDua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTienKhachDua.CustomButton.TabIndex = 1;
            this.txtTienKhachDua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTienKhachDua.CustomButton.UseSelectable = true;
            this.txtTienKhachDua.CustomButton.Visible = false;
            this.txtTienKhachDua.Lines = new string[0];
            this.txtTienKhachDua.Location = new System.Drawing.Point(251, 92);
            this.txtTienKhachDua.MaxLength = 32767;
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.PasswordChar = '\0';
            this.txtTienKhachDua.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTienKhachDua.SelectedText = "";
            this.txtTienKhachDua.SelectionLength = 0;
            this.txtTienKhachDua.SelectionStart = 0;
            this.txtTienKhachDua.ShortcutsEnabled = true;
            this.txtTienKhachDua.Size = new System.Drawing.Size(203, 23);
            this.txtTienKhachDua.TabIndex = 1;
            this.txtTienKhachDua.UseSelectable = true;
            this.txtTienKhachDua.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTienKhachDua.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTienKhachDua.TabStopChanged += new System.EventHandler(this.txtTienKhachDua_TabStopChanged);
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            this.txtTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(38, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tiền cần trả lại";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTongTien.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTongTien.Location = new System.Drawing.Point(130, 24);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(104, 25);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền :";
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(185, 217);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(123, 80);
            this.btnXacNhanThanhToan.TabIndex = 3;
            this.btnXacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btnXacNhanThanhToan.UseSelectable = true;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click);
            // 
            // lblTienTraLai
            // 
            this.lblTienTraLai.AutoSize = true;
            this.lblTienTraLai.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTienTraLai.Location = new System.Drawing.Point(251, 160);
            this.lblTienTraLai.Name = "lblTienTraLai";
            this.lblTienTraLai.Size = new System.Drawing.Size(0, 0);
            this.lblTienTraLai.TabIndex = 4;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 320);
            this.Controls.Add(this.lblTienTraLai);
            this.Controls.Add(this.btnXacNhanThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTienKhachDua);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTienKhachDua;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblTongTien;
        private MetroFramework.Controls.MetroButton btnXacNhanThanhToan;
        private MetroFramework.Controls.MetroLabel lblTienTraLai;
    }
}