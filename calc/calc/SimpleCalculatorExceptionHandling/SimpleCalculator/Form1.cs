using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//worked with luke and carlos

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                string operator1 = txtOperator.Text;
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                decimal result = Calculate(operand1, operator1, operand2);

                result = Math.Round(result, 4);
                this.txtResult.Text = result.ToString();
                txtOperand1.Focus();
            }
            catch (FormatException)
            {
                // catches invalid format input
                MessageBox.Show("Please enter valid numbers in both operand fields.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                // overflow catch when the number is too large
                MessageBox.Show("The number entered is too large or too small. Please enter a larger/smaller number.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                // division by zero error
                MessageBox.Show("Division by zero does not work. Please enter a non-zero divisor.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // ceneral catch for any other errors
                MessageBox.Show($"An error occurred:\n\nMessage: {ex.Message}\n\nType: {ex.GetType()}\n\nStack Trace:\n{ex.StackTrace}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}
