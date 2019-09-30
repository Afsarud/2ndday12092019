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
using CoffeShop.BLL;

namespace CoffeShop
{
    public partial class ItemsUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemsUi()
        {
            InitializeComponent();
            idTextBox.Hide();
            idLabel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isUnique = _itemManager.CheckUniqueName(nameTextBox.Text);
            if (isUnique)
            {
                MessageBox.Show("already exsit");
                return;
            }
            try
            {
                bool isAdded = _itemManager.Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text));
                if (isAdded)
                {
                    MessageBox.Show("saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!showResult())
            {
                MessageBox.Show("Data Not found");
            }
            idTextBox.Show();
            idLabel.Show();
            idTextBox.Clear();
            nameTextBox.Clear();
            priceTextBox.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (searchTextBox.Text == null)
            {
                MessageBox.Show("Field is empty");
            }

            if (searchData(searchTextBox.Text))
            {
                MessageBox.Show("Data found");
            }
            else
            {
                MessageBox.Show("Not Match");
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteData())
                {
                    MessageBox.Show("Delete successfull");
                }
                else
                {
                    MessageBox.Show("Delete Unsuccessfull");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Filup requeired number");
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateData())
                {
                    MessageBox.Show("Updated");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No data found");
            }

        }

       
       
        private bool searchData(string name)
        {
            bool isFound = false;
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items Where Name='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isFound = true;
            }

            return isFound;
        }
        private bool deleteData()
        {
            bool isDelete = true;
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            //CommandStatement
            string sqlcommand = @"Delete Items where ItemId ="+ idTextBox.Text+ "";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            return isDelete;
        }
        private bool UpdateData()
        {
            bool isUpdate = true;
            //Connection String
            string ConnectionString = @"server= DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            //Command String
            string sqlcommand = @"UPDATE Items SET Name = '"+nameTextBox.Text+ "', Price="+priceTextBox.Text+" Where ItemId="+idTextBox.Text+ "";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlConnection);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isUpdate;
        }
        //private void resultDisplay()
        //{
        //    String conectioString = @"server= DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
        //    SqlConnection sqlConnection = new SqlConnection(conectioString);

        //    String commandString = @"Select * From Items";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();
        //    sqlCommand.ExecuteNonQuery();

        //    //Show 
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);
        //    sqlConnection.Close();
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        showDataGridView.DataSource = dataTable;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Data Not Found");
        //    }
        //}
    }
}
