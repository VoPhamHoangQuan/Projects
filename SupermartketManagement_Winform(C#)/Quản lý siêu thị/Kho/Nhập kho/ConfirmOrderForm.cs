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
    public partial class ConfirmOrderForm : Form
    {
        public ConfirmOrderForm()
        {
            InitializeComponent();
        }

        Storage sp = new Storage();

        //hàm kiểm tra dữ liệu nhập vào
        bool verif()
        {
            if (txtIdNhapKho.Text == "" || txtIdspOrder.Text == "" || txtIdql.Text == "" || txtSlOrder.Text == "") 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ConfirmOrderForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select Idnhapxuat,Idqlkho,Idsp,Slnhapkho,Ngaynhapkho from NhapXuatKho Where Idnhapxuat = @cidnhapxuat");
            command.Parameters.Add("@cidnhapxuat", SqlDbType.NChar).Value = GlobalIDNhapXuat.Idnhapxuat;
            table = sp.getSanPham(command);


            txtIdNhapKho.Text = table.Rows[0][0].ToString();
            txtIdql.Text = table.Rows[0][1].ToString();
            txtIdspOrder.Text = table.Rows[0][2].ToString();
            txtSlOrder.Text = table.Rows[0][3].ToString();
            DateTimePickerNhapKho.Value = (DateTime)table.Rows[0][4];

            txtIdNhapKho.ReadOnly = true;
            txtIdql.ReadOnly = true;
            txtIdspOrder.ReadOnly = true;
            txtSlOrder.ReadOnly = true;
            DateTimePickerNhapKho.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    DataTable table2 = new DataTable();
                    SqlCommand command = new SqlCommand("select Sltrongkho from Kho where Idsp = @cidspnhap");
                    command.Parameters.Add("@cidspnhap", SqlDbType.NChar).Value = txtIdspOrder.Text;
                    table2 = sp.getSanPham(command);

                    string idsp = txtIdspOrder.Text;
                    float sltrongkho = float.Parse(txtSlOrder.Text) + float.Parse(table2.Rows[0][0].ToString());
                    if (sp.ConfirmSp(idsp, sltrongkho))
                    {
                        MessageBox.Show("Confirm successfully", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
