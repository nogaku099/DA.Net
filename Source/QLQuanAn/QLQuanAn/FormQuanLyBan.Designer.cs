namespace QLQuanAn
{
    partial class FormQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyBan));
            this.numericUpDownBan = new System.Windows.Forms.NumericUpDown();
            this.lblHienThiSoTrang = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ban5 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan5 = new MetroFramework.Controls.MetroLabel();
            this.ban6 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan6 = new MetroFramework.Controls.MetroLabel();
            this.ban4 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan4 = new MetroFramework.Controls.MetroLabel();
            this.ban2 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan2 = new MetroFramework.Controls.MetroLabel();
            this.ban3 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan3 = new MetroFramework.Controls.MetroLabel();
            this.ban1 = new MetroFramework.Controls.MetroPanel();
            this.txtMaBan1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBan)).BeginInit();
            this.ban5.SuspendLayout();
            this.ban6.SuspendLayout();
            this.ban4.SuspendLayout();
            this.ban2.SuspendLayout();
            this.ban3.SuspendLayout();
            this.ban1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownBan
            // 
            this.numericUpDownBan.Location = new System.Drawing.Point(445, 557);
            this.numericUpDownBan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBan.Name = "numericUpDownBan";
            this.numericUpDownBan.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownBan.TabIndex = 7;
            this.numericUpDownBan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBan.ValueChanged += new System.EventHandler(this.numericUpDownBan_ValueChanged);
            // 
            // lblHienThiSoTrang
            // 
            this.lblHienThiSoTrang.AutoSize = true;
            this.lblHienThiSoTrang.Location = new System.Drawing.Point(529, 557);
            this.lblHienThiSoTrang.Name = "lblHienThiSoTrang";
            this.lblHienThiSoTrang.Size = new System.Drawing.Size(83, 19);
            this.lblHienThiSoTrang.TabIndex = 6;
            this.lblHienThiSoTrang.Text = "metroLabel2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(497, 557);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(14, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "/";
            // 
            // ban5
            // 
            this.ban5.AccessibleName = "ban5";
            this.ban5.BackgroundImage = global::QLQuanAn.Properties.Resources.Ban_Edited;
            this.ban5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban5.Controls.Add(this.txtMaBan5);
            this.ban5.HorizontalScrollbarBarColor = true;
            this.ban5.HorizontalScrollbarHighlightOnWheel = false;
            this.ban5.HorizontalScrollbarSize = 10;
            this.ban5.Location = new System.Drawing.Point(811, 63);
            this.ban5.Name = "ban5";
            this.ban5.Size = new System.Drawing.Size(200, 157);
            this.ban5.TabIndex = 0;
            this.ban5.VerticalScrollbarBarColor = true;
            this.ban5.VerticalScrollbarHighlightOnWheel = false;
            this.ban5.VerticalScrollbarSize = 10;
            this.ban5.Click += new System.EventHandler(this.ban5_Click);
            // 
            // txtMaBan5
            // 
            this.txtMaBan5.AutoSize = true;
            this.txtMaBan5.Location = new System.Drawing.Point(56, 129);
            this.txtMaBan5.Name = "txtMaBan5";
            this.txtMaBan5.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan5.TabIndex = 2;
            this.txtMaBan5.Text = "Hiển thị mã bàn";
            // 
            // ban6
            // 
            this.ban6.AccessibleName = "ban6";
            this.ban6.BackgroundImage = global::QLQuanAn.Properties.Resources.Ban_Edited;
            this.ban6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban6.Controls.Add(this.txtMaBan6);
            this.ban6.HorizontalScrollbarBarColor = true;
            this.ban6.HorizontalScrollbarHighlightOnWheel = false;
            this.ban6.HorizontalScrollbarSize = 10;
            this.ban6.Location = new System.Drawing.Point(811, 308);
            this.ban6.Name = "ban6";
            this.ban6.Size = new System.Drawing.Size(200, 171);
            this.ban6.TabIndex = 0;
            this.ban6.VerticalScrollbarBarColor = true;
            this.ban6.VerticalScrollbarHighlightOnWheel = false;
            this.ban6.VerticalScrollbarSize = 10;
            this.ban6.Click += new System.EventHandler(this.ban6_Click);
            // 
            // txtMaBan6
            // 
            this.txtMaBan6.AutoSize = true;
            this.txtMaBan6.Location = new System.Drawing.Point(56, 134);
            this.txtMaBan6.Name = "txtMaBan6";
            this.txtMaBan6.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan6.TabIndex = 2;
            this.txtMaBan6.Text = "Hiển thị mã bàn";
            // 
            // ban4
            // 
            this.ban4.AccessibleName = "ban4";
            this.ban4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ban4.BackgroundImage")));
            this.ban4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban4.Controls.Add(this.txtMaBan4);
            this.ban4.HorizontalScrollbarBarColor = true;
            this.ban4.HorizontalScrollbarHighlightOnWheel = false;
            this.ban4.HorizontalScrollbarSize = 10;
            this.ban4.Location = new System.Drawing.Point(436, 308);
            this.ban4.Name = "ban4";
            this.ban4.Size = new System.Drawing.Size(200, 171);
            this.ban4.TabIndex = 0;
            this.ban4.VerticalScrollbarBarColor = true;
            this.ban4.VerticalScrollbarHighlightOnWheel = false;
            this.ban4.VerticalScrollbarSize = 10;
            this.ban4.Click += new System.EventHandler(this.ban4_Click);
            // 
            // txtMaBan4
            // 
            this.txtMaBan4.AutoSize = true;
            this.txtMaBan4.BackColor = System.Drawing.Color.White;
            this.txtMaBan4.ForeColor = System.Drawing.Color.Black;
            this.txtMaBan4.Location = new System.Drawing.Point(61, 134);
            this.txtMaBan4.Name = "txtMaBan4";
            this.txtMaBan4.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan4.TabIndex = 2;
            this.txtMaBan4.Text = "Hiển thị mã bàn";
            // 
            // ban2
            // 
            this.ban2.AccessibleName = "ban2";
            this.ban2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ban2.BackgroundImage")));
            this.ban2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban2.Controls.Add(this.txtMaBan2);
            this.ban2.HorizontalScrollbarBarColor = true;
            this.ban2.HorizontalScrollbarHighlightOnWheel = false;
            this.ban2.HorizontalScrollbarSize = 10;
            this.ban2.Location = new System.Drawing.Point(64, 308);
            this.ban2.Name = "ban2";
            this.ban2.Size = new System.Drawing.Size(200, 171);
            this.ban2.TabIndex = 0;
            this.ban2.VerticalScrollbarBarColor = true;
            this.ban2.VerticalScrollbarHighlightOnWheel = false;
            this.ban2.VerticalScrollbarSize = 10;
            this.ban2.Click += new System.EventHandler(this.ban2_Click);
            // 
            // txtMaBan2
            // 
            this.txtMaBan2.AutoSize = true;
            this.txtMaBan2.Location = new System.Drawing.Point(56, 134);
            this.txtMaBan2.Name = "txtMaBan2";
            this.txtMaBan2.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan2.TabIndex = 2;
            this.txtMaBan2.Text = "Hiển thị mã bàn";
            // 
            // ban3
            // 
            this.ban3.AccessibleName = "ban3";
            this.ban3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ban3.BackgroundImage")));
            this.ban3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban3.Controls.Add(this.txtMaBan3);
            this.ban3.HorizontalScrollbarBarColor = true;
            this.ban3.HorizontalScrollbarHighlightOnWheel = false;
            this.ban3.HorizontalScrollbarSize = 10;
            this.ban3.Location = new System.Drawing.Point(436, 63);
            this.ban3.Name = "ban3";
            this.ban3.Size = new System.Drawing.Size(200, 157);
            this.ban3.TabIndex = 0;
            this.ban3.VerticalScrollbarBarColor = true;
            this.ban3.VerticalScrollbarHighlightOnWheel = false;
            this.ban3.VerticalScrollbarSize = 10;
            this.ban3.Click += new System.EventHandler(this.ban3_Click);
            // 
            // txtMaBan3
            // 
            this.txtMaBan3.AutoSize = true;
            this.txtMaBan3.Location = new System.Drawing.Point(61, 129);
            this.txtMaBan3.Name = "txtMaBan3";
            this.txtMaBan3.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan3.TabIndex = 2;
            this.txtMaBan3.Text = "Hiển thị mã bàn";
            // 
            // ban1
            // 
            this.ban1.AccessibleName = "ban1";
            this.ban1.BackColor = System.Drawing.Color.White;
            this.ban1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ban1.BackgroundImage")));
            this.ban1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ban1.Controls.Add(this.txtMaBan1);
            this.ban1.HorizontalScrollbarBarColor = true;
            this.ban1.HorizontalScrollbarHighlightOnWheel = false;
            this.ban1.HorizontalScrollbarSize = 10;
            this.ban1.Location = new System.Drawing.Point(64, 63);
            this.ban1.Name = "ban1";
            this.ban1.Size = new System.Drawing.Size(200, 157);
            this.ban1.TabIndex = 0;
            this.ban1.VerticalScrollbarBarColor = true;
            this.ban1.VerticalScrollbarHighlightOnWheel = false;
            this.ban1.VerticalScrollbarSize = 10;
            this.ban1.Click += new System.EventHandler(this.ban1_Click);
            // 
            // txtMaBan1
            // 
            this.txtMaBan1.AutoSize = true;
            this.txtMaBan1.Location = new System.Drawing.Point(56, 129);
            this.txtMaBan1.Name = "txtMaBan1";
            this.txtMaBan1.Size = new System.Drawing.Size(102, 19);
            this.txtMaBan1.TabIndex = 2;
            this.txtMaBan1.Text = "Hiển thị mã bàn";
            // 
            // FormQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 601);
            this.Controls.Add(this.numericUpDownBan);
            this.Controls.Add(this.lblHienThiSoTrang);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ban6);
            this.Controls.Add(this.ban4);
            this.Controls.Add(this.ban2);
            this.Controls.Add(this.ban5);
            this.Controls.Add(this.ban3);
            this.Controls.Add(this.ban1);
            this.Location = new System.Drawing.Point(192, 93);
            this.Name = "FormQuanLyBan";
            this.Load += new System.EventHandler(this.FormQuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBan)).EndInit();
            this.ban5.ResumeLayout(false);
            this.ban5.PerformLayout();
            this.ban6.ResumeLayout(false);
            this.ban6.PerformLayout();
            this.ban4.ResumeLayout(false);
            this.ban4.PerformLayout();
            this.ban2.ResumeLayout(false);
            this.ban2.PerformLayout();
            this.ban3.ResumeLayout(false);
            this.ban3.PerformLayout();
            this.ban1.ResumeLayout(false);
            this.ban1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownBan;
        private MetroFramework.Controls.MetroLabel lblHienThiSoTrang;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel ban1;
        private MetroFramework.Controls.MetroPanel ban2;
        private MetroFramework.Controls.MetroPanel ban3;
        private MetroFramework.Controls.MetroPanel ban4;
        private MetroFramework.Controls.MetroPanel ban5;
        private MetroFramework.Controls.MetroPanel ban6;
        private MetroFramework.Controls.MetroLabel txtMaBan1;
        private MetroFramework.Controls.MetroLabel txtMaBan5;
        private MetroFramework.Controls.MetroLabel txtMaBan6;
        private MetroFramework.Controls.MetroLabel txtMaBan4;
        private MetroFramework.Controls.MetroLabel txtMaBan2;
        private MetroFramework.Controls.MetroLabel txtMaBan3;
    }
}