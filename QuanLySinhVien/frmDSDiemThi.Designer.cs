namespace QuanLySinhVien
{
    partial class frmDSDiemThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSDiemThi));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKQHT = new System.Windows.Forms.DataGridView();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQHT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1040, 15);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 42);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(723, 23);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(308, 22);
            this.txtTuKhoa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ khóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKQHT
            // 
            this.dgvKQHT.AllowUserToAddRows = false;
            this.dgvKQHT.AllowUserToDeleteRows = false;
            this.dgvKQHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKQHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKQHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.lanhoc,
            this.gvien,
            this.diemthilan1,
            this.diemthilan2,
            this.diemTB,
            this.ketqua});
            this.dgvKQHT.Location = new System.Drawing.Point(-3, 87);
            this.dgvKQHT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKQHT.Name = "dgvKQHT";
            this.dgvKQHT.ReadOnly = true;
            this.dgvKQHT.RowHeadersWidth = 51;
            this.dgvKQHT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKQHT.Size = new System.Drawing.Size(1164, 585);
            this.dgvKQHT.TabIndex = 10;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã Môn Học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên Môn Học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // lanhoc
            // 
            this.lanhoc.DataPropertyName = "lanhoc";
            this.lanhoc.HeaderText = "Lần Học";
            this.lanhoc.MinimumWidth = 6;
            this.lanhoc.Name = "lanhoc";
            this.lanhoc.ReadOnly = true;
            // 
            // gvien
            // 
            this.gvien.DataPropertyName = "gvien";
            this.gvien.HeaderText = "Giáo Viên";
            this.gvien.MinimumWidth = 6;
            this.gvien.Name = "gvien";
            this.gvien.ReadOnly = true;
            // 
            // diemthilan1
            // 
            this.diemthilan1.DataPropertyName = "diemthilan1";
            this.diemthilan1.HeaderText = "Điểm Thi Lần 1";
            this.diemthilan1.MinimumWidth = 6;
            this.diemthilan1.Name = "diemthilan1";
            this.diemthilan1.ReadOnly = true;
            // 
            // diemthilan2
            // 
            this.diemthilan2.DataPropertyName = "diemthilan2";
            this.diemthilan2.HeaderText = "Điểm Thi Lần 2";
            this.diemthilan2.MinimumWidth = 6;
            this.diemthilan2.Name = "diemthilan2";
            this.diemthilan2.ReadOnly = true;
            // 
            // diemTB
            // 
            this.diemTB.DataPropertyName = "diemTB";
            this.diemTB.HeaderText = "Điểm Trung Bình";
            this.diemTB.MinimumWidth = 6;
            this.diemTB.Name = "diemTB";
            this.diemTB.ReadOnly = true;
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "ketqua";
            this.ketqua.HeaderText = "Kết Quả";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            // 
            // frmDSDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 676);
            this.Controls.Add(this.dgvKQHT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSDiemThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Học Tập";
            this.Load += new System.EventHandler(this.frmDSDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKQHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
    }
}