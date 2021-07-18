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
    public partial class StorageManagerForm : Form
    {
        public StorageManagerForm()
        {
            InitializeComponent();
        }

        Storage sp = new Storage();


        //hàm clear màng hình
        private void Clear()
        {
            txtIdspS.Text = "";
            txtNameProS.Text = "";
            txtKindProS.Text = "";
            txtBrandS.Text = "";
            txtSlS.Text = "";
            txtOriginPriceS.Text = "";
            txtSellPriceS.Text = "";
            PictureBoxImageSpS.Image = null;
            DateTimePickerHsdS.Value = DateTime.Now;
            DateTimePickerNsxS.Value = DateTime.Now;
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
            if ((txtBrandS.Text == "") || (txtNameProS.Text == "") || (txtKindProS.Text == "")
                || (txtIdspS.Text == "") || (PictureBoxImageSpS.Image == null)
                || (txtSlS.Text == "") || (txtOriginPriceS.Text == "") || (txtSellPriceS.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void StorageManagerForm_Load(object sender, EventArgs e)
        {
            txtIdspS.ReadOnly = true;
            txtNameProS.ReadOnly = true;
            txtKindProS.ReadOnly = true;
            txtBrandS.ReadOnly = true;
            txtSlS.ReadOnly = true;
            txtOriginPriceS.ReadOnly = true;
            txtSellPriceS.ReadOnly = true;
            DateTimePickerHsdS.Enabled = false;
            DateTimePickerNsxS.Enabled = false;

            fillGrip(new SqlCommand("SELECT SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang,Kho.sltrongkho FROM SanPham INNER JOIN Kho ON SanPham.Idsp = Kho.Idsp"));
        }


       

        private void pictureBoxResetS_Click(object sender, EventArgs e)
        {
            Clear();
            fillGrip(new SqlCommand("SELECT SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang,Kho.sltrongkho FROM SanPham INNER JOIN Kho ON SanPham.Idsp = Kho.Idsp;"));
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("select * from SanPham where concat(Idsp,Tensp,Hsd,Nsx,Sltrenke,Giagoc,Giaban,Loaisp,Hang) like '%" + txtSearch.Text + "%'");
            //fillGrip(command);
        }

       

        //chọn thông tin sản phẩm trên datagridview sẽ cập nhật trên các textbox
        private void DataGridViewStorage_DoubleClick(object sender, EventArgs e)
        {
            txtIdspS.Text = DataGridViewStorage.CurrentRow.Cells[0].Value.ToString();
            txtNameProS.Text = DataGridViewStorage.CurrentRow.Cells[1].Value.ToString();
            DateTimePickerHsdS.Value = (DateTime)DataGridViewStorage.CurrentRow.Cells[2].Value;
            DateTimePickerNsxS.Value = (DateTime)DataGridViewStorage.CurrentRow.Cells[3].Value;
            txtSlS.Text = DataGridViewStorage.CurrentRow.Cells[10].Value.ToString();
            txtOriginPriceS.Text = DataGridViewStorage.CurrentRow.Cells[5].Value.ToString();
            txtSellPriceS.Text = DataGridViewStorage.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridViewStorage.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxImageSpS.Image = Image.FromStream(picture);
            txtKindProS.Text = DataGridViewStorage.CurrentRow.Cells[8].Value.ToString();
            txtBrandS.Text = DataGridViewStorage.CurrentRow.Cells[9].Value.ToString();
            Show();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStorageManagerForm update = new UpdateStorageManagerForm();
            update.Show(this);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            OrderStorageForm order = new OrderStorageForm();
            order.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportStorageForm export = new ExportStorageForm();
            export.Show();

      
        }
    }
}
