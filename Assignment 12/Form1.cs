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

            //make a constant value//
            const int basicPrice = 12;
             
            //calculate ticket price//

            if (age < 5)
            {
                int price = basicPrice - basicPrice;
                lblPrice.Text = price.ToString("€0.00");
            }
            else if (age > 5 && age < 12)
            {
                int price = basicPrice / 2;
                lblPrice.Text = price.ToString("€0.00");
            }
            else if (age > 13 && age < 54)
            {
                int price = basicPrice;
                lblPrice.Text = price.ToString("€0.00");
            }
           else  if (age > 55)
            {
                int price = basicPrice - basicPrice;
                lblPrice.Text = price.ToString("€0.00");
            }
            Console.Read();
            }
        }
    }

