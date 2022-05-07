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
            LoadMonDk();
        }
        private void LoadMonDk()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDaDKy", lst);
        }

        private void btnDkyMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
