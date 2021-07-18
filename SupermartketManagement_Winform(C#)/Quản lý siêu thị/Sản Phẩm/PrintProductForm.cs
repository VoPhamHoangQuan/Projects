using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using App = Microsoft.Office.Interop.Excel.Application;


namespace Quản_lý_siêu_thị
{
    public partial class PrintProductForm : Form
    {
        public PrintProductForm()
        {
            InitializeComponent();
        }
        Products SP = new Products();


        //hàm fill dữ liệu cho datagridview
        private void fillGrip(SqlCommand command)
        {
            DataGridViewPrintPro.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            DataGridViewPrintPro.RowTemplate.Height = 60;
            DataGridViewPrintPro.DataSource = SP.getSanPham(command);
            piCol = (DataGridViewImageColumn)DataGridViewPrintPro.Columns[7];
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewPrintPro.AllowUserToAddRows = false;


        }

        private void PrintProductForm_Load(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("SELECT * FROM SanPham"));
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
                        for (int i = 0; i < DataGridViewPrintPro.Rows.Count; i++)
                        {
                            write.Write("Sản phẩm " + i);
                            write.Write("\n");
                            write.Write("Mã sản phẩm: " + DataGridViewPrintPro.Rows[i].Cells[0].Value.ToString());
                            write.Write("\n");
                            write.Write("Tên sản phẩm: " + DataGridViewPrintPro.Rows[i].Cells[1].Value.ToString());
                            write.Write("\n");
                            write.Write("HSD: " + DataGridViewPrintPro.Rows[i].Cells[2].Value.ToString());
                            write.Write("\n");
                            write.Write("NSX: " + DataGridViewPrintPro.Rows[i].Cells[3].Value.ToString());
                            write.Write("\n");
                            write.Write("Số lượng còn: " + DataGridViewPrintPro.Rows[i].Cells[4].Value.ToString());
                            write.Write("\n");
                            write.Write("Giá gốc: " + DataGridViewPrintPro.Rows[i].Cells[5].Value.ToString() + "$");
                            write.Write("\n");
                            write.Write("Giá bán: " + DataGridViewPrintPro.Rows[i].Cells[6].Value.ToString() + "$");
                            write.Write("\n");
                            write.Write("Chủng loại: " + DataGridViewPrintPro.Rows[i].Cells[8].Value.ToString());
                            write.Write("\n");
                            write.Write("Hãng: " + DataGridViewPrintPro.Rows[i].Cells[9].Value.ToString());
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
                    for (int i = 1; i < DataGridViewPrintPro.Columns.Count; i++)
                    {
                        app.Cells[1, i] = DataGridViewPrintPro.Columns[i - 1].HeaderText;
                    }
                    //lấy dữ liệu bên trong fill vào excel
                    for (int i = 0; i < DataGridViewPrintPro.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridViewPrintPro.Columns.Count - 1; j++)
                        {
                            if (DataGridViewPrintPro.Rows[i].Cells[j].Value != null)
                            {
                                app.Cells[i + 2, j + 1] = DataGridViewPrintPro.Rows[i].Cells[j].Value.ToString();
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

        //nút in dữ liệu
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
        //sự kiện hổ trợ cách in thứ 2
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.DataGridViewPrintPro.Width, this.DataGridViewPrintPro.Height);
            DataGridViewPrintPro.DrawToBitmap(objBmp, new System.Drawing.Rectangle(0, 0, this.DataGridViewPrintPro.Width, this.DataGridViewPrintPro.Height));
            e.Graphics.DrawImage(objBmp, 60, 60);
        }

        private void btnProChart_Click(object sender, EventArgs e)
        {
            ProductChartForm chartForm = new ProductChartForm();
            chartForm.Show(this);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if(comboBoxManage.SelectedItem =="Tên sản phẩm")
            {
                fillGrip(new SqlCommand("SELECT * FROM SanPham ORDER BY Tensp "));
            }
            else if(comboBoxManage.SelectedItem == "HSD")
            {
                fillGrip(new SqlCommand("SELECT * FROM SanPham ORDER BY Hsd "));
            }
            else if (comboBoxManage.SelectedItem == "NSX")
            {
                fillGrip(new SqlCommand("SELECT * FROM SanPham ORDER BY Nsx "));
            }
            else if (comboBoxManage.SelectedItem == "Giá bán")
            {
                fillGrip(new SqlCommand("SELECT * FROM SanPham ORDER BY Giaban "));
            }
            else
            {
                fillGrip(new SqlCommand("SELECT * FROM SanPham ORDER BY Giagoc "));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBoxManage.SelectedItem = null;
            comboBoxSave.SelectedItem = null;
            fillGrip(new SqlCommand("SELECT * FROM SanPham"));
        }
    }
}
