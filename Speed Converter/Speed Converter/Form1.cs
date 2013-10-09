using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Constants
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;
            

            // Variables
            int kph;    // Kilometers per hour
            double mph; // Miles per hour
            int count = 0; // Counter

            // Display the table of speeds
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                // Calculate miles per hour
                mph = kph * CONVERSION_FACTOR;

                // Display the conversion
                presortListBox.Items.Add(kph + " KPH is the same as " + mph + " MPH");
                count++;
            }

            // Show result in reverse order. 
            for (count--; count >= 0; count--)
            {
                outputListBox.Items.Add(presortListBox.Items[count].ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString;    // Variable that will hold the string to be found

            searchString = searchTextBox.Text; // Assigining whatever is in the text box to the variable

            if (searchString != string.Empty) // If the text box isn't empty
            {
                int index = outputListBox.FindString(searchString); // Find string on outputListBox

                if (index != -1)
                    outputListBox.SetSelected(index, true); // Selected string value
                else
                    MessageBox.Show("The search string did not find any results.");
            }
        }
    }
}
