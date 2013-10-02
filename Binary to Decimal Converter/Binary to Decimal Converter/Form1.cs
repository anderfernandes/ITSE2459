using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_to_Decimal_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = textBox1.Text.Length;
                double n2 = 0;
                String str = textBox1.Text;
                char[] str1 = str.ToCharArray(); // Converts the content of texBox1.text from string to char array (Anderson OF)
                for (int i = 0; i < n; i++)
                {
                    String x = str1[i].ToString();
                    n2 += int.Parse(x) * Math.Pow(2, n - i - 1);
                }
                label2.Text = n2 + "";
            }
            catch (Exception ex)
            {
                // Displays error message if input in textBox1 is in wrong format (Chris M)
                MessageBox.Show(ex.Message);
            }
        }
    }
}
