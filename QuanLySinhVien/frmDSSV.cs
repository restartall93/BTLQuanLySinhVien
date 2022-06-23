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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            //đặt tên cột
            //dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            //dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            //dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày sinh";
            //dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            //dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            //dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            //dgvSinhVien.Columns["email"].HeaderText = "Email";
            //dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();

                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "";
            cl1.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã SV";
            cl2.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Họ tên";
            cl3.ColumnWidth = 21;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày Sinh";
            cl4.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Giới Tính";
            cl5.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Quê Quán";
            cl6.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Địa Chỉ";
            cl7.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Số Điện Thoại";
            cl8.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Email";
            cl9.ColumnWidth = 25;
       

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");
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
                for (int col = 1; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
            //thiết lập vùng dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count ;
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                if (e.ColumnIndex == dgvSinhVien.Columns["btnDelete"].Index)
                {
                    if(MessageBox.Show("Bạn chắc chắn muốn xoá sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + "?", "Xác nhận xoá!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maSV = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                        var sql = "deleteSV";
                        var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@masinhvien",
                                value = maSV
                            }
                        };
                        var result = new Database().ExeCute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xoá sinh viên thành công");
                            LoadDSSV();
                        }
                    }
                }
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("");
            DataColumn col2 = new DataColumn("MaNV");
            DataColumn col3 = new DataColumn("Ho Ten");
            DataColumn col4 = new DataColumn("Ngay Sinh");
            DataColumn col5 = new DataColumn("Gioi Tinh");
            DataColumn col6 = new DataColumn("Que Quan");
            DataColumn col7 = new DataColumn("Dia chi");
            DataColumn col8 = new DataColumn("Dien Thoai");
            DataColumn col9 = new DataColumn("Email");
           

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);

            foreach (DataGridViewRow dtgvRow in dgvSinhVien.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;
                dtrow[8] = dtgvRow.Cells[8].Value;

                dataTable.Rows.Add(dtrow);

            }
            ExportFile(dataTable, "Danh Sách", "Danh Sách Sinh Viên");
        }
    }

}
