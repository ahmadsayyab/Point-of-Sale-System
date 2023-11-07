using MainLogicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace POS_System_V2
{
    public partial class CustomersForm : Form
    {
        string email_pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        
        Customer model = new Customer();
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
        int id = 0;
        public CustomersForm()
        {
            InitializeComponent();
            ReadCustomersToGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            this.Hide();
            homeScreenForm.Show();
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter full name")
            {
                txtCustomerName.Text = "";
                txtCustomerName.ForeColor = Color.Black;
            }
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                txtCustomerName.Focus();
                errorProvider1.SetError(this.txtCustomerName, "Enter your full name!!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void cmbCustomerGender_Enter(object sender, EventArgs e)
        {
            if (cmbCustomerGender.Text == "Select gender")
            {
                cmbCustomerGender.Text = "";
                cmbCustomerGender.ForeColor = Color.Black;
            }
        }

        private void cmbCustomerGender_Leave(object sender, EventArgs e)
        {
            if (cmbCustomerGender.SelectedItem == null)
            {
                cmbCustomerGender.Focus();
                errorProvider2.SetError(this.cmbCustomerGender, "Select your gender!!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtCustomerEmail_Enter(object sender, EventArgs e)
        {
            if (txtCustomerEmail.Text == "Enter email address")
            {
                txtCustomerEmail.Text = string.Empty;
                txtCustomerEmail.ForeColor = Color.Black;
            }
        }

        private void txtCustomerEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCustomerEmail.Text, email_pattern) == false)
            {
                txtCustomerEmail.Focus();
                errorProvider3.SetError(this.txtCustomerEmail, "Enter valid email!!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtCustomerAddress_Enter(object sender, EventArgs e)
        {
            if (txtCustomerAddress.Text == "Enter residential address")
            {
                txtCustomerAddress.Text = "";
                txtCustomerAddress.ForeColor = Color.Black;
            }
        }

        private void txtCustomerAddress_Leave(object sender, EventArgs e)
        {
            if (txtCustomerAddress.Text == "")
            {
                txtCustomerAddress.Focus();
                errorProvider4.SetError(this.txtCustomerAddress, "Enter your residential address!!");

            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtCustomerAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else if (ch == 44)
            {
                e.Handled = false;
            }
            else if (ch == 45)
            {
                e.Handled = false;
            }
            else if (ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //add customers detail
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter full name"  || cmbCustomerGender.Text == "Select gender" || txtCustomerEmail.Text == "Enter email address" || txtCustomerAddress.Text == "Enter residential address")
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerName.Text == string.Empty || cmbCustomerGender.SelectedItem == null || txtCustomerEmail.Text == string.Empty || txtCustomerAddress.Text == string.Empty)
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Name = txtCustomerName.Text.Trim();
                model.Gender = cmbCustomerGender.SelectedItem.ToString();

                model.Email = txtCustomerEmail.Text.Trim();
                model.Address = txtCustomerAddress.Text.Trim();
                db.Customers.Add(model);
                

                int success = db.SaveChanges();
                if (success > 0)
                {
                    MessageBox.Show("Customer added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReadCustomersToGridView();
                    ResetControls();
                    txtCustomerName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add Customer detail!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //clear text from all fields
        private void ResetControls()
        {
            txtCustomerName.Clear();
            cmbCustomerGender.SelectedItem = null;
            txtCustomerEmail.Clear();
            txtCustomerAddress.Clear();
        }

        //read all customers to GridView
        private void ReadCustomersToGridView()
        {
            dataGridView1.DataSource = db.Customers.ToList<Customer>();
            
        }

        //read data to textboxes by double clicking the data coloumn
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            model = db.Customers.Where(read => read.C_id == id).FirstOrDefault();
            
            txtCustomerName.Text = model.Name;
            cmbCustomerGender.SelectedItem = model.Gender;
            txtCustomerEmail.Text = model.Email;
            txtCustomerAddress.Text = model.Address;
        }


        //update customers data
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter full name" || cmbCustomerGender.Text == "Select gender" || txtCustomerEmail.Text == "Enter email address" || txtCustomerAddress.Text == "Enter residential address")
            {
                MessageBox.Show("Customer is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerName.Text == string.Empty || cmbCustomerGender.SelectedItem == null || txtCustomerEmail.Text == string.Empty || txtCustomerAddress.Text == string.Empty)
            {
                MessageBox.Show("Customer is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.C_id = id;
                model.Name = txtCustomerName.Text.Trim();
                model.Gender = cmbCustomerGender.SelectedItem.ToString();

                model.Email = txtCustomerEmail.Text.Trim();
                model.Address = txtCustomerAddress.Text.Trim();

                //update statement
                db.Entry(model).State = EntityState.Modified;

                int success = db.SaveChanges();
                if (success > 0)
                {
                    MessageBox.Show("Customer Data Updated Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReadCustomersToGridView();
                    ResetControls();

                }
                else
                {
                    MessageBox.Show("Failed to update Customer detail!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        //delete customer data
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter full name" || cmbCustomerGender.Text == "Select gender" || txtCustomerEmail.Text == "Enter email address" || txtCustomerAddress.Text == "Enter residential address")
            {
                MessageBox.Show("Customer is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerName.Text == string.Empty || cmbCustomerGender.SelectedItem == null || txtCustomerEmail.Text == string.Empty || txtCustomerAddress.Text == string.Empty)
            {
                MessageBox.Show("Customer is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    model = db.Customers.Where(read => read.C_id == id).FirstOrDefault();
                    db.Entry(model).State = EntityState.Deleted;
                    int success = db.SaveChanges();
                    if (success > 0)
                    {
                        MessageBox.Show("Customer Data Deleted Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ReadCustomersToGridView();
                        ResetControls();

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Customer detail!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateOrderbtn_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            this.Hide();
            createOrderForm.Show();
        }


        //Search Customer by name
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string searchedName = txtSearchCustomer.Text;

            var customerExist = db.Customers.FirstOrDefault(p => p.Name == searchedName);

            if (customerExist != null)
            {
                
                dataGridView1.DataSource = null;

                
                List<Customer> customerData = new List<Customer> { customerExist };

                // Bind the DataGridView to the list
                dataGridView1.DataSource = customerData;

                txtSearchCustomer.Clear();


            }
            else
            {
                MessageBox.Show("Customer not found!!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReadCustomersToGridView();
                txtSearchCustomer.Clear();

            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
