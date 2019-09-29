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
    public partial class CoffeeShopListUi : Form
    {
        int price = 0, index = 0;
        List<String> customerNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<String> addresses = new List<String>();
        List<string> orders = new List<string>();
        List<int> queintityes = new List<int>();
        List<int> totalPrices = new List<int>();

        public int Price { get => price; set => price = value; }

        public CoffeeShopListUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            string customerName = CusNameTextBox.Text;
            string contactNumber = contactTextBox.Text;
            string address = addressTextBox.Text;
            string orderItem = orderComboBox.Text;
            string queintity = quantityTextBox.Text;

            //int productQuantity = Convert.ToInt32(quantityTextBox.Text);
            
            int ProAmount = 0;

            if (orderComboBox.Text == "Black-120")
            {
                ProAmount = 120;
            }
            else if (orderComboBox.Text == "Cold-100")
            {
                ProAmount = 100;
            }
            else if (orderComboBox.Text == "Hot-90")
            {
                ProAmount = 90;
            }
            else if (orderComboBox.Text == "Reguler-80")
            {
                ProAmount = 80;
            }

            int totalPrice = ProAmount * Convert.ToInt32(queintity);

            for (int i = 0; i < contactNumbers.Count(); i++)
            {
                if (contactNumber == contactNumbers[i])
                {
                    MessageBox.Show("Contact Number already exist so retype other number");
                    return;
                }

            }
                customerNames.Add(customerName);
                contactNumbers.Add(contactNumber);
                addresses.Add(address);
                orders.Add(orderItem);
                queintityes.Add(Convert.ToInt32(queintity));
                totalPrices.Add(totalPrice);

            resultRichTextBox.Text += "";
            ShowAllCustomerInformation(index,index);

            index++;
            //for (int i = 0; i < customerNames.Count(); i++)
            //{
            //    resultRichTextBox.Text = "\n Customer Name: " + customerNames[i] + "\n" +
            //   "Contact Number: " + contactNumbers[i] + "\n" +
            //   "Address: " + addresses[i] + "\n " +
            //   "Order Amount:" + orders[i] + "\n" +
            //   "Quantity Value: " + queintityes[i] + "\n" +
            //   "Total Price: " + totalPrices[i] + "\n \n";
            //}

            index++;
            

            CusNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";

        }
        private void ShowAllCustomerInformation(int firstindex, int lastindex)
        {
            resultRichTextBox.Text += "";
            for (int i = firstindex; i < lastindex; i++)
            {
                resultRichTextBox.Text += "\n Customer Name: " + customerNames[i] + "\n" +
               "Contact Number: " + contactNumbers[i] + "\n" +
               "Address: " + addresses[i] + "\n " +
               "Order Amount:" + orders[i] + "\n" +
               "Quantity Value: " + queintityes[i] + "\n" +
               "Total Price: " + totalPrices[i] + "\n \n";
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "";

            CusNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }
       

        private void showAllButton_Click_1(object sender, EventArgs e)
        {
            //resultRichTextBox.Text += "";
            ShowAllCustomerInformation(index, index);

            //for (int i = 0; i < customerNames.Count(); i++)
            //{
            //    resultRichTextBox.Text += "\n Customer Name: " + customerNames[i] + "\n" +
            //   "Contact Number: " + contactNumbers[i] + "\n" +
            //   "Address: " + addresses[i] + "\n " +
            //   "Order Amount:" + orders[i] + "\n" +
            //   "Quantity Value: " + queintityes[i] + "\n" +
            //   "Total Price: " + totalPrices[i] + "\n \n";
            //}
        }
    }
}
