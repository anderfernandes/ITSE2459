/****************************************
 * Program 1 - Temperature Converter    *
 * Student: Anderson Oliveira Fernandes *
 * Date: 9/22/2013                      *
 * Course Number: ITSE 2459             *
 * Due Date: 9/24/2013                  *
 * Date Submited: 9/24/2013             *
 ****************************************/

/****************************************************************
 * This program gets from the user a temperature in Fahrenheits *
 * and converts it to Kelvin, Rankine and Delisle. It also      *
 * converts to all those scales at once. There is a "Clear"     *
 * button, which clear whatever is in the text box as well as   *
 * whatever is in the output labels for each scale and an       *
 * exit button, which exits the program. I have also put        *
 * exception handling to make sure the program doesn't freeze   *
 * if the user enters weird values.                             *
 ***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andersoft_Temperature_Converter_1._0
{
    public partial class Form1 : Form
    {

        double dblFahrenheit; // To hold the user input in Fahrenheit

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToKelvin_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from the tbFahrenheit and parse it to the variable dblFahrenheit
                dblFahrenheit = double.Parse(tbFahrenheit.Text);

                // Calculate and show the result of the conversion
                lblKelvin.Text = ((dblFahrenheit + 459.67) * 5 / 9).ToString() + " K";
            }
            catch (Exception ex)
            {
                // Show a message error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToRankine_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from the tbFahrenheit and parse it to the variable dblFahrenheit
                dblFahrenheit = double.Parse(tbFahrenheit.Text);

                // Calculate and show the result of the conversion
                lblRankine.Text = (dblFahrenheit + 459.67).ToString() + " °R";
            }
            catch (Exception ex)
            {
                // Show a message error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToNewton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from the tbFahrenheit and parse it to the variable dblFahrenheit
                dblFahrenheit = double.Parse(tbFahrenheit.Text);

                // Calculate and show the result of the conversion
                lblNewton.Text = ((dblFahrenheit - 32) * 11/60).ToString() + " °N";
            }
            catch (Exception ex)
            {
                // Show a message error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToDelisle_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from the tbFahrenheit and parse it to the variable dblFahrenheit
                dblFahrenheit = double.Parse(tbFahrenheit.Text);

                // Calculate and show the result of the conversion
                lblDelisle.Text = ((212 - dblFahrenheit) * 5/6).ToString() + " °De";
            }
            catch (Exception ex)
            {
                // Show a message error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToAll_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from the tbFahrenheit and parse it to the variable dblFahrenheit
                dblFahrenheit   = double.Parse(tbFahrenheit.Text);

                // Calculate and show the result of the conversion for all scales
                lblKelvin.Text  = ((dblFahrenheit + 459.67) * 5 / 9).ToString() + " K";
                lblRankine.Text = (dblFahrenheit + 459.67).ToString() + " °R";
                lblNewton.Text  = ((dblFahrenheit - 32) * 11 / 60).ToString() + " °N";
                lblDelisle.Text = ((212 - dblFahrenheit) * 5 / 6).ToString() + " °De";
            }
            catch (Exception ex)
            {
                // Show a message error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all output labels and tbFahrenheit text box
            lblKelvin.Text    = "";
            lblRankine.Text   = "";
            lblNewton.Text    = "";
            lblDelisle.Text   = "";
            tbFahrenheit.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }

    }
}
