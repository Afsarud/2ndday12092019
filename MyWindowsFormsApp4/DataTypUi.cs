using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp4
{
    public partial class DataTypUi : Form
    {
        public DataTypUi()
        {
            InitializeComponent();
        }

        private void DataTypUi_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result = firstNumber + secondNumber;

            MessageBox.Show("Name: "+name+" Result: "+result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
