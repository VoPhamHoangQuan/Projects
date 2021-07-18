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

namespace Quản_lý_siêu_thị
{
    public partial class ManageProductForm : Form
    {
        public ManageProductForm()
        {
            InitializeComponent();
        }

        Products sp = new Products();

       
        //hàm clear màng hình
        private void Clear()
        {
            txtIdsp.Text = "";
            txtNamePro.Text = "";
            txtKindPro.Text = "";
            txtBrand.Text = "";
            txtSl.Text = "";
            txtOriginPrice.Text = "";
            txtSellPrice.Text = "";
            PictureBoxImage.Image = null;
            DateTimePickerHsd.Value = DateTime.Now;
            DateTimePickerNsx.Value = DateTime.Now;
            txtSearch.Text = "";
        }

        //fill dữ liệu vào datagridview 
        private void fillGrip(SqlCommand command)
        {
            DataGridViewPro.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            DataGridViewPro.RowTemplate.Height = 60;
            DataGridViewPro.DataSource = sp.getSanPham(command);
            piCol = (DataGridViewImageColumn)(DataGridViewPro.Columns[7]);
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewPro.AllowUserToAddRows = false;

            LabelTotal.Text = ("Số Sản Phẩm: " + DataGridViewPro.Rows.Count);
        }

        //hàm kiểm tra dữ liệu nhập vào
        bool verif()
        {
            if ((txtBrand.Text == "") || (txtNamePro.Text == "") || (txtKindPro.Text == "")
                || (txtIdsp.Text == "") || (PictureBoxImage.Image == null)
                || (txtSl.Text == "") || (txtOriginPrice.Text == "") || (txtSellPrice.Text == ""))  
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        private void ManageProductForm_Load(object sender, EventArgs e)
        {

            fillGrip(new SqlCommand("SELECT * FROM SanPham"));
        }

        //nút add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string idsp = txtIdsp.Text;
                    string tensp = txtNamePro.Text;
                    DateTime hsd = DateTimePickerHsd.Value;
                    DateTime nsx = DateTimePickerNsx.Value;
                    float sl = float.Parse(txtSl.Text);
                    float giagoc = float.Parse(txtOriginPrice.Text);
                    float giaban = float.Parse(txtSellPrice.Text);
                    MemoryStream pic = new MemoryStream();
                    PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                    string loaisp = txtKindPro.Text;
                    string hang = txtBrand.Text;
                    if (sp.IdCheck(idsp))
                    {
                        

                        if (sp.insertSanPham(idsp,tensp,hsd,nsx,sl,giagoc,giaban,pic,loaisp,hang))
                        {
                            MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This id have been existed", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //dataGridView1 = null;
                fillGrip(new SqlCommand("SELECT * FROM SanPham"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //nút edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string idsp = txtIdsp.Text;
                    string tensp = txtNamePro.Text;
                    DateTime hsd = DateTimePickerHsd.Value;
                    DateTime nsx = DateTimePickerNsx.Value;
                    float sl = float.Parse(txtSl.Text);
                    float giagoc = float.Parse(txtOriginPrice.Text);
                    float giaban = float.Parse(txtSellPrice.Text);
                    MemoryStream pic = new MemoryStream();
                    PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                    string loaisp = txtKindPro.Text;
                    string hang = txtBrand.Text;
                    try
                    {
                        PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                        if (sp.updateSanPham(idsp, tensp, hsd, nsx, sl, giagoc, giaban, pic, loaisp, hang))
                        {
                            MessageBox.Show("Product Infor Update", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                fillGrip(new SqlCommand("SELECT * FROM SanPham"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //nút delete
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = (txtIdsp.Text);
                if (ID != null)
                {
                    if ((MessageBox.Show("ARE YOU SURE WANT TO DELETE THIS PRODUCT", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (sp.deleteSanPham(ID))
                        {
                            MessageBox.Show("Product Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            fillGrip(new SqlCommand("SELECT * FROM SanPham"));
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


        //chọn thông tin sản phẩm trên datagridview sẽ cập nhật trên các textbox
        private void DataGridViewPro_DoubleClick(object sender, EventArgs e)
        {
            txtIdsp.Text = DataGridViewPro.CurrentRow.Cells[0].Value.ToString();
            txtNamePro.Text = DataGridViewPro.CurrentRow.Cells[1].Value.ToString();
            DateTimePickerHsd.Value = (DateTime)DataGridViewPro.CurrentRow.Cells[2].Value;
            DateTimePickerNsx.Value = (DateTime)DataGridViewPro.CurrentRow.Cells[3].Value;
            txtSl.Text = DataGridViewPro.CurrentRow.Cells[4].Value.ToString();
            txtOriginPrice.Text = DataGridViewPro.CurrentRow.Cells[5].Value.ToString();
            txtSellPrice.Text = DataGridViewPro.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridViewPro.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxImage.Image = Image.FromStream(picture);
            txtKindPro.Text = DataGridViewPro.CurrentRow.Cells[8].Value.ToString();
            txtBrand.Text = DataGridViewPro.CurrentRow.Cells[9].Value.ToString();
            Show();
        }

        //nút upload hình ảnh lên
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.ipg;*.png;*.gif;*.jfif)|*.jpg;*.png;*gif;*jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

       
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from SanPham where concat(Idsp,Tensp,Hsd,Nsx,Sltrenke,Giagoc,Giaban,Loaisp,Hang) like '%" + txtSearch.Text + "%'");
            fillGrip(command);
        }

        private void pictureBoxReset_Click(object sender, EventArgs e)
        {
            Clear();
            fillGrip(new SqlCommand("SELECT * FROM SanPham"));
        }

        #region Ràng buộc dữ liệu đầu vào
        //chỉ cho số không cho chữ
        //char.IsDigit(e.KeyChar) kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về true nếu mà số

        //Char.IsContro(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển (các phím mũi tên
        //,Delete,Insert,backspace,space bar) hay không, mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.

        //e.Handled Chặn ký tự nhập vào
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //chỉ cho chữ không cho số
        private void txtKindPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
