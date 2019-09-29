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
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        public object ComboBox1 { get; private set; }
        public string Tablero { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string order = orderComboBox.Text;
            int productQuantity = Convert.ToInt32(quantityTextBox.Text);
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

            int totalPrice = ProAmount * productQuantity;

            const int num = 1;
            string[,] name = new string[10,6];
            for(int i = 0; i < num; i++)

            {
                name[i,0] = Convert.ToString(CusNameTextBox.Text);
                name[i,1] = Convert.ToString(contactTextBox.Text);
                name[i,2] = Convert.ToString(addressTextBox.Text);
                name[i,3] = Convert.ToString(orderComboBox.SelectedItem);
                name[i,4] = Convert.ToString(quantityTextBox.Text);
                name[i,5] = Convert.ToString(totalPrice);
             
                richTextBox1.Text += "\n Customer Name: " + name[i,0] + "\n" +
               "Contact Number: " + name[i,1] + "\n" +
               "Address: " + name[i,2] + "\n " +
               "Order Amount:" + name[i,3] + "\n" +
               "Quantity Value: " + name[i,4] + "\n" +
               "Total Price: " + name[i,5] + "\n \n";
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
