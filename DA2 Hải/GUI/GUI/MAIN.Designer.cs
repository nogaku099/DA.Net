namespace GUI
{
    partial class MAIN
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
            this.labelname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassWords = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelname.Location = new System.Drawing.Point(760, 413);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(105, 25);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "User Name";
            this.labelname.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(760, 479);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Passwords";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[] {
        "donghai"};
            this.txtUserName.Location = new System.Drawing.Point(906, 413);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "User Name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(276, 23);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Tag = "1";
            this.txtUserName.Text = "donghai";
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "User Name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassWords
            // 
            // 
            // 
            // 
            this.txtPassWords.CustomButton.Image = null;
            this.txtPassWords.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtPassWords.CustomButton.Name = "";
            this.txtPassWords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassWords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassWords.CustomButton.TabIndex = 1;
            this.txtPassWords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassWords.CustomButton.UseSelectable = true;
            this.txtPassWords.CustomButton.Visible = false;
            this.txtPassWords.Lines = new string[] {
        "donghai"};
            this.txtPassWords.Location = new System.Drawing.Point(906, 481);
            this.txtPassWords.MaxLength = 32767;
            this.txtPassWords.Name = "txtPassWords";
            this.txtPassWords.PasswordChar = '●';
            this.txtPassWords.PromptText = "PassWords";
            this.txtPassWords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWords.SelectedText = "";
            this.txtPassWords.SelectionLength = 0;
            this.txtPassWords.SelectionStart = 0;
            this.txtPassWords.ShortcutsEnabled = true;
            this.txtPassWords.Size = new System.Drawing.Size(276, 23);
            this.txtPassWords.TabIndex = 4;
            this.txtPassWords.Tag = "2";
            this.txtPassWords.Text = "donghai";
            this.txtPassWords.UseSelectable = true;
            this.txtPassWords.UseSystemPasswordChar = true;
            this.txtPassWords.WaterMark = "PassWords";
            this.txtPassWords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassWords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.download;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(871, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 218);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.maxresdefault;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActiveControl = null;
            this.btnDangNhap.Location = new System.Drawing.Point(760, 566);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(422, 71);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Tag = "3";
            this.btnDangNhap.Text = "LOGIN";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDangNhap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDangNhap_KeyDown);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassWords);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MAIN";
            this.Text = "Coffee Manager";
            this.Load += new System.EventHandler(this.MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel labelname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassWords;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile btnDangNhap;
    }
}

