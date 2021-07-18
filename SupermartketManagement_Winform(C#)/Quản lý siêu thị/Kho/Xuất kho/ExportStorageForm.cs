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

namespace Quản_lý_siêu_thị
{
    public partial class ExportStorageForm : Form
    {
        public ExportStorageForm()
        {
            InitializeComponent();
        }

        Storage sp = new Storage();

        //fill dữ liệu vào datagridview 
        private void fillGrip(SqlCommand command)
        {
            dataGridViewExport.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridViewExport.RowTemplate.Height = 60;
            dataGridViewExport.DataSource = sp.getSanPham(command);
            piCol = (DataGridViewImageColumn)(dataGridViewExport.Columns[7]);
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewExport.AllowUserToAddRows = false;
            LabelTotal.Text = ("Số Sản Phẩm: " + dataGridViewExport.Rows.Count);
        }

        //hàm clear màng hình
        private void Clear()
        {
            txtIdspXuat.Text = "";
            txtSlCuahang.Text = "";
            txtSlKho.Text = "";
            txtSlXuat.Text = "";
            txtIdXuat.Text = "";
            ; dateTimePickerXuat.Value = DateTime.Today;
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang, Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp "));
        }

        bool verif()
        {
            if ((txtIdspXuat.Text == "") || (txtSlCuahang.Text == "") || (txtSlKho.Text == "")
                || (txtSlXuat.Text == "") || (txtIdXuat.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ExportStorageForm_Load(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang, Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
            txtIdspXuat.ReadOnly = true;
            txtSlCuahang.ReadOnly = true;
            txtSlKho.ReadOnly = true;
        }

        private void dataGridViewExport_DoubleClick(object sender, EventArgs e)
        {
            txtIdspXuat.Text = dataGridViewExport.CurrentRow.Cells[0].Value.ToString();
            txtSlCuahang.Text = dataGridViewExport.CurrentRow.Cells[4].Value.ToString();
            txtSlKho.Text = dataGridViewExport.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string idnhapxuat = txtIdXuat.Text;
                    string idsp = txtIdspXuat.Text;
                    float slXuat = float.Parse(txtSlXuat.Text);
                    string idql = IdNVGlobal.FlagUserId;
                    float slNhap = 0;
                    DateTime ngaynhap = DateTime.Today.Date;
                    DateTime ngayxuat = (DateTime)dateTimePickerXuat.Value;

                    if (sp.IdNhapCheck(idnhapxuat))
                    {
                        if (sp.ReportExportSp(idnhapxuat, idsp, idql, slNhap, ngaynhap, slXuat, ngayxuat))
                        {
                            ConfirmExportForm confirm = new ConfirmExportForm();
                            confirm.ShowDialog();
                            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang, Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Export Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MessageBox.Show("This Id nhập xuất Has Been Existed", "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Export Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Export Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBoxResetS_Click(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang, Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
        }
    }
}
