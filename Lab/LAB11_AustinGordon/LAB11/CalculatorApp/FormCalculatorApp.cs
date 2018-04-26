/* CalculatorApp.cs
 * This application allows the user
 * to input two numeric values. Buttons
 * for Add and Multiply are available which
 * display the results of the calculations.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorAppForm : Form
    {
        public CalculatorAppForm()
        {
            InitializeComponent();
        }

        private void CalculatorAppForm_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToString("d"); // display today's date in mm/dd/yyyy fashion
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxValue1.Text = "";
            textBoxValue2.Text = "";
            textBoxValue1.Focus();
            labelResult.ForeColor = Color.Black;
            labelResult.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double val1, val2;

            // validate first input box
            if(double.TryParse(textBoxValue1.Text, out val1) == false || val1 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue1.Focus();
                return;
            }

            // validate second input box
            if (double.TryParse(textBoxValue2.Text, out val2) == false || val2 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue2.Focus();
                return;
            }

            // when control reaches here, it means both values are valid
            labelResult.Text = ""; // clear the result box

            // do the calculation and display the result
            double result = val1 + val2;
            labelResult.ForeColor = Color.DarkBlue;
            labelResult.Text = result.ToString();

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double val1, val2;

            // validate first input box
            if (double.TryParse(textBoxValue1.Text, out val1) == false || val1 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue1.Focus();
                return;
            }

            // validate second input box
            if (double.TryParse(textBoxValue2.Text, out val2) == false || val2 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue2.Focus();
                return;
            }

            // when control reaches here, it means both values are valid
            labelResult.Text = ""; // clear the result box

            // do the calculation and display the result
            double result = val1 * val2;
            labelResult.ForeColor = Color.DarkBlue;
            labelResult.Text = result.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, val2;

            // validate first input box
            if (double.TryParse(textBoxValue1.Text, out val1) == false || val1 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue1.Focus();
                return;
            }

            // validate second input box
            if (double.TryParse(textBoxValue2.Text, out val2) == false || val2 < 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Value must be numeric and positive.";
                textBoxValue2.Focus();
                return;

            }else if(val2 == 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Denominator cannot be 0.";
                textBoxValue2.Focus();
                return;
            }

            // when control reaches here, it means both values are valid
            labelResult.Text = ""; // clear the result box

            // do the calculation and display the result
            double result = Math.Round(val1 / val2, 2);
            labelResult.ForeColor = Color.DarkBlue;
            labelResult.Text = result.ToString();

        }
    } //class
} //namespace
