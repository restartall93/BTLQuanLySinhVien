﻿namespace QuanLySinhVien
{
    partial class frmDSSV
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
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(951, 31);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(100, 28);
            this.btnThemmoi.TabIndex = 8;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Location = new System.Drawing.Point(843, 33);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTukhoa.Location = new System.Drawing.Point(588, 33);
            this.txtTukhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(245, 22);
            this.txtTukhoa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ khóa";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.hoten,
            this.nsinh,
            this.gt,
            this.quequan,
            this.diachi,
            this.dienthoai,
            this.email,
            this.btnDelete});
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 98);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1067, 455);
            this.dgvSinhVien.TabIndex = 9;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "Mã Sinh Viên";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Và Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // nsinh
            // 
            this.nsinh.DataPropertyName = "nsinh";
            this.nsinh.HeaderText = "Ngày Sinh";
            this.nsinh.MinimumWidth = 6;
            this.nsinh.Name = "nsinh";
            this.nsinh.ReadOnly = true;
            // 
            // gt
            // 
            this.gt.DataPropertyName = "gt";
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.ReadOnly = true;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê Quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện Thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSSV";
            this.Load += new System.EventHandler(this.frmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}