using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andersoft_Workshop_Selector_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declaring and initializing variables
            decimal registrationFee = 0;
            decimal days = 0;
            decimal lodgingFee = 0;


            if (lboWorkshop.SelectedIndex != -1 && lboLocation.SelectedIndex != -1)
            {
                /* Get input from workshop list and input data into variables for 
                 * registration fee and # of days.*/
                switch (lboWorkshop.SelectedIndex)
                {
                    case 0:
                        days = 3;
                        registrationFee = 1000;
                        break;
                    case 1:
                        days = 3;
                        registrationFee = 800;
                        break;
                    case 2:
                        days = 3;
                        registrationFee = 1500;
                        break;
                    case 3:
                        days = 5;
                        registrationFee = 1300;
                        break;
                    case 4:
                        days = 1;
                        registrationFee = 500;
                        break;
                }
                switch (lboLocation.SelectedIndex)
                {
                    case 0:
                        lodgingFee = 150;
                        break;
                    case 1:
                        lodgingFee = 225;
                        break;
                    case 2:
                        lodgingFee = 175;
                        break;
                    case 3:
                        lodgingFee = 300;
                        break;
                    case 4:
                        lodgingFee = 175;
                        break;
                    case 5:
                        lodgingFee = 150;
                        break;
                }    
            }  // Current end of IF statement, move below.

            // Showing results
            lblRegistrationPrice.Text = "Registration: " + registrationFee.ToString("c");
            lblLodgingPrice.Text = lodgingFee.ToString("c") + " x " + days.ToString() + " days = " + (lodgingFee * days).ToString("c");
            lblTotal.Text = (registrationFee + (lodgingFee * days)).ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Labels and return ListBoxes to the first item
            lblRegistrationPrice.Text = "";
            lblLodgingPrice.Text = "";
            lblTotal.Text = "";
            lboWorkshop.ClearSelected();
            lboLocation.ClearSelected();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
