using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Repository
{

    public class ItemRepository
    {
        public bool Add(string name, double Price)
        {
            bool Isadded = true;
            try
            {
                string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
                SqlConnection sqlconnection = new SqlConnection(connectionString);

                string sqlcommand = @"insert into Items values ('" + name + "', " + Price + ");";
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

                sqlconnection.Open();
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqldataadapter.Fill(dataTable);
                sqlconnection.Close();
                
                if (dataTable.Rows.Count > 0)
                {
                    Isadded = true;
                }
            }
            catch (Exception exception)
            {

                //MessageBox.Show(exception.Message);
            }

            return Isadded;
        }

        internal bool Add(string name)
        {
            throw new NotImplementedException();
        }

        public bool CheckUniqueName(string name)
        {
            bool isUnique = false;
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items Where Name='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isUnique = true;
            }

            return isUnique;

        }
        public DataTable showResult()
        {
            
            string connectionString = @"server=DESKTOP-GIE8L6J; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            
            //showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();
            if (dataTable.Rows.Count > 0)
            {
                return dataTable;
            }
            
            //return isShow;
        }

    }
}
