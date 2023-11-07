using MainLogicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_System_V2
{
    public partial class CreateOrderForm : Form
    {
        
        Order order = new Order();
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkToHomeScrren_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            this.Hide();
            homeScreenForm.Show();

        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            ReadProductsToChecklistBox();
            ReadCustomersIntoCmb();
        }


        //read available products into checklistBox
        private void ReadProductsToChecklistBox()
        {

            
            var productsList = from product in db.Products
                           select product.Name;

            checkedListBox1.Items.AddRange(productsList.ToArray());
            

        }

        //read customers into a combobox
        private void ReadCustomersIntoCmb()
        {
            // Load data from the database
            var customers = db.Customers.ToList();  

            // Bind the data to the ComboBox
            cmbSelectCustomer.DisplayMember = "Name";  
            cmbSelectCustomer.ValueMember = "C_id";
            cmbSelectCustomer.DataSource = customers;
            cmbSelectCustomer.SelectedIndex = -1;
        }


        //Checklistbox method,It is called
        //whenever an item is checked or unchecked.
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            decimal totalBill = CalculateTotalBill(e);
            lblShowTotalBill.Text = totalBill.ToString();
            lblShowTotalBill.Visible = true;


        }


        //Method to calculate totalBill
        private decimal CalculateTotalBill(ItemCheckEventArgs e)
        {
            decimal totalBill = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index && checkedListBox1.GetItemChecked(i))
                {
                    string productName = checkedListBox1.Items[i].ToString();
                    decimal price = GetPriceFromDatabase(productName);
                    totalBill += price;
                }
            }

            if (e.NewValue == CheckState.Checked)
            {
                string productName = checkedListBox1.Items[e.Index].ToString();
                decimal price = GetPriceFromDatabase(productName);
                totalBill += price;
            }


            return totalBill;



        }

        //get item price for each selected prodcut from table
        private decimal GetPriceFromDatabase(string productName)
        {

            var product = db.Products.Where(p => p.Name == productName).FirstOrDefault();
            if (product != null)
            {
                return product.Price;
            }
            return 0;
            
        }


        //save order detail to database
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Please select at least one item before saving the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (cmbSelectCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer before saving the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                List<string> selectedProductNames = new List<string>();
                foreach (int index in checkedListBox1.CheckedIndices)
                {
                    selectedProductNames.Add(checkedListBox1.Items[index].ToString());
                }


                List<Product> selectedProducts = db.Products
                    .Where(p => selectedProductNames.Contains(p.Name))
                    .ToList();

                int selectedCustomerId = (int)cmbSelectCustomer.SelectedValue;
                DateTime selectedDate = dateTimePicker1.Value;


                //take selected item names from database
                List<string> purchasedProductsNames = selectedProducts.Select(p => p.Name).ToList();

                string purchasedProductsText = string.Join(", ", purchasedProductsNames);


                var itemCheckEventArgs = new ItemCheckEventArgs(-1, CheckState.Unchecked, CheckState.Unchecked);

                long orderTotalBill = Convert.ToInt64(CalculateTotalBill(itemCheckEventArgs));


                //add values to the Order table
                order.C_id = selectedCustomerId;
                order.OrderDate = selectedDate;

                order.totalBill = orderTotalBill;
                order.PurchasedProducts = purchasedProductsText;



                db.Orders.Add(order);
                db.SaveChanges();


                MessageBox.Show("Order saved successfull!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }


        //link to Order histoy form
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryForm form = new OrderHistoryForm();
            this.Hide();
            form.Show();  
        }
    }
}
