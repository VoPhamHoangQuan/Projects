using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using App = Microsoft.Office.Interop.Excel.Application;


namespace Quản_lý_siêu_thị
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        Employees nv = new Employees();
        
        //hàm fill dữ liệu vào data gridview
        private void fillgrid(SqlCommand command)
        {
            dataGridViewSearchEmployee.ReadOnly = true;
            dataGridViewSearchEmployee.DataSource = nv.GetNV(command);
            dataGridViewSearchEmployee.RowTemplate.Height = 60;
            dataGridViewSearchEmployee.AllowUserToAddRows = false;
            //xử lý hình ảnh
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            piCol = (DataGridViewImageColumn)dataGridViewSearchEmployee.Columns[8];
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            fillgrid(new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien where concat(Idnv,Fname,Lname,Bdate,Gender,Addr,Position,Phone,Usename) like '%" + txtSearch.Text + "%'");
            fillgrid(command);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //if (ComboBoxSort.SelectedItem == "Salary")
            //{
            //    fillgrid(new SqlCommand("SELECT * FROM NV ORDER BY "));
            //}
            //else 
            if (ComboBoxSort.SelectedItem == "First Name")
            {
                fillgrid(new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien ORDER BY Fname"));
            }
            else if (ComboBoxSort.SelectedItem == "Last Name")
            {
                fillgrid(new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien ORDER BY Lname"));
            }
        }

        private void pictureBoxReset_Click(object sender, EventArgs e)
        {
            fillgrid(new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien"));
            txtSearch.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //cách 1 kết nối máy in
            //PrintDialog printDlg = new PrintDialog();
            //PrintDocument printDoc = new PrintDocument();

            //printDoc.DocumentName = "Print Document";
            //printDlg.Document = printDoc;
            //printDlg.AllowSelection = true;
            //printDlg.AllowSomePages = true;

            //if (printDlg.ShowDialog() == DialogResult.OK)
            //    printDoc.Print();

            ///cách print 2 xuất ra màng hình
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSave.SelectedItem == "file txt")
            {
                try
                {
                    SaveFileDialog save = new SaveFileDialog() { Filter = "Text Document|.txt", ValidateNames = true };

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter write = new StreamWriter(File.Create(save.FileName));
                        for (int i = 0; i < dataGridViewSearchEmployee.Rows.Count; i++)
                        {
                            write.Write("Nhân viên " + i);
                            write.Write("\n");
                            write.Write("Mã nhân viên: " + dataGridViewSearchEmployee.Rows[i].Cells[0].Value.ToString());
                            write.Write("\n");
                            write.Write("Họ và tên: " + dataGridViewSearchEmployee.Rows[i].Cells[1].Value.ToString() + " " + dataGridViewSearchEmployee.Rows[i].Cells[2].Value.ToString());
                            write.Write("\n");
                            write.Write("Ngày sinh: "+dataGridViewSearchEmployee.Rows[i].Cells[3].Value.ToString());
                            write.Write("\n");
                            write.Write("Giới tính: "+dataGridViewSearchEmployee.Rows[i].Cells[4].Value.ToString());
                            write.Write("\n");
                            write.Write("Nơi cư trú: "+dataGridViewSearchEmployee.Rows[i].Cells[5].Value.ToString());
                            write.Write("\n");
                            write.Write("Mã quản lý: "+dataGridViewSearchEmployee.Rows[i].Cells[6].Value.ToString());
                            write.Write("\n");
                            write.Write("Vị trí hiện tại: "+dataGridViewSearchEmployee.Rows[i].Cells[7].Value.ToString());
                            write.Write("\n");
                            write.Write("Tài khoản: "+dataGridViewSearchEmployee.Rows[i].Cells[9].Value.ToString());
                            write.Write("\n");
                            write.Write("Số điện thoại: "+dataGridViewSearchEmployee.Rows[i].Cells[11].Value.ToString());
                            write.Write("\n");
                            write.Write("<----------------------------------------------->");
                            write.WriteLine();
                        }
                        write.Dispose();
                        MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conection Failue!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //xuất file word
            else if (comboBoxSave.SelectedItem == "file word")
            {
                //int RowCount = dataGridViewSearchEmployee.Rows.Count;
                //int ColumnCount = dataGridViewSearchEmployee.Columns.Count;
                //Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //int r = 0;

                ////lấy tất cả các hàng + cột
                //for (int i = 0; i <= ColumnCount - 1; i++)
                //{
                //    DataArray[r, i] = dataGridViewSearchEmployee.Columns[i].Name;
                //    for (r = 0; r <= RowCount - 1; r++)
                //    {
                //        DataArray[r, i] = dataGridViewSearchEmployee.Rows[r][i];
                //    }
                //}

                //Word.Document oDoc = new Word.Document();
                //oDoc.Application.Visible = true;
                ////oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                //Microsoft.Office.Interop.Word.Range oRange = oDoc.Content.Application.Selection.Range;
                //String oTemp = "";
                //for (r = 0; r <= RowCount - 1; r++)
                //{
                //    for (int i = 0; i <= ColumnCount - 1; i++)
                //    {
                //        oTemp = oTemp + DataArray[r, i] + "\t";
                //    }
                //}

                //oRange.Text = oTemp;

                //// vẽ len file word
                //object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                //object Format = Word.WdTableFormat.wdTableFormatWeb1;
                //object ApplyBorders = true;
                //object AutoFit = true;

                //object numRow = RowCount as object;
                //object numCol = ColumnCount as object;
                //object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
                //oRange.ConvertToTable(ref Separator,
                //ref numRow, ref numCol, Type.Missing, ref Format,
                //ref ApplyBorders, Type.Missing, Type.Missing, Type.Missing,
                // Type.Missing, Type.Missing, Type.Missing,
                // Type.Missing, ref AutoFit, ref AutoFitBehavior,
                // Type.Missing);

                //oRange.Select();
                //oDoc.Application.Selection.Tables[1].Select();
                //oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                //oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                //oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //oDoc.Application.Selection.InsertRowsAbove(1);
                //oDoc.Application.Selection.Tables[1].Rows[1].Select();

                ////lấy tên cột
                //for (int c = 0; c <= ColumnCount - 1; c++)
                //{
                //    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dt.Columns[c].ColumnName;
                //}

                //oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            }

            //xuất file excel
            else if (comboBoxSave.SelectedItem == "file excel")
            {
                try
                {
                    App app = new App();
                    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);

                    app.Columns.ColumnWidth = 25;   //set độ rộng cho từng cột trong excel
                    //lấy thông tin trên header của data
                    for (int i = 1; i < dataGridViewSearchEmployee.Columns.Count; i++)
                    {
                        app.Cells[1, i] = dataGridViewSearchEmployee.Columns[i - 1].HeaderText;
                    }
                    //lấy dữ liệu bên trong fill vào excel
                    for (int i = 0; i < dataGridViewSearchEmployee.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewSearchEmployee.Columns.Count - 1; j++)
                        {
                            if (dataGridViewSearchEmployee.Rows[i].Cells[j].Value != null)
                            {
                                app.Cells[i + 2, j + 1] = dataGridViewSearchEmployee.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "Danh sách Sản Phẩm";
                    sfd.DefaultExt = ".xlsx";
                    sfd.Filter = "Excel Format (*.xlsx)|*.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conection Failue!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridViewSearchEmployee.Width, this.dataGridViewSearchEmployee.Height);
            dataGridViewSearchEmployee.DrawToBitmap(objBmp, new System.Drawing.Rectangle(0, 0, this.dataGridViewSearchEmployee.Width, this.dataGridViewSearchEmployee.Height));
            e.Graphics.DrawImage(objBmp, 60, 60);
        }
    }
}
