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
    public partial class ConfirmExportForm : Form
    {
        public ConfirmExportForm()
        {
            InitializeComponent();
        }


        Storage sp = new Storage();

        //hàm kiểm tra dữ liệu nhập vào
        bool verif()
        {
            if (txtIdql.Text == "" || txtIdspExport.Text == "" || txtIdXuatkho.Text == "" || txtSlExport.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ConfirmExportForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = sp.getSanPham(new SqlCommand("select Idnhapxuat,Idqlkho,Idsp,Slxuatkho,Ngayxuatkho from NhapXuatKho "));
            int i = table.Rows.Count - 1;

            txtIdspExport.Text = table.Rows[i][2].ToString();
            txtIdql.Text = IdNVGlobal.FlagUserId;
            txtIdXuatkho.Text = table.Rows[i][0].ToString();
            txtSlExport.Text = table.Rows[i][3].ToString();
            DateTimePickerXuatKho.Value = (DateTime)table.Rows[i][4];

            txtIdql.ReadOnly = true;
            txtIdspExport.ReadOnly = true;
            txtIdXuatkho.ReadOnly = true;
            txtSlExport.ReadOnly = true;
            DateTimePickerXuatKho.Enabled = false;
        }


        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    DataTable table2 = new DataTable();
                    SqlCommand command = new SqlCommand("select Kho.Sltrongkho, SanPham.Sltrenke from Kho inner join SanPham on Kho.Idsp = SanPham.Idsp where Kho.Idsp = @cidspE");
                    command.Parameters.Add("@cidspE", SqlDbType.NChar).Value = txtIdspExport.Text;
                    table2 = sp.getSanPham(command);

                    string idsp = txtIdspExport.Text;
                    float sltrenke = float.Parse(txtSlExport.Text) + float.Parse(table2.Rows[0][1].ToString());
                    float sltrongkho = float.Parse(table2.Rows[0][0].ToString()) - float.Parse(txtSlExport.Text);

                    if (sp.ConfirmExportSp(idsp, sltrenke) && sp.ExportSp(idsp, sltrongkho))
                    {
                        MessageBox.Show("Confirm successfully", "Export Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Export Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

     
    }
}
