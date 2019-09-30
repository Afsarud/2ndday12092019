using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string orderInfo = orderComboBox.Text;
            int quantityNu = Convert.ToInt32(quantityTextBox.Text);
            int contact = Convert.ToInt32(contactTextBox.Text);
            int productAmount = 0;
            if (orderComboBox.Text == "Math-120")
            {
                productAmount = 120;
            }

            else if (orderComboBox.Text == "Bangla-100")
            {
                productAmount = 100;
            }

            else if (orderComboBox.Text == "English-90")
            {
                productAmount = 90;
            }
            else if (orderComboBox.Text == "Art-80"){
                productAmount = 80;
            }
            else
            {
                MessageBox.Show("Select an Item please");
            }
             int TotalPrice = productAmount * quantityNu;

            resultRichTextBox.Text ="Customer Name: "+textBox1.Text + "\n" +
               "Contact Number: "+contactTextBox.Text + "\n" +
               "Your Address: "+addressTextBox.Text+ "\n" + 
               "Order Amount: " + orderComboBox.SelectedItem + "\n" +
               "Quantity Number: "+quantityTextBox.Text+ "\n" +
               "Total Price"+TotalPrice;
        }
    }
}
