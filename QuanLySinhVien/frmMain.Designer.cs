﻿namespace QuanLySinhVien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.chucNangToolStripMenuItem,
            this.quanLyLopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 422);
            this.pnlContent.TabIndex = 1;
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::QuanLySinhVien.Properties.Resources.icon_system_1;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.giaoVienToolStripMenuItem,
            this.lopHocToolStripMenuItem});
            this.quanLyToolStripMenuItem.Image = global::QuanLySinhVien.Properties.Resources.Data_List_icon;
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sinhVienToolStripMenuItem.Text = "Sinh Viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.monHocToolStripMenuItem.Text = "Môn Học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem
            // 
            this.giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            this.giaoVienToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.giaoVienToolStripMenuItem.Text = "Giáo Viên";
            this.giaoVienToolStripMenuItem.Click += new System.EventHandler(this.giaoVienToolStripMenuItem_Click);
            // 
            // lopHocToolStripMenuItem
            // 
            this.lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            this.lopHocToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.lopHocToolStripMenuItem.Text = "Lớp Học";
            this.lopHocToolStripMenuItem.Click += new System.EventHandler(this.lopHocToolStripMenuItem_Click);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangKyToolStripMenuItem,
            this.traCuuDiemToolStripMenuItem});
            this.chucNangToolStripMenuItem.Image = global::QuanLySinhVien.Properties.Resources.icon_function;
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.chucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // dangKyToolStripMenuItem
            // 
            this.dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            this.dangKyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangKyToolStripMenuItem.Text = "Đăng Ký Môn Học";
            this.dangKyToolStripMenuItem.Click += new System.EventHandler(this.dangKyToolStripMenuItem_Click);
            // 
            // traCuuDiemToolStripMenuItem
            // 
            this.traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            this.traCuuDiemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traCuuDiemToolStripMenuItem.Text = "Tra Cứu Điểm";
            this.traCuuDiemToolStripMenuItem.Click += new System.EventHandler(this.traCuuDiemToolStripMenuItem_Click);
            // 
            // quanLyLopToolStripMenuItem
            // 
            this.quanLyLopToolStripMenuItem.Image = global::QuanLySinhVien.Properties.Resources.icon_data;
            this.quanLyLopToolStripMenuItem.Name = "quanLyLopToolStripMenuItem";
            this.quanLyLopToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.quanLyLopToolStripMenuItem.Text = "Quản Lý Lớp";
            this.quanLyLopToolStripMenuItem.Click += new System.EventHandler(this.quanLyLopToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLopToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}

