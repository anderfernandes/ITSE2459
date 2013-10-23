using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cup_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CupsToOunces(double copyCups, ref double ounces)
        {
            ounces = copyCups * 8;
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups, ounces = 0;

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                CupsToOunces(cups, ref ounces);
                ouncesLabel.Text = ounces.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
