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
    public partial class frmDSDiemThi : Form
    {
        public frmDSDiemThi(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void frmDSDiemThi_Load(object sender, EventArgs e)
        {
            LoadKQHT();
        }
        public string getKetQua(float diemTB)
        {
            if (diemTB>=4)
            {
                return "Đạt";
            }
            else
            {
                return "Trượt";
            }
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            DataTable dt = new Database().SelectData("tracuudiem", lstPara);
            DataColumn col9 = new DataColumn("ketqua");
            dt.Columns.Add(col9);
            foreach (DataRow r in dt.Rows)
            {
                r["ketqua"] = getKetQua(float.Parse(r["diemTB"].ToString()));
            }

            dgvKQHT.DataSource = dt;
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã Môn Học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần Học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giáo Viên";
            dgvKQHT.Columns["diemthilan1"].HeaderText = "Điểm Thi Lần 1";
            dgvKQHT.Columns["diemthilan2"].HeaderText = "Điểm Thi Lần 2";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }
    }
}
