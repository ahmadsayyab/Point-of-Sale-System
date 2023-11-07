using MainLogicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_V2
{

    public partial class SignupForm : Form
    {
        string email_pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        string pass_pattern = @"(?=^.{8,}$)((?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        User model = new User();
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
        public SignupForm()
        {
            InitializeComponent();
        }

      
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter full name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Focus();
                errorProvider1.SetError(this.txtUserName, "Enter your full name!!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 32)
            {
                // Allow space (ASCII code 32)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void cmbUserGender_Enter(object sender, EventArgs e)
        {
            if (cmbUserGender.Text == "Select gender")
            {
                cmbUserGender.Text = "";
                cmbUserGender.ForeColor = Color.Black;
            }
        }

        private void cmbUserGender_Leave(object sender, EventArgs e)
        {
            if (cmbUserGender.SelectedItem == null)
            {
                cmbUserGender.Focus();
                errorProvider2.SetError(this.cmbUserGender, "Select your gender!!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtUserAge_Leave(object sender, EventArgs e)
        {
            if (txtUserAge.Value == 0)
            {
                txtUserAge.Focus();
                errorProvider3.SetError(this.txtUserAge, "Enter your age!!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtUserAddress_Enter(object sender, EventArgs e)
        {
            if (txtUserAddress.Text == "Enter your residential address")
            {
                txtUserAddress.Text = "";
                txtUserAddress.ForeColor = Color.Black;
            }
        }

        private void txtUserAddress_Leave(object sender, EventArgs e)
        {
            if (txtUserAddress.Text == "")
            {
                txtUserAddress.Focus();
                errorProvider4.SetError(this.txtUserAddress, "Enter your residential address!!");

            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtUserAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 32)
            {
                // Allow space (ASCII code 32)
                e.Handled = false;
            }
            else if (ch == 44)
            {
                // Allow comma (ASCII code 44)
                e.Handled = false;
            }
            else if (ch == 45)
            {
                // Allow hyphen/minus sign (ASCII code 45)
                e.Handled = false;
            }
            else if (ch == 46)
            {
                // Allow period/dot (ASCII code 46)
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUserMobileNumber_Enter(object sender, EventArgs e)
        {
            if (txtUserMobileNumber.Text == "Enter mobile number")
            {
                txtUserMobileNumber.Text = "";
                txtUserMobileNumber.ForeColor = Color.Black;
            }
        }

        private void txtUserMobileNumber_Leave(object sender, EventArgs e)
        {
            if (txtUserMobileNumber.Text == "")
            {
                txtUserMobileNumber.Focus();
                errorProvider5.SetError(this.txtUserMobileNumber, "Enter your mobile number!!");

            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtUserMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 32)
            {
                // Allow space (ASCII code 32)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
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
            if (Regex.IsMatch(txtUserEmail.Text, email_pattern) == false)
            {
                txtUserEmail.Focus();
                errorProvider6.SetError(this.txtUserEmail, "Enter valid email!!");
            }
            else
            {
                errorProvider6.Clear();
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
            if (Regex.IsMatch(txtUserPassword.Text, pass_pattern) == false)
            {
                txtUserPassword.Focus();
                errorProvider7.SetError(this.txtUserPassword, "Enter strong password, Uppercase, lowercase, numbers & special char combination!!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtconfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtconfirmPassword.Text == "Re-enter password")
            {
                txtconfirmPassword.Text = string.Empty;
                txtconfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txtconfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtconfirmPassword.Text != txtUserPassword.Text)
            {
                txtconfirmPassword.Focus();
                errorProvider8.SetError(this.txtconfirmPassword, "Password didn't match!!");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        //method two show or hide Password
        private void showPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showPasswordCB.Checked;
            switch (check)
            {
                case true:
                    txtUserPassword.UseSystemPasswordChar = false;
                    txtconfirmPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtUserPassword.UseSystemPasswordChar = true;
                    txtconfirmPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void LinkToLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        //create an account for a user
        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter full name" || cmbUserGender.Text == "Select gender" || txtUserAddress.Text == "Enter your residential address"
                || txtUserMobileNumber.Text == "Enter mobile number" || txtUserEmail.Text == "Enter email address"
                || txtUserPassword.Text == "Enter password" || txtconfirmPassword.Text == "Re-enter password")
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserName.Text == string.Empty || cmbUserGender.SelectedItem == null ||txtUserAge.Value == 0 || txtUserAddress.Text == string.Empty
                || txtUserMobileNumber.Text == string.Empty || txtUserEmail.Text == string.Empty
                || txtUserPassword.Text == string.Empty || txtconfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Name = txtUserName.Text.Trim();
                model.Gender = cmbUserGender.SelectedItem.ToString();
                model.Age = Convert.ToInt32(txtUserAge.Value);
                model.Address = txtUserAddress.Text.Trim();
                model.MobileNumber = Convert.ToInt64(txtUserMobileNumber.Text);
                model.Email = txtUserEmail.Text.Trim();
                model.Password = txtUserPassword.Text.Trim();
                db.Users.Add(model);

                int success = db.SaveChanges();
                if (success > 0)
                {
                    MessageBox.Show("Account Created Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult confirm = MessageBox.Show("Do you want to login?", "ALert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(confirm == DialogResult.Yes)
                    {
                        LoginForm loginForm = new LoginForm();
                        this.Hide();
                        loginForm.Show();
                    }
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Registration Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        //reset textboxes
        private void ResetControls()
        {
            txtUserName.Clear();
            cmbUserGender.SelectedItem = null;
            txtUserAge.Value = 0;
            txtUserAddress.Clear();
            txtUserMobileNumber.Clear();
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            txtconfirmPassword.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
