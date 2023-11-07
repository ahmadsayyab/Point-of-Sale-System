using MainLogicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace POS_System_V2
{
    public partial class LoginForm : Form
    {
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUserEmail_Enter(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "Enter email address")
            {
                txtUserEmail.Text = string.Empty;
                txtUserEmail.ForeColor = Color.Black;
            }
        }

        private void txtUserEmail_Leave(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == string.Empty)
            {
                txtUserEmail.Text = "Enter email address";
                txtUserEmail.ForeColor = Color.Gray;
            }
        }

        private void txtUserPassword_Enter(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "Enter password")
            {
                txtUserPassword.Text = string.Empty;
                txtUserPassword.ForeColor = Color.Black;
            }
        }

        private void txtUserPassword_Leave(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == string.Empty)
            {
                txtUserPassword.Text = "Enter password";
                txtUserPassword.ForeColor = Color.Gray;
            }
        }

        private void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showPassCB.Checked;
            switch (check)
            {
                case true:
                    txtUserPassword.UseSystemPasswordChar = false;

                    break;
                default:
                    txtUserPassword.UseSystemPasswordChar = true;

                    break;
            }
        }

        private void linkToSignupForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            this.Hide();
            signup.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(txtUserEmail.Text == "Enter email address" || txtUserPassword.Text == "Enter password")
            {
                MessageBox.Show("Enter data in both fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtUserEmail.Text == string.Empty || txtUserPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter data in both fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (db.Users.Where(read => read.Email == txtUserEmail.Text
                       && read.Password == txtUserPassword.Text).Count() > 0)
                    {
                        HomeScreenForm hs = new HomeScreenForm();
                        this.Hide();
                        hs.Show();
                    }
                    else
                    {
                        MessageBox.Show("Either email or password is incorrect!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
