/*
 * Jasmyn Stansfield
 * Mr. Hardman
 * Assignment 2, Program 2
 * October 24, 2016
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finding_the_average
{
    public partial class frmFindingTheAverage : Form
    {
        public frmFindingTheAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Getting user inputted numbers
            double mark1 = Convert.ToDouble(txtMark1.Text);
            double mark2 = Convert.ToDouble(txtMark2.Text);
            double mark3 = Convert.ToDouble(txtMark3.Text);
            double mark4 = Convert.ToDouble(txtMark4.Text);
            double mark5 = Convert.ToDouble(txtMark5.Text);

            //Using arithmetic operations
            double sum = mark1 + mark2 + mark3 + mark4 + mark5;
            double average = sum / 5;


            lblDisplay.Text = string.Format("{0,-10}{1,10}\n{2,-10}{3,10}\n{4,-10}{5,10}\n{6,-10}{7,10}\n{8,-10}{9,10}\n{10,-10:}{11,10}",
               "Grade 1: ", mark1, "Grade 2:", mark2, "Grade 3: ", mark3, "Grade 4: ", mark4, "Grade 5:", mark5, "Average: ", average);





        }
    }
}
