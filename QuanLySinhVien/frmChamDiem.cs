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
    public partial class frmChamDiem : Form
    {
        public frmChamDiem(string malophoc, string magv)
        {
            this.malophoc = malophoc;
            this.magv = magv;
            InitializeComponent();
        }
        private string malophoc;
        private string magv;
        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvDSSV.DataSource = new Database().SelectData("dssv", lstPara);
        }
    }
}
