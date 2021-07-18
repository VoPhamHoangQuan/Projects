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
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        Employees NhanVien = new Employees();

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            fillGrip();
            comboBoxPosition.Items.Add("Director");
            comboBoxPosition.Items.Add("Sell Manager");
            comboBoxPosition.Items.Add("Store Manager");
        }

        //Clear màng hình
        private void Clear()
        {
            txtEmployeetId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtUsename.Text = "";
            txtPass.Text = "";
            txtIdql.Text = "";
            comboBoxPosition.SelectedItem = null;
            pictureBoxManageEmployee.Image = null;
            RadioButtonFemale.Checked = false;
            RadioButtonMale.Checked = false;
            DateTimePickerBDate.Value = DateTime.Now;
            comboBoxPosition.SelectedValue = null;
        }

        //hàm kiểm tra điều kiện nhập vào
        bool verif()
        {
            if ((txtEmployeetId.Text == "") || (txtFName.Text == "") || (txtLName.Text == "") ||
                (txtAddress.Text == "") || (txtPhone.Text == "") || (txtUsename.Text == "") || 
                (txtPass.Text == "") || (comboBoxPosition.SelectedItem == null) ||
                (pictureBoxManageEmployee.Image == null) || RadioButtonMale.Checked == false && RadioButtonFemale.Checked == false) 
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
            dataGridViewManageEmployee.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridViewManageEmployee.RowTemplate.Height = 60;
            dataGridViewManageEmployee.DataSource = NhanVien.GetAllNhanvien();

            piCol = (DataGridViewImageColumn)dataGridViewManageEmployee.Columns[8];
            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewManageEmployee.AllowUserToAddRows = false;
            LabelTotal.Text = ("Số nhân viên: " + dataGridViewManageEmployee.Rows.Count);
        }

        //chọn nhân viên trên datagridview sẽ cập nhật thông tin tương tự trên các textbox
        private void dataGridViewManageEmployee_DoubleClick(object sender, EventArgs e)
        {
            txtEmployeetId.Text = dataGridViewManageEmployee.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dataGridViewManageEmployee.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dataGridViewManageEmployee.CurrentRow.Cells[2].Value.ToString();
            DateTimePickerBDate.Value = (DateTime)dataGridViewManageEmployee.CurrentRow.Cells[3].Value;
            if (dataGridViewManageEmployee.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
            txtAddress.Text = dataGridViewManageEmployee.CurrentRow.Cells[5].Value.ToString();
            txtIdql.Text = dataGridViewManageEmployee.CurrentRow.Cells[6].Value.ToString();
            comboBoxPosition.SelectedItem = dataGridViewManageEmployee.CurrentRow.Cells[7].Value;
            if (dataGridViewManageEmployee.CurrentRow.Cells[8].Value != null) 
            {
                byte[] pic;
                pic = (byte[])dataGridViewManageEmployee.CurrentRow.Cells[8].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxManageEmployee.Image = Image.FromStream(picture);
            }
            txtUsename.Text = dataGridViewManageEmployee.CurrentRow.Cells[9].Value.ToString();
            txtPass.Text = dataGridViewManageEmployee.CurrentRow.Cells[10].Value.ToString();
            txtPhone.Text = dataGridViewManageEmployee.CurrentRow.Cells[11].Value.ToString();
            Show();
        }

        //add thêm nhân viên mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtEmployeetId.Text;
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                DateTime bdate = DateTimePickerBDate.Value;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                string address = txtAddress.Text;
                string idql = txtIdql.Text;
                string phone = txtPhone.Text;
                string position = comboBoxPosition.SelectedItem.ToString();
                string usename = txtUsename.Text;
                string pass = txtPass.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxManageEmployee.Image.Save(pic, pictureBoxManageEmployee.Image.RawFormat);
                if (verif())
                {
                    if (NhanVien.IdCheck(id))   //kiểm tra không tồn tại nhân viên này thì mới add
                    {
                        if (NhanVien.InsertNhanVien(id, fname, lname, bdate, gender, address, idql, position, pic, usename, pass, phone))
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


        //remove nhân viên
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string EmplyeeID = txtEmployeetId.Text;
                if (EmplyeeID != null)
                {
                    if ((MessageBox.Show("ARE YOU SURE WANT TO DELETE THIS EMPLOYEE", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (!NhanVien.IdCheck(EmplyeeID))       //kiểm tra có tồn tại nhân viên thì mới xóa
                        {
                            if (NhanVien.DeleteNhanVien(EmplyeeID))
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


        //edit nhân viên
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtEmployeetId.Text;
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            DateTime bdate = DateTimePickerBDate.Value;
            string phone = txtPhone.Text;
            string usename = txtUsename.Text;
            string pass = txtPass.Text;
            string address = txtAddress.Text;
            string idql = txtIdql.Text;
            string position = comboBoxPosition.SelectedItem.ToString();
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            int born_year = DateTimePickerBDate.Value.Year;
            int this_year = DateTime.Now.Year;
            MemoryStream pic = new MemoryStream();
            pictureBoxManageEmployee.Image.Save(pic, pictureBoxManageEmployee.Image.RawFormat);

            if (((this_year - born_year) < 18) || ((this_year - born_year) > 65))
            {
                MessageBox.Show("The employee age must be from 18 to 100 yearolds", "INVALIDS BIRTH DAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    if (id == dataGridViewManageEmployee.CurrentRow.Cells[0].Value.ToString())
                    {
                        if (NhanVien.updateNhanVien(id, fname, lname, bdate, gender, address, idql, position, pic, usename, pass, phone))
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

        //nút xóa data thừa trên màng hình
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // nút upload hình
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.ipg;*.png;*.gif;*.jfif)|*.jpg;*.png;*gif;*jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxManageEmployee.Image = Image.FromFile(opf.FileName);
            }
        }

        #region Ràng buộc dữ liệu đầu vào
        //chỉ cho số không cho chữ
        //char.IsDigit(e.KeyChar) kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về true nếu mà số

        //Char.IsContro(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển (các phím mũi tên
        //,Delete,Insert,backspace,space bar) hay không, mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.

        //e.Handled Chặn ký tự nhập vào
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //private void txtEmployeetId_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}


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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
