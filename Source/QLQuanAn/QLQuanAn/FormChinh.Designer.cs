﻿namespace QLQuanAn
{
    partial class FormChinh
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
            this.lblHienThiUser = new MetroFramework.Controls.MetroLabel();
            this.chucNangQLNhanvien = new MetroFramework.Controls.MetroTile();
            this.chucNangQLMon = new MetroFramework.Controls.MetroTile();
            this.chucNangQLHoaDon = new MetroFramework.Controls.MetroTile();
            this.chucNangQLBan = new MetroFramework.Controls.MetroTile();
            this.lblNgayThangHienTai = new MetroFramework.Controls.MetroLabel();
            this.btnDangXuat = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblHienThiUser
            // 
            this.lblHienThiUser.AutoSize = true;
            this.lblHienThiUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHienThiUser.Location = new System.Drawing.Point(211, 49);
            this.lblHienThiUser.Name = "lblHienThiUser";
            this.lblHienThiUser.Size = new System.Drawing.Size(94, 19);
            this.lblHienThiUser.TabIndex = 0;
            this.lblHienThiUser.Text = "tenNhanVien";
            // 
            // chucNangQLNhanvien
            // 
            this.chucNangQLNhanvien.ActiveControl = null;
            this.chucNangQLNhanvien.Location = new System.Drawing.Point(661, 413);
            this.chucNangQLNhanvien.Name = "chucNangQLNhanvien";
            this.chucNangQLNhanvien.Size = new System.Drawing.Size(216, 163);
            this.chucNangQLNhanvien.TabIndex = 3;
            this.chucNangQLNhanvien.Text = "Quản lý nhân viên";
            this.chucNangQLNhanvien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chucNangQLNhanvien.TileImage = global::QLQuanAn.Properties.Resources.icons8_people_100;
            this.chucNangQLNhanvien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chucNangQLNhanvien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chucNangQLNhanvien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.chucNangQLNhanvien.UseSelectable = true;
            this.chucNangQLNhanvien.UseTileImage = true;
            this.chucNangQLNhanvien.Click += new System.EventHandler(this.chucNangQLNhanvien_Click);
            // 
            // chucNangQLMon
            // 
            this.chucNangQLMon.ActiveControl = null;
            this.chucNangQLMon.Location = new System.Drawing.Point(371, 413);
            this.chucNangQLMon.Name = "chucNangQLMon";
            this.chucNangQLMon.Size = new System.Drawing.Size(216, 163);
            this.chucNangQLMon.TabIndex = 3;
            this.chucNangQLMon.Text = "Quản lý món";
            this.chucNangQLMon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chucNangQLMon.TileImage = global::QLQuanAn.Properties.Resources.icons8_food_100;
            this.chucNangQLMon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chucNangQLMon.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chucNangQLMon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.chucNangQLMon.UseSelectable = true;
            this.chucNangQLMon.UseTileImage = true;
            this.chucNangQLMon.Click += new System.EventHandler(this.chucNangQLMon_Click);
            // 
            // chucNangQLHoaDon
            // 
            this.chucNangQLHoaDon.ActiveControl = null;
            this.chucNangQLHoaDon.Location = new System.Drawing.Point(661, 191);
            this.chucNangQLHoaDon.Name = "chucNangQLHoaDon";
            this.chucNangQLHoaDon.Size = new System.Drawing.Size(216, 169);
            this.chucNangQLHoaDon.TabIndex = 3;
            this.chucNangQLHoaDon.Text = "Quản lý hoá đơn";
            this.chucNangQLHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chucNangQLHoaDon.TileImage = global::QLQuanAn.Properties.Resources.icons8_purchase_order_100;
            this.chucNangQLHoaDon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chucNangQLHoaDon.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chucNangQLHoaDon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.chucNangQLHoaDon.UseSelectable = true;
            this.chucNangQLHoaDon.UseTileImage = true;
            this.chucNangQLHoaDon.Click += new System.EventHandler(this.chucNangQLHoaDon_Click);
            // 
            // chucNangQLBan
            // 
            this.chucNangQLBan.ActiveControl = null;
            this.chucNangQLBan.Location = new System.Drawing.Point(371, 191);
            this.chucNangQLBan.Name = "chucNangQLBan";
            this.chucNangQLBan.Size = new System.Drawing.Size(216, 169);
            this.chucNangQLBan.TabIndex = 3;
            this.chucNangQLBan.Text = "Quản lý bàn";
            this.chucNangQLBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chucNangQLBan.TileImage = global::QLQuanAn.Properties.Resources.icons8_table_100;
            this.chucNangQLBan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chucNangQLBan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chucNangQLBan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.chucNangQLBan.UseSelectable = true;
            this.chucNangQLBan.UseTileImage = true;
            this.chucNangQLBan.Click += new System.EventHandler(this.chucNangQLBan_Click);
            // 
            // lblNgayThangHienTai
            // 
            this.lblNgayThangHienTai.AutoSize = true;
            this.lblNgayThangHienTai.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNgayThangHienTai.Location = new System.Drawing.Point(802, 49);
            this.lblNgayThangHienTai.Name = "lblNgayThangHienTai";
            this.lblNgayThangHienTai.Size = new System.Drawing.Size(133, 19);
            this.lblNgayThangHienTai.TabIndex = 4;
            this.lblNgayThangHienTai.Text = "ngayThangHienTai";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ActiveControl = null;
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangXuat.Location = new System.Drawing.Point(23, 701);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(74, 59);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.TileImage = global::QLQuanAn.Properties.Resources.icons8_exit_26;
            this.btnDangXuat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangXuat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDangXuat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDangXuat.UseSelectable = true;
            this.btnDangXuat.UseTileImage = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblNgayThangHienTai);
            this.Controls.Add(this.lblHienThiUser);
            this.Controls.Add(this.chucNangQLMon);
            this.Controls.Add(this.chucNangQLNhanvien);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.chucNangQLBan);
            this.Controls.Add(this.chucNangQLHoaDon);
            this.Name = "FormChinh";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblHienThiUser;
        private MetroFramework.Controls.MetroTile btnDangXuat;
        private MetroFramework.Controls.MetroTile chucNangQLNhanvien;
        private MetroFramework.Controls.MetroTile chucNangQLHoaDon;
        private MetroFramework.Controls.MetroTile chucNangQLBan;
        private MetroFramework.Controls.MetroTile chucNangQLMon;
        private MetroFramework.Controls.MetroLabel lblNgayThangHienTai;
    }
}