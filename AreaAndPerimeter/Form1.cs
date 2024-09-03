using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Ensure the form receives key events
        }

        /*
         * worked with carlos and luke
         */

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Option to exit program
        }

        private void Calculate()
        {
           
            
                decimal length = Convert.ToDecimal(textBox1.Text); // Get and convert length from textbox3
                decimal width = Convert.ToDecimal(textBox2.Text); // Get and convert width from textbox2
                decimal area = length * width; // Calculate area
                decimal perimeter = (2 * length) + (2 * width); // Calculate perimeter

                textBox3.Text = area.ToString(); // Display area in textbox1
                textBox4.Text = perimeter.ToString(); // Display perimeter in textbox4
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate(); // Call your calculation method
                e.Handled = true; // Optional: mark the event as handled
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Close the form
                e.Handled = true; // Optional: mark the event as handled
            }
        }
    }
}
