/* AUTHOR: Austin Gordon
 * DATE: 5-2-18
 * PURPOSE: Form app for calculating BMI
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

namespace BMIWindowsApp
{
    public partial class BMIAppForm : Form
    {
        int heightFt, heightIn, weight;
        double bmi;
        string bmiStatus;
        bool heightFtValid = false, heightInValid = false, weightValid = false;

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (weightTextBox.Text == "") // if blank, reset background color
            {
                weightTextBox.BackColor = System.Drawing.Color.White;
                weightValid = false;
            }
            else if (int.TryParse(weightTextBox.Text, out weight) == false) // if input is not an int
            {
                weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                weightValid = false;
            }
            else
            {
                if (weight > 0) // check if input is a valid number
                {
                    // if valid, make text box green
                    weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
                    weightValid = true;
                }
                else
                {
                    // if invalid, make text box red
                    weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                    weightValid = false;
                }
            }

            checkValid();
            return;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            heightInTextBox.BackColor = System.Drawing.Color.White;
            heightFtTextBox.BackColor = System.Drawing.Color.White;
            weightTextBox.BackColor = System.Drawing.Color.White;

            heightInTextBox.Text = "";
            heightFtTextBox.Text = "";
            weightTextBox.Text = "";

            heightInValid = false;
            heightFtValid = false;
            weightValid = false;

            weightStatusOutput.Text = "";
            BMIOutput.Text = "";

            computeButton.Enabled = false;
            computeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            bmi = weight / Math.Pow((heightFt * 12 + heightIn), 2) * 703;

            if (bmi <= 23.5)
            {
                bmiStatus = "Normal";
            }else if (bmi <= 29.3)
            {
                bmiStatus = "Overweight";
            }else
            {
                bmiStatus = "Obese";
            }

            BMIOutput.Text = "Your BMI is " + Math.Round(bmi, 1).ToString();
            weightStatusOutput.Text = "Your weight status is " + bmiStatus;
        }

        private void heightInTextBox_TextChanged(object sender, EventArgs e)
        {
            if (heightInTextBox.Text == "") // if blank, reset background color
            {
                heightInTextBox.BackColor = System.Drawing.Color.White;
                heightInValid = false;
            }
            else if (int.TryParse(heightInTextBox.Text, out heightIn) == false) // if input is not an int
            {
                heightInTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                heightInValid = false;
            }
            else
            {
                if (heightIn >= 0 && heightIn < 12) // check if input is a valid number
                {
                    // if valid, make text box green
                    heightInTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
                    heightInValid = true;
                }
                else
                {
                    // if invalid, make text box red
                    heightInTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                    heightInValid = false;
                }
            }

            checkValid();
            return;
        }

        public BMIAppForm()
        {
            InitializeComponent();
        }

        private void heightFt_TextChanged(object sender, EventArgs e)
        {
            if (heightFtTextBox.Text == "") // if blank, reset background color
            {
                heightFtTextBox.BackColor = System.Drawing.Color.White;
                heightFtValid = false;
            }
            else if (int.TryParse(heightFtTextBox.Text, out heightFt) == false) // if input is not an int
            {
                heightFtTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                heightFtValid = false;
            }
            else
            {
                if (heightFt >= 3 && heightFt <= 8) // check if input is a valid number
                {
                    // if valid, make text box green
                    heightFtTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
                    heightFtValid = true;
                }else
                {
                    // if invalid, make text box red
                    heightFtTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
                    heightFtValid = false;
                }
            }

            checkValid();
            return;
        }

        private void checkValid()
        {
            if (heightFtValid && heightInValid && weightValid)
            {
                computeButton.Enabled = true;
                computeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            }
            else
            {
                computeButton.Enabled = false;
                computeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            }
        }
    }
}
