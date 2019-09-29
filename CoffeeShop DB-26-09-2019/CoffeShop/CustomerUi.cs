using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CustomerUi : Form
    {
        List<string> customerNames= new List<string>();


        public CustomerUi()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"insert into Customer (Customer_Name,Contact,Address)values ('"+ customerTextBox.Text+ "', '"+ contactTextBox.Text+ "', '"+ addressRichTextBox.Text+ "');";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            string customerName = customerTextBox.Text;
            customerNames.Add(customerName);
            try
            {
                
                for (int i = 0; i < customerNames.Count(); i++)
                {
                    if (customerName == customerNames[i])
                    {
                        MessageBox.Show("Customer Name already exist so retype other number");
                        return;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Saved Information");
                return;
            }
            


            //try
            //{
            //    int isexecute = sqlCommand.ExecuteNonQuery();
            //    if (isexecute > 0)
            //    {
            //        MessageBox.Show(" Added information !");
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Enter Information");
            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Insert Information");
            //}
            

            customerTextBox.Clear();
            contactTextBox.Clear();
            addressRichTextBox.Clear();
            label4.Hide();
            idTextBox.Hide();

            sqlconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"select * from Customer";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Show Data");
            }
            else
            {
                MessageBox.Show("Data Not Found! ");
            }

            label4.Show();
            idTextBox.Show();

            sqlconnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Delete Customer where Cus_ID = "+idTextBox.Text+ "";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
           
            try
            {
                int isexecute = sqlCommand.ExecuteNonQuery();
                if (isexecute > 0)
                {
                    MessageBox.Show("Deleted information !");
                }
            }
            catch (Exception)
            {
               
                    MessageBox.Show("Not Deleted Information");
                
            }
            
            sqlconnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            //string sqlcommand = @"UPDATE Customer SET Customer_Name = '"+ customerTextBox.Text+ "' Where Cus_ID=" + idTextBox.Text+";";
            string sqlcommand = @"UPDATE Customer SET Customer_Name = '" + customerTextBox.Text + "', Contact='"+ contactTextBox.Text+ "', Address ='"+ addressRichTextBox.Text+ "' Where Cus_ID=" + idTextBox.Text + ";";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            try
            {

                int isexecute = sqlCommand.ExecuteNonQuery();
                if (isexecute > 0)
                {
                    MessageBox.Show(" Updated !");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("No data Updated");
            }
            
            customerTextBox.Clear();
            contactTextBox.Clear();
            addressRichTextBox.Clear();
            sqlconnection.Close();
        }
    }
}
