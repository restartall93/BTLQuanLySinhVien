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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectALLGV";
            List<CustomParameter> lsPara = new List<CustomParameter>();
            lsPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa

            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lsPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    //Xác nhận xoá
                    if(MessageBox.Show("Bạn chắc chắn muốn xoá giáo viên: " + dgvDSGV.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + "?",
                        "Xác nhận xoá!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                        var sql = "deleteGV";
                        var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@magiaovien",
                                value = maGV
                            }
                        };
                        var result = new Database().ExeCute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xoá giáo viên thành công");
                            loadDSGV();
                        }
                    }
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }
    }
}
