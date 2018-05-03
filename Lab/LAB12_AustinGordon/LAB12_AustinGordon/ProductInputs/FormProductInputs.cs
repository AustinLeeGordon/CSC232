using System;
using System.Windows.Forms;

namespace ProductInputs
{
    public partial class FormProductInputs : Form
    {
        //Global area
        //Define and assign PARALLEL ARRAYS

        string[] arrStateNames = new string[] {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky"};

        string[] arrStateAbbrev = new string[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY" };

        double[] arrSalesTaxRates = new double[] { 4.00, 0.00, 5.60, 6.50, 7.50, 2.90, 6.35, 0.00, 6.00, 4.00, 4.00, 6.00, 6.25, 7.00, 6.00, 6.15, 6.00 };

        public FormProductInputs()
        {
            InitializeComponent();
        }

        private void FormProductInputs_Load(object sender, EventArgs e)
        {
            //This initializes the form when it first loads
            radioButtonEast.Checked = true; //initialize REGION radio button
            checkBoxFragile.Checked = true; //initialize TYPE check box
            radioButtonTrain.Checked = true; //initialize SHIPPING radio button

            //Fill the COMBO BOX with state abbreviations
            foreach (string item in arrStateAbbrev)
            {
                comboBoxState.Items.Add(item.ToString());
            }
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Find the current index of state abbrev selected in combo box
            int idx = comboBoxState.SelectedIndex;

            if( idx == -1)
                return;

            string stateName = arrStateNames[idx]; //assign name from array at current index

            //Display the name in the corresponding label
            labelStateName.Text = stateName;

            //Find and assign the "formatted" sales tax rate to label box
            labelSalesTaxRate.Text = arrSalesTaxRates[idx].ToString("#0.00");
        }

        private void pictureBoxOK_Click(object sender, EventArgs e)
        {
            //This event validates and displays all the results selected by the user in a Message Box
            string msg = null, pnum = textBoxProductNum.Text;
            double d;

            if(double.TryParse(pnum, out d) == false || d < 0 || d > 1000)
            {
                MessageBox.Show("The Product Number is invalid. Try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxProductNum.Focus();

                return; //end this event
            }

            //If control reached here, it means product number is valid, continue the program
            //Build the message step-by-step to display

            msg += "You have entered the following information:\n\n";
            msg += "\tProduct Number: " + pnum.ToString() + "\n";

            //Capture Region of Origin
            if (radioButtonEast.Checked)
                msg += "\tRegion of Origin: " + radioButtonEast.Text + "\n";
            else if (radioButtonWest.Checked)
                msg += "\tRegion of Origin: " + radioButtonWest.Text + "\n";
            else if (radioButtonNorth.Checked)
                msg += "\tRegion of Origin: " + radioButtonNorth.Text + "\n";
            else if (radioButtonSouth.Checked)
                msg += "\tRegion of Origin: " + radioButtonSouth.Text + "\n";

            //Capture shipping method
            if (radioButtonTrain.Checked)
                msg += "\tShipping Method: " + radioButtonTrain.Text + "\n";
            else if (radioButtonTruck.Checked)
                msg += "\tShipping Method: " + radioButtonTruck.Text + "\n";

            //Capture product type
            if (checkBoxPerish.Checked)
                msg += "\tProduct Type: " + checkBoxPerish.Text + "\n";

            if (checkBoxFragile.Checked)
                msg += "\tProduct Type: " + checkBoxFragile.Text + "\n";

            //Capture color from list
            if (listBoxColor.SelectedIndex == -1)
            {
                MessageBox.Show("The State is not selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBoxState.Focus();
                return;
            }
            else
                msg += "\tShip To: " + comboBoxState.Text + "\n";

            //Capture Sales Tax rate
            msg += "\tSales Tax Rate: " + labelSalesTaxRate.Text + "%";

            //Finally, display the message
            MessageBox.Show(msg);
        }

        private void pictureBoxCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //close the form and end the program
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Clear all list box selections
            listBoxColor.SelectedIndex = -1;

            //Clear all combo box selectiosn
            comboBoxState.SelectedIndex = -1;

            //Clear all text box entries
            textBoxProductNum.Text = "";

            //Clear all label entries
            labelSalesTaxRate.Text = "label";
            labelStateName.Text = "label";

            //Reset radio buttons
            radioButtonEast.Checked = true;
            checkBoxFragile.Checked = true;
            radioButtonTrain.Checked = true;
        }

    } //class
} //namespace
