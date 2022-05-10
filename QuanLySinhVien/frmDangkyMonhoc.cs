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
    public partial class frmDangkyMonhoc : Form
    {
        public frmDangkyMonhoc(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        public string msv;

        private void frmDangkyMonhoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên học phần";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số TC";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";
        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy", lstPara);    
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
