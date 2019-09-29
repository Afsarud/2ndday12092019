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
    public partial class CoffeeShopDBUi : Form
    {
        public CoffeeShopDBUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //ConnectionString
            string connetionString = @"Server= DESKTOP-GIE8L6J; Database= CoffeeShop; Integrated Security= True";
            
            SqlConnection sqlconnection = new SqlConnection(connetionString); 
           
            //sqlCommand
            string sqlcommand = @"insert into Customer (Customer_Name,Contact,Address)
            values ('"+nameTextBox.Text+"', '"+ contactTextBox.Text+ "', '"+ addressTextBox.Text + "');";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand);
            
            //open statement
            sqlconnection.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("input value");
            }
            
            //close Statement
            sqlconnection.Close();
            
        }
    }
}
