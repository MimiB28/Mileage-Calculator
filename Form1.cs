using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate=.54, amountOwed;

        private void btnDis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numStart.Value;
            endingMileage = (int)numEnd.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                cost.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage!", "Cannot Calculate Mileage..");
            }
        }
    }
}
