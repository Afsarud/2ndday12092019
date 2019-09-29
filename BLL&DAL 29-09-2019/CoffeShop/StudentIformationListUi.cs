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
    public partial class StudentIformatioListUi : Form
    {
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> mobiles = new List<string>();
        List<string> addresses = new List<string>();
        List<int> ages = new List<int>();
        List<double> gpaes = new List<double>();


        public StudentIformatioListUi()
        {
            InitializeComponent();
            showAllButton.Enabled = false;
            searchButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string id = stIdTextBox.Text;
            string name = stNameTextBox.Text;
            string mobile = stMobileTextBox.Text;
            string address = staddressTextBox.Text;
            string age = stageTextBox.Text;
            string gpa = stGpaTextBox.Text;
            if (id == "" || name == "" || mobile == "" || address == "" || age == "" || gpa == "")
            {
                MessageBox.Show("Enter all field please");
                return;

            }
            if (id.Length != 4)
            {
                MessageBox.Show("Enter four digit");
                return;
            }
            if (name.Length>=30)
            {
                MessageBox.Show("Enter max 30 digit");
                return;
            }
            if (mobile.Length!=11)
            {
                MessageBox.Show("Enter 11 digit");
                return;
            }

            double gpaMark = Convert.ToDouble(stGpaTextBox.Text);
            if (gpaMark < 0|| gpaMark > 4)
            {
                MessageBox.Show("Enter 0 to 4 digit");
                return;
            }

            else
            {
                try
                {
                    ids.Add(Convert.ToInt32(id));
                    names.Add(name);
                    mobiles.Add(mobile);
                    addresses.Add(address);
                    ages.Add(Convert.ToInt32(age));
                    gpaes.Add(Convert.ToDouble(gpa));
                }
                catch (Exception)
                {

                    MessageBox.Show("Please Enter right value");
                    return;
                }
                
            }
            int index = ids.Count() - 1;
            ShowAllResultForStudentInfo(index,index);

            showAllButton.Enabled = true;
            searchButton.Enabled = true;
        }
        private void ShowAllResultForStudentInfo(int firstindex, int endindex)
        {
            addedRichTextBox.Text = "";

            for (int i = firstindex; i <=endindex; i++)
            {
                try
                {
                    addedRichTextBox.Text += "ID: " + ids[i] + ", " + "Name: " + names[i] + "," + "Mobile: " + mobiles[i] +
                    ", " + "Address: " + addresses[i] + ", " + "Age: " + ages[i] + ", " + "GPA: " + gpaes[i] + "\n";

                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter right value");
                }
                
            }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowAllResultForStudentInfo(0, ids.Count() - 1);

            //Mark distribution

            double maxGpa = gpaes.Max();
            int index = gpaes.IndexOf(maxGpa);
            string name = names[index];

            maxGpaTextBox.Text = maxGpa.ToString();
            maxNameTextBox.Text = name.ToString();

            double mingpa = gpaes.Min();
            index = gpaes.IndexOf(mingpa);
            name = names[index];

            minGpaTextBox.Text = mingpa.ToString();
            minNameTextBox.Text = name.ToString();

            double total = gpaes.Sum();
            double average = total / gpaes.Count();
            avgGpatextBox.Text = average.ToString();
            totalMakrsTextBox.Text = total.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;

            if (search == "")
            {
                MessageBox.Show("Enter Search value please");
                return;
            }
            int index = -1;
            if (idForRadioButton.Checked == true)
            {
                try
                {
                    int searchId = Convert.ToInt32(searchTextBox.Text);
                    index = ids.IndexOf(searchId);
                }
                catch (Exception)
                {

                    MessageBox.Show("Please Check numeric value");
                    return;
                }
                
            }
            else if (nameForRadioButton.Checked == true)
            {
                index = names.IndexOf(search);
            }
            else if (mobileForRadioButton.Checked == true)
            {
                index = mobiles.IndexOf(search);
            }
            else
            {
                MessageBox.Show("Searching unsuccessful");
                return;
            }
            ShowAllResultForStudentInfo(index, index);

            MessageBox.Show("Searching successful");

        }
    }
}
