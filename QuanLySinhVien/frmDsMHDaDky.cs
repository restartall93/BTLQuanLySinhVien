using System;
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
    public partial class frmDsMHDaDky : Form
    {
        private string masv;
        public frmDsMHDaDky(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void frmDsMHDaDky_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                },
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = txtTuKhoa.Text
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDaDKy", lst);

            dgvDSMHDky.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvDSMHDky.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSMHDky.Columns["gvien"].HeaderText = "Giáo Viên";
            dgvDSMHDky.Columns["diemthilan1"].HeaderText = "Điểm Thi Lần 1";
            dgvDSMHDky.Columns["diemthilan2"].HeaderText = "Điểm Thi Lần 2";
            dgvDSMHDky.Columns["daketthuc"].HeaderText = "Đã Kết Thúc";
        }

        private void btnDkyMoi_Click(object sender, EventArgs e)
        {
            new frmDangkyMonhoc(masv).ShowDialog();
            LoadMonDky();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadMonDky();
        }
    }
}
