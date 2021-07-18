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
    public partial class OrderStorageForm : Form
    {
        public OrderStorageForm()
        {
            InitializeComponent();
        }

        Storage sp = new Storage();


        //hàm clear màng hình
        private void Clear()
        {
            txtIdspOrder.Text = "";
            txtSlOrder.Text = "";
            DateTimePickerNhapKho.Value = DateTime.Today;
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang, Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp "));
        }

        //fill dữ liệu vào datagridview 
        private void fillGrip(SqlCommand command)
        {
            DataGridViewOrder.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            DataGridViewOrder.RowTemplate.Height = 60;
            DataGridViewOrder.DataSource = sp.getSanPham(command);
            piCol = (DataGridViewImageColumn)(DataGridViewOrder.Columns[7]);
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewOrder.AllowUserToAddRows = false;
            LabelTotal.Text = ("Số Sản Phẩm: " + DataGridViewOrder.Rows.Count);
        }

        //hàm kiểm tra dữ liệu nhập vào
        bool verif()
        {
            if (txtSlOrder.Text == "" || txtIdspOrder.Text == "")  
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
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("select * from SanPham where concat(Idsp,Tensp,Hsd,Nsx,Sltrenke,Giagoc,Giaban,Loaisp,Hang) like '%" + txtSearch.Text + "%'");
            //fillGrip(command);
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

        private void OrderStorageForm_Load(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang,Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
            txtIdspOrder.ReadOnly = true;
        }

        private void DataGridViewOrder_DoubleClick_1(object sender, EventArgs e)
        {
            txtIdspOrder.Text = DataGridViewOrder.CurrentRow.Cells[0].Value.ToString();
            txtSlOrder.Text = DataGridViewOrder.CurrentRow.Cells[10].Value.ToString();
            Show();
        }


        //nút order
        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string idnhap = txtIdNhapKho.Text;
                    string idsp = txtIdspOrder.Text;
                    string idql = IdNVGlobal.FlagUserId;
                    float slNhapKho = float.Parse(txtSlOrder.Text);
                    DateTime ngaynhap = DateTimePickerNhapKho.Value;
                    float slXuatKho = 0;
                    DateTime ngayxuat = DateTime.Today;

                    if (sp.IdNhapCheck(idnhap))
                    {
                        if (sp.OrderSp(idnhap, idsp, idql, slNhapKho, ngaynhap, slXuatKho, ngayxuat))
                        {
                            GlobalIDNhapXuat.SetGlobalIdnhapxuat(idnhap);             
                            ConfirmOrderForm confirm = new ConfirmOrderForm();
                            confirm.ShowDialog(this);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MessageBox.Show("This Id nhập xuất Has Been Existed", "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //DataGridViewOrder = null;
                fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang,Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp"));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBoxResetS_Click_1(object sender, EventArgs e)
        {
            fillGrip(new SqlCommand("select SanPham.Idsp, Tensp, Hsd,Nsx,Sltrenke, Giagoc,Giaban, Picture, Loaisp,Hang,Kho.Sltrongkho from SanPham inner join Kho on SanPham.Idsp = Kho.Idsp ORDER BY Sltrongkho"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
