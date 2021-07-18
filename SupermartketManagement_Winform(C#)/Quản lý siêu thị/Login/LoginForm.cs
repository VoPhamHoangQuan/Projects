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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        //hàm kiểm tra dữ liệu đầu vào
        private bool verif()
        {
            if (txtUsername.Text == "Username")
            {
                MessageBox.Show("Enter Username Please", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtPassword.Text == "Password")
            {
                MessageBox.Show("Enter Password Please", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //else if (RadioButtonKH.Checked == null && RadioButtonNV.Checked == null)
            //{
            //    MessageBox.Show("Please Choise Your Part", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            else
            {
                return true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            if (verif())
            {
                if (RadioButtonGD.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE Usename=@user AND Pass=@pass AND Position ='Director'", db.GetConnection);

                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        CheckPartLoginGlobal.SetGlobalFlagUser(table.Rows[0][7].ToString());
                        NameUserGlobal.SetGlobalNameUser(table.Rows[0][1].ToString() +" "+ table.Rows[0][2].ToString());
                        IdNVGlobal.SetGlobalIdUser(table.Rows[0][0].ToString());
                        MainMenuForm main = new MainMenuForm();
                        main.ShowDialog(this);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (RadioButtonNVCH.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE Usename=@user AND Pass=@pass AND Position = 'Sell Manager'", db.GetConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {

                        CheckPartLoginGlobal.SetGlobalFlagUser(table.Rows[0][7].ToString());
                        NameUserGlobal.SetGlobalNameUser(table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString());
                        IdNVGlobal.SetGlobalIdUser(table.Rows[0][0].ToString());
                        MainMenuForm main = new MainMenuForm();
                        main.ShowDialog(this);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (RadioButtonNVK.Checked){
                    SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE Usename=@user AND Pass=@pass AND Position = 'Store Manager'", db.GetConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {

                        CheckPartLoginGlobal.SetGlobalFlagUser(table.Rows[0][7].ToString());
                        NameUserGlobal.SetGlobalNameUser(table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString());
                        IdNVGlobal.SetGlobalIdUser(table.Rows[0][0].ToString());
                        MainMenuForm main = new MainMenuForm();
                        main.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Choise Your Part", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog(this);
        }



        #region thiết kế giao diện
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        //ẩn hiện mật khẩu
        private void PicBoxSawPassLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void PicBoxSawPassLogin_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
