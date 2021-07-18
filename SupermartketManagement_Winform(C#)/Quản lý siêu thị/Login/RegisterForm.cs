using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        //hàm kiểm tra dữ liệu vào
        private bool verif()
        {
            if (txtRegisterUsername.Text == "Username")
            {
                MessageBox.Show("Enter Username Please", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtRegisterPassword.Text == "Password")
            {
                MessageBox.Show("Enter Password Please", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtRegisterConfirmPassword.Text == "Confirm Password")
            {
                MessageBox.Show("Enter Confirm Password Please", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtRegisterConfirmPassword.Text != txtRegisterPassword.Text)
            {
                MessageBox.Show("Your Confirm Password Incorectly!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        //hàm clear 
        private void clear()
        {
            txtRegisterUsername.Text = "Username";
            txtRegisterPassword.Text = "Password";
            txtRegisterConfirmPassword.Text = "Confirm Password";
        }

        //nút sign in
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = user.CountUser()+1;
            int idtemp = 0;
            string uname = txtRegisterUsername.Text;
            string pass = txtRegisterPassword.Text;
            string comfirmpass = txtRegisterConfirmPassword.Text;

            if (verif())
            {
                if (!user.UserExist(uname, pass,idtemp))
                {
                    if (user.InsertUser(id,uname, pass))
                    {
                        MessageBox.Show("Register Success", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Register Fail", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("User Existed !!!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // nút tắt góc phải màng hình
        private void LabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //quay lại màng hình login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm flogin = new LoginForm();
            flogin.Show(this);
        }

        #region thiết kế nút hiển thị password
        private void PicBoxSawPassRegister_MouseEnter(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text != "Password")
            {
                txtRegisterPassword.UseSystemPasswordChar = false;
            }
        }

        private void PicBoxSawPassRegister_MouseLeave(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text != "Password")
            {
                txtRegisterPassword.UseSystemPasswordChar = true;
            }
        }

        private void PicBoxSawConfirmPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtRegisterConfirmPassword.Text != "Confirm Password")
            {
                txtRegisterConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void PicBoxSawConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtRegisterConfirmPassword.Text != "Confirm Password")
            {
                txtRegisterConfirmPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion


        #region phần giao diện username password
        private void txtRegisterUsername_Enter(object sender, EventArgs e)
        {
            if (txtRegisterUsername.Text == "Username")
            {
                txtRegisterUsername.Text = "";
            }
        }

        private void txtRegisterUsername_Leave(object sender, EventArgs e)
        {
            if (txtRegisterUsername.Text == "")
            {
                txtRegisterUsername.Text = "Username";
            }
        }

        private void txtRegisterPassword_Enter(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text == "Password")
            {
                txtRegisterPassword.Text = "";
                txtRegisterPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtRegisterPassword_Leave(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text == "")
            {
                txtRegisterPassword.UseSystemPasswordChar = false;
                txtRegisterPassword.Text = "Password";
            }
        }

        private void txtRegisterConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtRegisterConfirmPassword.Text == "Confirm Password")
            {
                txtRegisterConfirmPassword.Text = "";
                txtRegisterConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtRegisterConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtRegisterConfirmPassword.Text == "")
            {
                txtRegisterConfirmPassword.UseSystemPasswordChar = false;
                txtRegisterConfirmPassword.Text = "Confirm Password";
            }
        }
        #endregion
    }
}
