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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.QLThucAnTabDoUong = new MetroFramework.Controls.MetroTabPage();
            this.QLThucAnTabThucAn = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.QLThucAnTabDoUong);
            this.metroTabControl1.Controls.Add(this.QLThucAnTabThucAn);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1129, 627);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // QLThucAnTabDoUong
            // 
            this.QLThucAnTabDoUong.HorizontalScrollbarBarColor = true;
            this.QLThucAnTabDoUong.HorizontalScrollbarHighlightOnWheel = false;
            this.QLThucAnTabDoUong.HorizontalScrollbarSize = 10;
            this.QLThucAnTabDoUong.Location = new System.Drawing.Point(4, 38);
            this.QLThucAnTabDoUong.Name = "QLThucAnTabDoUong";
            this.QLThucAnTabDoUong.Size = new System.Drawing.Size(1121, 585);
            this.QLThucAnTabDoUong.TabIndex = 0;
            this.QLThucAnTabDoUong.Text = "Thức uống";
            this.QLThucAnTabDoUong.VerticalScrollbarBarColor = true;
            this.QLThucAnTabDoUong.VerticalScrollbarHighlightOnWheel = false;
            this.QLThucAnTabDoUong.VerticalScrollbarSize = 10;
            // 
            // QLThucAnTabThucAn
            // 
            this.QLThucAnTabThucAn.HorizontalScrollbarBarColor = true;
            this.QLThucAnTabThucAn.HorizontalScrollbarHighlightOnWheel = false;
            this.QLThucAnTabThucAn.HorizontalScrollbarSize = 10;
            this.QLThucAnTabThucAn.Location = new System.Drawing.Point(4, 38);
            this.QLThucAnTabThucAn.Name = "QLThucAnTabThucAn";
            this.QLThucAnTabThucAn.Size = new System.Drawing.Size(1121, 585);
            this.QLThucAnTabThucAn.TabIndex = 1;
            this.QLThucAnTabThucAn.Text = "metroTabPage2";
            this.QLThucAnTabThucAn.VerticalScrollbarBarColor = true;
            this.QLThucAnTabThucAn.VerticalScrollbarHighlightOnWheel = false;
            this.QLThucAnTabThucAn.VerticalScrollbarSize = 10;
            // 
            // FormQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 662);
            this.Controls.Add(this.metroTabControl1);
            this.Location = new System.Drawing.Point(192, 93);
            this.Name = "FormQuanLyMon";
            this.Load += new System.EventHandler(this.FormQuanLyMon_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage QLThucAnTabDoUong;
        private MetroFramework.Controls.MetroTabPage QLThucAnTabThucAn;
    }
}