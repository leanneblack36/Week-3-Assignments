using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //inpute age//
            string input = txtAge.Text;
            double age = double.Parse(input);

            const double BasicPrice = 12;


            //calculate ticket price//

            if (age < 5 BasicPrice = 0.00)
            {
                int FeeToBePaid = 175 - 25 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
        }
    }
}
