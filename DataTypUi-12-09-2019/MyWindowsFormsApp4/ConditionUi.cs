﻿using System;
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
    public partial class ConditionUi : Form
    {
        public ConditionUi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (itemComboBox.Text == "")
            {
                MessageBox.Show("Please Select Item");
            }
            else
            {
                MessageBox.Show(itemComboBox.Text + " is Selected");
            }
        }
    }
}
