using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            // Sets the displayed button text
            answerLabel.Text = "Theodore Roosevelt";

            // change backgrnd to Hot Pink
            answerLabel.BackColor = System.Drawing.Color.HotPink;

            // change font color to Yellow (Chris M)
            answerLabel.ForeColor = System.Drawing.Color.Yellow;

            //Changes text to italic
            //answerLabel.FontStyle = FontStyles.Italic;
            answerLabel.FontStyle = FontStyle.Bold;

            //Changes the weight to bold

            //answerLabel.FontWeight = FontWeight.Bold;

            MessageBox.Show("Hello World!");
        }
    }
}
