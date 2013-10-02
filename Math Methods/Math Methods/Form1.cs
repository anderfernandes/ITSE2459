using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Methods
{
    public partial class Form1 : Form
    {

        double angle;    /******************************************************************* 
                         * To hold the value of the angle. We will take it in degrees, but  *
                         *  the method does all the calculations in radians. To convert it  *
                         * back to degrees, all I did was to multiply the angle by PI and   *
                         * divide it by 180.                                                *
                         ********************************************************************/

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalculateSine_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the angle
                angle = double.Parse(tbAngle.Text);

                // Calculate and show result
                lblTrigResult.Text = "The sine of " + tbAngle.Text + " is " + Math.Sin(angle*(Math.PI/180)) + ".";
            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

            private void btnCalculateCosine_Click(object sender, EventArgs e)
            {
                try
                {
                    // Get the angle in degrees.
                    angle = double.Parse(tbAngle.Text);

                    // Calculate and show result
                    lblTrigResult.Text = "The cosine of " + tbAngle.Text + " is " + Math.Cos(angle*(Math.PI / 180)) + ".";
                }
                catch (Exception ex)
                {
                    //Display the default error message
                    MessageBox.Show(ex.Message);
                }
            }

        private void btnCalculateTangent_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the angle
                angle = double.Parse(tbAngle.Text);

                // Calculate and show result
                lblTrigResult.Text = "The tangent of " + tbAngle.Text + " is " + Math.Tan(angle*(Math.PI / 180));
            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculateLog_Click(object sender, EventArgs e)
        {
            try
            {
                int log;     // To hold the number that we'll use to calculate log

                // Get the number
                log = int.Parse(tbLog.Text);

                // Calculate and show result
                lblLogResult.Text = "The log10 of " + tbLog.Text + " is " + Math.Log10(log);
            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            try
            {
                int number, power;  // To hold number and the power

                // Get the number
                number = int.Parse(tbNumber.Text);

                // Get the Power
                power = int.Parse(tbPower.Text);

                // Calculate and show result
                lblPowerResult.Text = Math.Pow(number, power).ToString();
            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
