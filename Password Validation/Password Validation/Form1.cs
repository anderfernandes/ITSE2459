using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //********
        private int NumberUpperCase(string str)
        {
            int upperCase = 0;
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            return upperCase++;
        }
        //**********
        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            return lowerCase;
        }
        //*****
        private int NumberDigits(string str)
        {
            int digits = 0;
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            return digits;
        }
        //**********
        
        //**********
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGHT = 8;

            string password = passwordTextBox.Text;

            if (password.Length >= MIN_LENGHT &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1)
            {
                MessageBox.Show("The password is valid.");
            }
            else
            {
                MessageBox.Show("The password does not meet the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            


            if (password.Contains(' '))
            {
                MessageBox.Show("No spaces!");
                passwordTextBox.Text = passwordTextBox.Text.TrimEnd();
                passwordTextBox.Select(passwordTextBox.Text.Length, 0);
            }
        }
    }
}
