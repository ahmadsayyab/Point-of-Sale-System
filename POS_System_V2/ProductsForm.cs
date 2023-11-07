using MainLogicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_V2
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        Product model = new Product();
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
      

        //link to homepage
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            this.Hide();
            homeScreenForm.Show();

        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Enter product name")
            {
                txtProductName.Text = "";
                txtProductName.ForeColor = Color.Black;
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                txtProductName.Focus();
                errorProvider1.SetError(this.txtProductName, "Enter product name!!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtProductCategory_Enter(object sender, EventArgs e)
        {
            if (txtProductCategory.Text == "Enter product category")
            {
                txtProductCategory.Text = "";
                txtProductCategory.ForeColor = Color.Black;
            }
        }

        private void txtProductCategory_Leave(object sender, EventArgs e)
        {
            if (txtProductCategory.Text == "")
            {
                txtProductCategory.Focus();
                errorProvider2.SetError(this.txtProductCategory, "Enter product category!!");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtProductQuantity_Enter(object sender, EventArgs e)
        {
            if (txtProductQuantity.Text == "Enter product quantity")
            {
                txtProductQuantity.Text = "";
                txtProductQuantity.ForeColor = Color.Black;
            }
        }

        private void txtProductQuantity_Leave(object sender, EventArgs e)
        {
            if (txtProductQuantity.Text == "")
            {
                txtProductQuantity.Focus();
                errorProvider3.SetError(this.txtProductQuantity, "Enter product quantity!!");

            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidInput(e);
        }

        private void txtProductCost_Enter(object sender, EventArgs e)
        {
            if (txtProductCost.Text == "Enter per product cost")
            {
                txtProductCost.Text = "";
                txtProductCost.ForeColor = Color.Black;
            }
        }

        private void txtProductCost_Leave(object sender, EventArgs e)
        {
            if (txtProductCost.Text == "")
            {
                txtProductCost.Focus();
                errorProvider4.SetError(this.txtProductCost, "Enter per product cost!!");

            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtProductCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidInput(e);
        }

        private void txtProductPrice_Enter(object sender, EventArgs e)
        {
            if (txtProductPrice.Text == "Enter product price")
            {
                txtProductPrice.Text = "";
                txtProductPrice.ForeColor = Color.Black;
            }
        }

        private void txtProductPrice_Leave(object sender, EventArgs e)
        {
            if (txtProductPrice.Text == "")
            {
                txtProductPrice.Focus();
                errorProvider5.SetError(this.txtProductPrice, "Enter product price!!");

            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidInput(e);
        }


        //validate input
        private void EnsureValidInput(KeyPressEventArgs e)
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
                // Allow dot (ASCII code 46)
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //add product
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Enter item name" || txtProductCategory.Text == "Enter item category" || txtProductQuantity.Text == "Enter item quantity" 
                || txtProductCost.Text == "Enter item cost" || txtProductPrice.Text == "Enter item price")
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtProductName.Text == string.Empty || txtProductCategory.Text == string.Empty || txtProductQuantity.Text == string.Empty
                || txtProductCost.Text == string.Empty || txtProductPrice.Text == string.Empty)
            {
                MessageBox.Show("Fill all the fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Name = txtProductName.Text.Trim();
                model.Category = txtProductCategory.Text.Trim();
                model.Quantity =Convert.ToDecimal(txtProductQuantity.Text.Trim());
                model.Cost = Convert.ToDecimal(txtProductCost.Text.Trim());
                model.Price = Convert.ToDecimal(txtProductPrice.Text.Trim());
               
                db.Products.Add(model);


                int success = db.SaveChanges();
                if (success > 0)
                {
                    MessageBox.Show("Product added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillListBox();
                    ResetControls();
                   
                }
                else
                {
                    MessageBox.Show("Failed to add Product detail!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Reset textboxex
        private void ResetControls()
        {
            txtProductName.Clear();
            
            txtProductCategory.Clear();
            txtProductPrice.Clear();
            txtProductCost.Clear();
            txtProductQuantity.Clear();
        }



       //show all available products in a listBox
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            FillListBox();
           
        }


        //load products into listbox
        private void FillListBox()
        {

            
            var names = db.Products
                   .OrderBy(item => item.Name)
                   .Select(item => item.Name)
                   .ToList();
            AllProductBox.DataSource = names;
            AllProductBox.SelectedIndex = -1;


        }

        //Read product data into textboxes
        private void AllProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            if(AllProductBox.SelectedIndex == -1)
            {
                
                ResetControls();
            }

            else
            {
                
                string selectedName = AllProductBox.SelectedItem.ToString();
                var selectedData = db.Products.Where(item => item.Name == selectedName).FirstOrDefault();

                
                txtProductName.Text = selectedData.Name;
                txtProductCategory.Text = selectedData.Category;
                txtProductQuantity.Text = selectedData.Quantity.ToString();
                txtProductCost.Text = selectedData.Cost.ToString();
                txtProductPrice.Text = selectedData.Price.ToString();
                
            }
            

           


        }

        //clear textboxes
        private void ClearFieldsbtn_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        //Exit application
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Update product data
        private void Updatebtn_Click(object sender, EventArgs e)
        {

            if (txtProductName.Text == "Enter item name" || txtProductCategory.Text == "Enter item category" || txtProductQuantity.Text == "Enter item quantity"
                || txtProductCost.Text == "Enter item cost" || txtProductPrice.Text == "Enter item price")
            {
                MessageBox.Show("Product is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtProductName.Text == string.Empty || txtProductCategory.Text == string.Empty || txtProductQuantity.Text == string.Empty
                || txtProductCost.Text == string.Empty || txtProductPrice.Text == string.Empty)
            {
                MessageBox.Show("Product is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedName = AllProductBox.SelectedItem.ToString();

                // Find the product with the selected name
                var existingProduct = db.Products.FirstOrDefault(p => p.Name == selectedName);

                if (existingProduct != null)
                {

                    existingProduct.Name = txtProductName.Text.Trim();
                    existingProduct.Category = txtProductCategory.Text.Trim();
                    existingProduct.Quantity = Convert.ToDecimal(txtProductQuantity.Text.Trim());
                    existingProduct.Cost = Convert.ToDecimal(txtProductCost.Text.Trim());
                    existingProduct.Price = Convert.ToDecimal(txtProductPrice.Text.Trim());


                    db.Entry(existingProduct).State = EntityState.Modified;

                    int success = db.SaveChanges();
                    if (success > 0)
                    {
                        MessageBox.Show("Product Data Updated Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillListBox();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Product detail!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        //delete product 
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Enter item name" || txtProductCategory.Text == "Enter item category" || txtProductQuantity.Text == "Enter item quantity"
               || txtProductCost.Text == "Enter item cost" || txtProductPrice.Text == "Enter item price")
            {
                MessageBox.Show("Product is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtProductName.Text == string.Empty || txtProductCategory.Text == string.Empty || txtProductQuantity.Text == string.Empty
                || txtProductCost.Text == string.Empty || txtProductPrice.Text == string.Empty)
            {
                MessageBox.Show("Product is not selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedName = AllProductBox.SelectedItem.ToString();
                DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    model = db.Products.Where(read => read.Name == selectedName).FirstOrDefault();
                    db.Entry(model).State = EntityState.Deleted;
                    int success = db.SaveChanges();
                    if (success > 0)
                    {
                        MessageBox.Show("Product Deleted Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FillListBox();
                        ResetControls();

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Product!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }


        //search product by name
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchedName = txtSearchProduct.Text;

            var existingProduct = db.Products.Where(p => p.Name == searchedName).FirstOrDefault();

            if (existingProduct != null)
            {
                AllProductBox.DataSource = null;
                AllProductBox.Items.Clear();
                AllProductBox.Items.Add(existingProduct);

                //tells the ListBox to display the "Name" property of the Product
                AllProductBox.DisplayMember = "Name";
                txtSearchProduct.Clear();


            }
            else
            {
                MessageBox.Show("Product not found!!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillListBox();
                txtSearchProduct.Clear();

            }

        }
    }
}
