using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andersoft_Time_Zone_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; // To hold the name of a city
            DateTime myDateTime = DateTime.Now;

            if (cityListBox.SelectedIndex != -1)
            {
                // Get the selected item
                city = cityListBox.SelectedItem.ToString();

                // Determine the time zone
                 switch (city)
                 {
                     case "Honolulu":
                         timeZoneLabel.Text = "Hawaii-Aleutian";
                         myDateTime = myDateTime.AddHours(-4);
                         break;
                     case "San Francisco":
                         timeZoneLabel.Text = "Pacific";
                         myDateTime = myDateTime.AddHours(-2);
                         break;
                     case "Denver":
                         timeZoneLabel.Text = "Mountain";
                         myDateTime = myDateTime.AddHours(-1);
                         break;
                     case "Minneapolis":
                         timeZoneLabel.Text = "Central";
                         break;
                     case "New York":
                         timeZoneLabel.Text = "Eastern";
                         myDateTime = myDateTime.AddHours(1);
                         break;
                }
                 currentTimeLabel.Text = myDateTime.ToString();
            }
            else
            {
                // No city was selected
                MessageBox.Show("Select a city.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city; // To hold the name of a city
            DateTime myDateTime = DateTime.UtcNow;

            if (cityListBox.SelectedIndex != -1)
            {
                // Get the selected item
                city = cityListBox.SelectedItem.ToString();

                // Determine the time zone
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        myDateTime = myDateTime.AddHours(-10);
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        myDateTime = myDateTime.AddHours(-7);
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        myDateTime = myDateTime.AddHours(-6);
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        myDateTime = myDateTime.AddHours(-6);
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        myDateTime = myDateTime.AddHours(-4);
                        break;
                    case "GMT":
                        timeZoneLabel.Text = "GMT";
                        break;
                    case "Brasília":
                        timeZoneLabel.Text = "Brasília time";
                        myDateTime = myDateTime.AddHours(-3);
                        break;
                    case "Madrid":
                        timeZoneLabel.Text = "Central European";
                        myDateTime = myDateTime.AddHours(2);
                        break;
                    case "Tokyo":
                        timeZoneLabel.Text = "Japan Standard";
                        myDateTime = myDateTime.AddHours(9);
                        break;
                    case "London":
                        timeZoneLabel.Text = "British Summer";
                        myDateTime = myDateTime.AddHours(1);
                        break;
                    case "Moscow":
                        timeZoneLabel.Text = "Moscow Standard";
                        myDateTime = myDateTime.AddHours(4);
                        break;
                    case "Johannesburg":
                        timeZoneLabel.Text = "South Africa Standard";
                        myDateTime = myDateTime.AddHours(2);
                        break;
                }
                currentTimeLabel.Text = myDateTime.ToString();
            }
            else
            {
                // No city was selected
                MessageBox.Show("Select a city.");
            }
        }
    }
}
