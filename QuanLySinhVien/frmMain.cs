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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string taikhoan, string loaitk) : this()
        {
            this.Taikhoan = taikhoan;
            this.Loaitk = loaitk;
        }
        public string Taikhoan { get; }
        public string Loaitk { get; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Loaitk))
            {
                return;
            }
            if (Loaitk.Equals("admin"))
            {
                quanLyLopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (Loaitk.Equals("gv"))
                {
                    chucNangToolStripMenuItem.Visible = false;
                }
                else
                {
                    quanLyLopToolStripMenuItem.Visible = false;
                }
            }
            frmWelcome f = new frmWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            AddForm(f);
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsLopHoc f = new frmDsLopHoc();
            AddForm(f);
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDsMHDaDky(Taikhoan);
            AddForm(f);
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSDiemThi(Taikhoan);
            AddForm(f);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap();
            frmDangnhap.ShowDialog();
        }

        private void quanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyLop(Taikhoan);
            AddForm(f);
        }
    }
}
