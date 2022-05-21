﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            //đặt tên cột
            //dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            //dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            //dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày sinh";
            //dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            //dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            //dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            //dgvSinhVien.Columns["email"].HeaderText = "Email";
            //dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();

                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV();
        }
    }

}
