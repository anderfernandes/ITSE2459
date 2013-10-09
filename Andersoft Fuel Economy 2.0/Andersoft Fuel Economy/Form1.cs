using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andersoft_Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            double miles;       // To hold miles driven
            double gallons;     // To hold gallons used
            double mpg = 0;         // To hold MPG

            // Validate the milesTextBox costrol
            if (double.TryParse(milesTextBox.Text, out miles))
            {
                // Validate the gallonsTextBox control
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    // If the Premium radio button is checked
                    if (rbPremium.Checked)
                    {
                        // Calculate MPG for Premium, MPG + 10%
                        mpg = (miles / gallons) - (miles / gallons) * 0.1;
                    }
                    
                    // If the E-87 radio button is checked
                    else if (rbE87.Checked)
                    {
                        // Calculate MPG for E-87, MPG + 20%
                        mpg = (miles / gallons) - (miles / gallons) * 0.2;
                    }

                    // If the Regular radio button is checked
                    else if (rbRegular.Checked)
                    {
                        // Calculate MPG
                        mpg = miles / gallons;
                    }

                    // If none of the radio buttons are checked
                    else
                    {
                        // Show the user an error message
                        MessageBox.Show("Please select a grade.");
                        return;
                    }

                    // If miles and gallons equal to zero or less...
                    if (miles <= 0 || gallons <= 0)
                    {
                        // ...Show message saying that those values are not valid
                        MessageBox.Show("Miles and gallons cannot be equal to or less then 0.");
                        
                        // ... and clear values on Tex Boxes and Label
                        milesTextBox.Text = "";
                        gallonsTextBox.Text = "";
                        mpgLabel.Text = "";
                        rbE87.Checked = false;
                        rbPremium.Checked = false;
                        rbRegular.Checked = false;
                        return;
                    }
                    // Otherwise...
                    else
                        // Show the result of the calculation
                        mpgLabel.Text = mpg.ToString() + " miles per gallon";

                }
                else
                {
                    // Display an error message for gallonsTextBox
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                // Display an error message for milesTextBox
                MessageBox.Show("Invalid input for miles.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Andersoft products!");
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the textboxes, labels and values on radio buttons
            milesTextBox.Text = "";
            gallonsTextBox.Text = "";
            mpgLabel.Text = "";
            rbE87.Checked = false;
            rbPremium.Checked = false;
            rbRegular.Checked = false;

        }
    }
}
