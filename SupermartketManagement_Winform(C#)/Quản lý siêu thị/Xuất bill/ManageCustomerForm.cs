using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class ManageCustomerForm : Form
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
        }
        Customer kh = new Customer();
        
        //Clear màng hình
        private void Clear()
        {
            txtEmployeetId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            pictureBoxManageCustomer.Image = null;
            RadioButtonFemale.Checked = false;
            RadioButtonMale.Checked = false;
            DateTimePickerBDate.Value = DateTime.Now;
        }

        //hàm kiểm tra điều kiện nhập vào
        bool verif()
        {
            if ((txtEmployeetId.Text == "") || (txtFName.Text == "") || (txtLName.Text == "") ||
                (txtAddress.Text == "") || (txtPhone.Text == "") ||
                (pictureBoxManageCustomer.Image == null) || RadioButtonMale.Checked == false && RadioButtonFemale.Checked == false) 

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //fill dữ liệu vào datagridview 
        private void fillGrip()
        {
            dataGridViewManageCustomer.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridViewManageCustomer.RowTemplate.Height = 60;
            dataGridViewManageCustomer.DataSource = kh.GetAllKH();
            piCol = (DataGridViewImageColumn)dataGridViewManageCustomer.Columns[7];
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewManageCustomer.AllowUserToAddRows = false;

            LabelTotal.Text = ("Tổng: " + dataGridViewManageCustomer.Rows.Count);
        }

        //form load
        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            fillGrip();
        }

        //thêm khách hàng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtEmployeetId.Text);
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                DateTime bdate = DateTimePickerBDate.Value;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxManageCustomer.Image.Save(pic, pictureBoxManageCustomer.Image.RawFormat);
                if (verif())
                {
                    if (kh.IdCheck(id))   //kiểm tra không tồn tại nhân viên này thì mới add
                    {
                        if (kh.InsertKH(id, fname, lname, bdate, gender, address, phone, pic))
                        {
                            MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            fillGrip();
                        }
                        else
                        {
                            MessageBox.Show("Insert Employee Unsuccess", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Id Have Been Existed", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill The Empty Information", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Thing Wrong", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Sửa khách hàng
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtEmployeetId.Text);
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            DateTime bdate = DateTimePickerBDate.Value;
            string phone = txtPhone.Text;
            string adrs = txtAddress.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            int born_year = DateTimePickerBDate.Value.Year;
            int this_year = DateTime.Now.Year;
            MemoryStream pic = new MemoryStream();
            pictureBoxManageCustomer.Image.Save(pic, pictureBoxManageCustomer.Image.RawFormat);

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 years", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    if (id == Convert.ToInt32(dataGridViewManageCustomer.CurrentRow.Cells[0].Value))
                    {
                        if (kh.updateKH(id, fname, lname, bdate, gender, phone, adrs, pic))
                        {
                            MessageBox.Show("Employee Infor Update", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            fillGrip();
                        }
                        else
                        {
                            MessageBox.Show("Update Employee Information Unsuccess", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Id Isn't Right", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter Employess's Information Again", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //xóa khách hàng
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int KHID = Convert.ToInt32(txtEmployeetId.Text);
                if (KHID != null)
                {
                    if ((MessageBox.Show("ARE YOU SURE WANT TO DELETE THIS EMPLOYEE", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (!kh.IdCheck(KHID))       //kiểm tra có tồn tại nhân viên thì mới xóa
                        {
                            if (kh.DeleteKH(KHID))
                            {
                                MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                fillGrip();
                            }
                            else
                            {
                                MessageBox.Show("Delete Employee  Unsuccess", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Employee Doesn't Exist", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The ID", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //làm mới datagridview
        private void pictureBoxReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //upload hình ảnh
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.ipg;*.png;*.gif;*.jfif)|*.jpg;*.png;*gif;*jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxManageCustomer.Image = Image.FromFile(opf.FileName);
            }
        }


        //double click vào datagridview
        private void dataGridViewManageCustomer_DoubleClick(object sender, EventArgs e)
        {
            txtEmployeetId.Text = dataGridViewManageCustomer.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dataGridViewManageCustomer.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dataGridViewManageCustomer.CurrentRow.Cells[2].Value.ToString();
            DateTimePickerBDate.Value = (DateTime)dataGridViewManageCustomer.CurrentRow.Cells[3].Value;
            if (dataGridViewManageCustomer.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
            txtAddress.Text = dataGridViewManageCustomer.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dataGridViewManageCustomer.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridViewManageCustomer.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxManageCustomer.Image = Image.FromStream(picture);
            Show();
        }


        #region Ràng buộc dữ liệu đầu vào
        //chỉ cho số không cho chữ
        //char.IsDigit(e.KeyChar) kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về true nếu mà số

        //Char.IsContro(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển (các phím mũi tên
        //,Delete,Insert,backspace,space bar) hay không, mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.

        //e.Handled Chặn ký tự nhập vào
        private void txtEmployeetId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //chỉ cho chữ không cho số
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
