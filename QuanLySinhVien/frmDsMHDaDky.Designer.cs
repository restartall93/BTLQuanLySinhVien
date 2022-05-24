namespace QuanLySinhVien
{
    partial class frmDsMHDaDky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsMHDaDky));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSMHDky = new System.Windows.Forms.DataGridView();
            this.btnDkyMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(763, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 43);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiem.Location = new System.Drawing.Point(525, 23);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(232, 20);
            this.txtTimkiem.TabIndex = 5;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ khóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDSMHDky
            // 
            this.dgvDSMHDky.AllowUserToAddRows = false;
            this.dgvDSMHDky.AllowUserToDeleteRows = false;
            this.dgvDSMHDky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMHDky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHDky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHDky.Location = new System.Drawing.Point(18, 64);
            this.dgvDSMHDky.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSMHDky.MultiSelect = false;
            this.dgvDSMHDky.Name = "dgvDSMHDky";
            this.dgvDSMHDky.ReadOnly = true;
            this.dgvDSMHDky.RowHeadersWidth = 51;
            this.dgvDSMHDky.RowTemplate.Height = 24;
            this.dgvDSMHDky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHDky.Size = new System.Drawing.Size(830, 436);
            this.dgvDSMHDky.TabIndex = 8;
            // 
            // btnDkyMoi
            // 
            this.btnDkyMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDkyMoi.Image = global::QuanLySinhVien.Properties.Resources.Science_Courses_icon;
            this.btnDkyMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDkyMoi.Location = new System.Drawing.Point(18, 12);
            this.btnDkyMoi.Name = "btnDkyMoi";
            this.btnDkyMoi.Size = new System.Drawing.Size(102, 43);
            this.btnDkyMoi.TabIndex = 6;
            this.btnDkyMoi.Text = "Đăng ký mới";
            this.btnDkyMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDkyMoi.UseVisualStyleBackColor = true;
            this.btnDkyMoi.Click += new System.EventHandler(this.btnDkyMoi_Click);
            // 
            // frmDsMHDaDky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 510);
            this.Controls.Add(this.dgvDSMHDky);
            this.Controls.Add(this.btnDkyMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDsMHDaDky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Môn Học Đã Đăng Ký";
            this.Load += new System.EventHandler(this.frmDsMHDaDky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDkyMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSMHDky;
    }
}