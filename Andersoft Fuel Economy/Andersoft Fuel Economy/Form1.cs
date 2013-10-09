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
            try
            {
                double miles;       // To hold miles driven
                double gallons;     // To hold gallons used
                double mpg;         // To hold MPG

                // Get the miles driven and assign it to the miles variable
                miles = double.Parse(milesTextBox.Text);

                // Get the gallons used and assing it to the gallons variable
                gallons = double.Parse(gallonsTextBox.Text);
                             
                // calculate MPG
                mpg = miles / gallons;

                // Display the MPG in the mpgLabel control
                if (miles <= 0 || gallons <= 0)
                {
                    MessageBox.Show("Miles and Gallons cannot be equal to or less then 0.");
                    mpgLabel.Text = "Invalid input";
                }
                else
                mpgLabel.Text = mpg.ToString() + " miles per gallon";

                // Check if values on the text boxes isn't zero or less
               
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show("Invalid data entered. " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Andersoft products!");
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            milesTextBox.Text = "";
            gallonsTextBox.Text = "";
            mpgLabel.Text = "";
        }
    }
}
