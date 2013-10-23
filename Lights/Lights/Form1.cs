﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lamp()
        {
            if (lightOnPictureBox.Visible == true)
            {
                lightOnPictureBox.Visible = false;
                lightOffPictureBox.Visible = true;
                lightStateLabel.Text = "OFF";
            }
            else
            {
                lightOnPictureBox.Visible = true;
                lightOffPictureBox.Visible = false;
                lightStateLabel.Text = "ON";
            }
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            Lamp();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
