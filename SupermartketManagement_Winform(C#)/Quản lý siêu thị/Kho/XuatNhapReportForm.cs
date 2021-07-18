using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App = Microsoft.Office.Interop.Excel.Application;

namespace Quản_lý_siêu_thị
{
    public partial class XuatNhapReportForm : Form
    {
        public XuatNhapReportForm()
        {
            InitializeComponent();
        }

        Storage sp = new Storage();

        private void fillGripReport(SqlCommand command)
        {
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.RowTemplate.Height = 60;
            dataGridViewReport.DataSource = sp.getSanPham(command);
            dataGridViewReport.AllowUserToAddRows = false;
        }

        private void XuatNhapReportForm_Load(object sender, EventArgs e)
        {
            fillGripReport(new SqlCommand("SELECT * FROM NhapXuatKho"));
            LabelReport.Text = "Số giao dịch: " + dataGridViewReport.RowCount;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                sp.ConfirmReport();
                MessageBox.Show("Confirm Success", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillGripReport(new SqlCommand("SELECT * FROM NhapXuatKho"));
                LabelReport.Text = "Số giao dịch: " + dataGridViewReport.RowCount;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Save file excel
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                App app = new App();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);

                app.Columns.ColumnWidth = 25;   //set độ rộng cho từng cột trong excel
                                                //lấy thông tin trên header của data
                for (int i = 1; i < dataGridViewReport.Columns.Count; i++)
                {
                    app.Cells[1, i] = dataGridViewReport.Columns[i - 1].HeaderText;
                }
                //lấy dữ liệu bên trong fill vào excel
                for (int i = 0; i < dataGridViewReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewReport.Columns.Count - 1; j++)
                    {
                        if (dataGridViewReport.Rows[i].Cells[j].Value != null)
                        {
                            app.Cells[i + 2, j + 1] = dataGridViewReport.Rows[i].Cells[j].Value.ToString();
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
}
