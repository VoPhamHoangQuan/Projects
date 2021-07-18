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
    public partial class UpdateStorageManagerForm : Form
    {
        public UpdateStorageManagerForm()
        {
            InitializeComponent();
        }

            Storage sp = new Storage();


        //hàm clear màng hình
        private void Clear()
        {
            txtIdspS.Text = "";
        }

        //fill dữ liệu vào datagridview 
        private void fillGrip(SqlCommand command)
        {
            DataGridViewStorage.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            DataGridViewStorage.RowTemplate.Height = 60;
            DataGridViewStorage.DataSource = sp.getSanPham(command);
            piCol = (DataGridViewImageColumn)(DataGridViewStorage.Columns[7]);
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewStorage.AllowUserToAddRows = false;
            LabelTotal.Text = ("Số Sản Phẩm: " + DataGridViewStorage.Rows.Count);
        }

        //hàm kiểm tra dữ liệu nhập vào
        bool verif()
        {
            if ((txtIdspS.Text == "") || (txtSlS.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        
        private void pictureBoxResetS_Click(object sender, EventArgs e)
        {
            Clear();
            fillGrip(new SqlCommand("select * from SanPham where SanPham.Idsp not in (select Kho.Idsp from Kho)"));
        }


        private void UpdateStorageManagerForm_Load(object sender, EventArgs e)
        {
            txtIdspS.ReadOnly = true;
            txtSlS.ReadOnly = true;
            fillGrip(new SqlCommand("select * from SanPham where SanPham.Idsp not in (select Kho.Idsp from Kho)"));

        }

        //chọn thông tin sản phẩm trên datagridview sẽ cập nhật trên các textbox
        private void DataGridViewStorage_DoubleClick(object sender, EventArgs e)
        {
            txtIdspS.Text = DataGridViewStorage.CurrentRow.Cells[0].Value.ToString();
            txtSlS.Text = "0";
            Show();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string idsp = txtIdspS.Text;
                    float sl = float.Parse(txtSlS.Text);
                    if (sp.IdCheck(idsp))
                    {
                        if (sp.importSpStore(idsp, sl))
                        {
                            MessageBox.Show("New Product Added", "Update Product In Storage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Update Product In Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This id have been existed", "Update Product In Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Product In Storage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //DataGridViewStorage = null;
                fillGrip(new SqlCommand("select * from SanPham where SanPham.Idsp not in (select Kho.Idsp from Kho)"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ID = (txtIdspS.Text);
                if (ID != null)
                {
                    if ((MessageBox.Show("ARE YOU SURE WANT TO DELETE THIS PRODUCT", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (sp.deleteSpStore(ID))
                        {
                            MessageBox.Show("Product Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            fillGrip(new SqlCommand("select * from SanPham where SanPham.Idsp not in (select Kho.Idsp from Kho)"));
                        }
                        else
                        {
                            MessageBox.Show("Delete Product Unsuccess", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter ID Please", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdate.SelectedItem =="Sản phẩm trong kho")
            {
                fillGrip(new SqlCommand("SELECT SanPham.Idsp, Tensp, Hsd, Nsx, Sltrenke, Giagoc, Giaban, Picture, Loaisp, Hang FROM SanPham INNER JOIN Kho ON SanPham.Idsp = Kho.Idsp"));
            }
            else
            {
                fillGrip(new SqlCommand("select * from SanPham where SanPham.Idsp not in (select Kho.Idsp from Kho)"));
            }
                
        }

        private void pictureBoxResetS_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
