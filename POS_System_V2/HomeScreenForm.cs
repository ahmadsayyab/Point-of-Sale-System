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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            this.Hide();
            customersForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            this.Hide();
            customersForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            this.Hide();
            productsForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            this.Hide();
            productsForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateOrderPic_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            this.Hide();
            createOrderForm.Show();
        }

        private void CreateOrderLbl_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            this.Hide();
            createOrderForm.Show();
        }

        private void picSeeOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
            this.Hide();
            orderHistoryForm.Show();
        }

        private void lblSeeOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
            this.Hide();
            orderHistoryForm.Show();
        }
    }
}
