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

namespace POS_System_V2
{
    public partial class OrderHistoryForm : Form
    {
        Order order = new Order();
        POS_Managment_SystemEntities db = new POS_Managment_SystemEntities();
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void LinkToHomeScrren_Click(object sender, EventArgs e)
        {
            HomeScreenForm form = new HomeScreenForm();
            this.Hide();
            form.Show();
        }

        private void picExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            ReadCustomersIntoCmb();
        }

        private void btnViewOrderHistory_Click(object sender, EventArgs e)
        {
            if (cmbSelectCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to see his orders history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int selectedCustomerId = (int)cmbSelectCustomer.SelectedValue;

                List<Order> orderHistory = GetOrderHistoryForCustomer(selectedCustomerId);

                if (orderHistory.Count == 0)
                {
                    MessageBox.Show("No orders found for the selected customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = orderHistory;


                if (dataGridView1.Columns.Contains("Customer"))
                {
                    dataGridView1.Columns["Customer"].Visible = false;
                }
            }
        }

        //get order of specific cutomer
        private List<Order> GetOrderHistoryForCustomer(int customerId)
        {
            List<Order> orderHistory;

                orderHistory = db.Orders
                    .Where(o => o.C_id == customerId)
                    .ToList();
           

            return orderHistory;
        }

    }
}
