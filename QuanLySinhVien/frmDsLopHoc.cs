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
    public partial class frmDsLopHoc : Form
    {
        public frmDsLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDsLopHoc_Load(object sender, EventArgs e)
        {

        }
        private void loadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSLH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {

        }
    }
}