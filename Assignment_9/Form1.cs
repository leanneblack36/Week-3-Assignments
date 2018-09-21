using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class btnFootball : Form
    {
        public btnFootball()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
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
                lblFeeToBePaid.Text = FeeToBePaid.ToString("0.00");
            }
            else if (radioBtnFootball.Checked && Age > 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 175 - 25;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("0.00");
            }
            else if (radioBtnFootball.Checked && Age < 40 && MembershipDuration > 10)
            {
                int FeeToBePaid = 175 - 20;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("0.00");
            }
            else if (radioBtnFootball.Checked && Age < 40 && MembershipDuration < 10)
            {
                int FeeToBePaid = 175;
                lblFeeToBePaid.Text = FeeToBePaid.ToString("0.00");
            }

            Console.ReadKey();
       
        }
    }
}

