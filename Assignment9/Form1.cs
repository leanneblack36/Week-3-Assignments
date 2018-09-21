using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            //enter age//
            string input1 = txtAge.Text;
            double Age = double.Parse(input1);

            //enter membership duration//
            string input2 = txtMembershipDuration.Text;
            double MembershipDuration = double.Parse(input2);

            //calculate memberships fees//

            if (radioBtnFootball.Checked && Age > 40 && MembershipDuration > 10)
            {
                int FeeToBePaid = 175 - 25 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnFootball.Checked && Age > 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 175 - 25;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnFootball.Checked && Age < 40 && MembershipDuration > 10)
            {
                int FeeToBePaid = 175 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnFootball.Checked && Age < 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 175;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            //Calculate fees for handball//

            if (radioBtnHandball.Checked && Age > 40 && MembershipDuration > 10)
            {
                int FeeToBePaid = 225 - 25 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnHandball.Checked && Age > 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 225 - 25;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnHandball.Checked && Age < 40 && MembershipDuration > 10)
            {
                int FeeToBePaid = 225 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }
            else if (radioBtnHandball.Checked && Age < 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 225;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("€0.00");
            }

            Console.Read();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


