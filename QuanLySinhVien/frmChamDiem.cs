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

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            // tạo các đối tượng trong excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //tạo mới một excel workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Sinh Viên";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Lần Học";
            cl3.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Điểm Lần 1";
            cl4.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Điểm Lần 2";
            cl5.ColumnWidth = 12;
            


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            //kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Tạo mảng datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            //Chuyển dữ liệu từ Datatable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
            //thiết lập vùng dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;
            //ô điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            //ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            //Lấy vùng dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            //kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("Mã Sinh Viên");
            DataColumn col2 = new DataColumn("Họ Và Tên");
            DataColumn col3 = new DataColumn("Lần Học");
            DataColumn col4 = new DataColumn("Điểm Lần 1");
            DataColumn col5 = new DataColumn("Điểm Lần 2");


            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
           

            foreach (DataGridViewRow dtgvRow in dgvDSSV.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
           

                dataTable.Rows.Add(dtrow);

            }
            ExportFile(dataTable, "Danh Sách", "Danh Sách Sinh Viên Mã Lớp: ");
        }
    }
}
