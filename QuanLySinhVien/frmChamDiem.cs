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

        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            LoadDSSV();
            dgvDSSV.Columns["masinhvien"].HeaderText = "MSV"; //column index = 0 -- chỉ số cột
            dgvDSSV.Columns["hoten"].HeaderText = "Họ và tên";//column index = 1
            dgvDSSV.Columns["lanhoc"].HeaderText = "Lần học";//columnindex = 2
            dgvDSSV.Columns["diemthilan1"].HeaderText = "Điểm lần 1";//column index = 3
            dgvDSSV.Columns["diemthilan2"].HeaderText = "Điểm lần 2";//column index = 4
            for (int i = 1; i<=2; i++)
            {
                dgvDSSV.Columns[i].ReadOnly = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn muốn lưu bảng điểm?", "Xác nhận thao tác", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var db = new Database();
                List<CustomParameter> lstPara;
                int chk = 1;
                foreach(DataGridViewRow r in dgvDSSV.Rows)
                {
                    lstPara = new List<CustomParameter>();

                    lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@magiaovien",
                        value = magv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = malophoc
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = r.Cells["masinhvien"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@diemlan1",
                        value = r.Cells["diemthilan1"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@diemlan2",
                        value = r.Cells["diemthilan2"].Value.ToString()
                    });
                    //thực thi truy vấn
                    chk = db.ExeCute("chamdiem", lstPara);
                    if(chk != 1) //nếu chấm điểm thất bại
                    {
                        MessageBox.Show("Chấm điểm thất bại");
                        break;
                    }
                }
                if(chk == 1)
                {
                    MessageBox.Show("Lưu bảng điểm thành công");
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn thực sự muốn đóng lớp học phần này?","Xác thực thao tác", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@magiaovien",
                        value = magv,
                    },
                    new CustomParameter()
                    {
                        key = "@malophoc",
                        value = malophoc,
                    }
                };
                var rs = new Database().ExeCute("ketthuchocphan", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Kết thúc học phần thành công!");
                    this.Dispose();
                }

            }
        }
    }
}
