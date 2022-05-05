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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            //load dữ liệu cho 2 combobox môn học và giáo viên
            cbbMonhoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc";
            cbbMonhoc.ValueMember = "mamonhoc";
            cbbMonhoc.SelectedIndex = -1;

            cbbGiaoVien.DataSource = db.SelectData("selectAllGV", lst);
            cbbGiaoVien.DisplayMember = "hoten";
            cbbGiaoVien.ValueMember = "magiaovien";
            cbbGiaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc'" + malophoc + "'");
                cbbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";


            if(cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if(cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }

            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString()
            });

            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbbGiaoVien.SelectedValue.ToString()
            });

            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }
    }
}
