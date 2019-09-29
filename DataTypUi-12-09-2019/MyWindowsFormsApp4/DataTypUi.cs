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
        //public string name;
        //public int Add;
        //public int sub;
        //public int mult;
        //public double div;



        //public string Add { get; private set; }

        public DataTypUi()
        {
            InitializeComponent();
        }

        private void DataTypUi_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //string name = this.name;
            //string Add=Convert.ToString(this.Add);
            //string sub = Convert.ToString(this.sub);
            //string mult = Convert.ToString(this.mult);
            //string div = Convert.ToString(this.div);
            string name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int Add = firstNumber + secondNumber;
            int sub = firstNumber - secondNumber;
            int mult = firstNumber * secondNumber;
            double div = firstNumber / secondNumber;
            MessageBox.Show("Name: "+name+" Result: "+ Add +", "+ sub+", "+ mult+", "+ div);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int Add = firstNumber + secondNumber;

            MessageBox.Show("Name: " + name + " Result: " + Add);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sub = firstNumber - secondNumber;

            MessageBox.Show("Name: " + name + " Result: " + sub);
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int mult = firstNumber * secondNumber;

            MessageBox.Show("Name: " + name + " Result: " + mult);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble (secondNumberTextBox.Text);
            double div = firstNumber / secondNumber;

            MessageBox.Show("Name: " + name + " Result: " + div);
        }

        
    }
}
