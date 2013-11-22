using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCDData(CDAccount account)
        {
            decimal interestRate;
            decimal balance;

            account.AccountNumber = accountNumberTextBox.Text;

            account.MaturityDate = maturityDateTextBox.Text;

            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    MessageBox.Show("Invalid balance");
                }
            }
            else
            {
                MessageBox.Show("Invalid interest rate");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CDAccount myAccount = new CDAccount();

            GetCDData(myAccount);

            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createPreLoadButton_Click(object sender, EventArgs e)
        {
            string accntNum = accountNumberTextBox.Text;
            string mattDate = maturityDateTextBox.Text;
            decimal interestRate;
            decimal balance;

            if (!decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                MessageBox.Show("Invalid interest rate");
            }
            
            if (!decimal.TryParse(balanceTextBox.Text, out balance))
            {
                MessageBox.Show("Invalid balance");
            }

            CDAccount myAccount = new CDAccount(accntNum, interestRate, balance, mattDate);

            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }
        
    }
}
