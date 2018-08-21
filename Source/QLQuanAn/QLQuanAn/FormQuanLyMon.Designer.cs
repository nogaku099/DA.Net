namespace QLQuanAn
{
    partial class FormQuanLyMon
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
            this.tabMon = new MetroFramework.Controls.MetroTabControl();
            this.QLDoUong = new MetroFramework.Controls.MetroTabPage();
            this.QLDoAn = new MetroFramework.Controls.MetroTabPage();
            this.tabMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMon
            // 
            this.tabMon.Controls.Add(this.QLDoUong);
            this.tabMon.Controls.Add(this.QLDoAn);
            this.tabMon.Location = new System.Drawing.Point(23, 35);
            this.tabMon.Name = "tabMon";
            this.tabMon.SelectedIndex = 1;
            this.tabMon.Size = new System.Drawing.Size(1105, 604);
            this.tabMon.TabIndex = 1;
            this.tabMon.UseSelectable = true;
            // 
            // QLDoUong
            // 
            this.QLDoUong.HorizontalScrollbarBarColor = true;
            this.QLDoUong.HorizontalScrollbarHighlightOnWheel = false;
            this.QLDoUong.HorizontalScrollbarSize = 10;
            this.QLDoUong.Location = new System.Drawing.Point(4, 38);
            this.QLDoUong.Name = "QLDoUong";
            this.QLDoUong.Size = new System.Drawing.Size(1097, 562);
            this.QLDoUong.TabIndex = 0;
            this.QLDoUong.Text = "Thức uống";
            this.QLDoUong.VerticalScrollbarBarColor = true;
            this.QLDoUong.VerticalScrollbarHighlightOnWheel = false;
            this.QLDoUong.VerticalScrollbarSize = 10;
            // 
            // QLDoAn
            // 
            this.QLDoAn.HorizontalScrollbarBarColor = true;
            this.QLDoAn.HorizontalScrollbarHighlightOnWheel = false;
            this.QLDoAn.HorizontalScrollbarSize = 10;
            this.QLDoAn.Location = new System.Drawing.Point(4, 38);
            this.QLDoAn.Name = "QLDoAn";
            this.QLDoAn.Size = new System.Drawing.Size(1097, 562);
            this.QLDoAn.TabIndex = 1;
            this.QLDoAn.Text = "Đồ ăn";
            this.QLDoAn.VerticalScrollbarBarColor = true;
            this.QLDoAn.VerticalScrollbarHighlightOnWheel = false;
            this.QLDoAn.VerticalScrollbarSize = 10;
            // 
            // FormQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 662);
            this.Controls.Add(this.tabMon);
            this.Location = new System.Drawing.Point(192, 93);
            this.Name = "FormQuanLyMon";
            this.Load += new System.EventHandler(this.FormQuanLyMon_Load);
            this.tabMon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabMon;
        private MetroFramework.Controls.MetroTabPage QLDoUong;
        private MetroFramework.Controls.MetroTabPage QLDoAn;
    }
}