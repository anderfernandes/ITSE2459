using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Constant for the monthly interest rate
            // const decimal INTEREST_RATE = 0.005m;

            // Local variables
            decimal balance;        // The account balance
            int months;             // The number of months
            decimal interestRate;

            // Get the starting balance
            if (decimal.TryParse(startingBalanceTextBox.Text, out balance)
                    && balance > 0)
            {
                // Get the interest rate
                if (decimal.TryParse(interestRateTextBox.Text, out interestRate)
                        && interestRate >0)
                {

                    // Get the number of months
                    if (int.TryParse(monthsTextBox.Text, out months)
                            && months > 0)
                    {
                        //Clear the TextBoxes and the endingBalanceLabel control
                        detailListBox.Items.Clear();
                        

                        // The following loop calculates the ending balance
                        for (int count = months; count >= 1; count-- )
                        {
                            // Add this month's interest to the balance
                            balance = balance + (interestRate * balance);

                            // Display this month's ending balance
                            detailListBox.Items.Add("The ending balance " +
                                "for month " + count + " is " +
                                balance.ToString("c"));
                        }

                        // Display the ending balance
                        endingBalanceLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        // Invalid number of months was entered
                        MessageBox.Show("Invalid value for months.");
                    }
                }
                else
                {
                    // Invalid interest rate
                    MessageBox.Show("Invalid interest rate.");
                }
            }
            else
            {
                // Invalid number of months was entered
                MessageBox.Show("Invalid value for starting balance.");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and the endingBalanceLabel control
            startingBalanceTextBox.Text = "";
            monthsTextBox.Text = "";
            interestRateTextBox.Text = "";
            detailListBox.Items.Clear();
            endingBalanceLabel.Text = "";

            // Reset the focus
            startingBalanceTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
