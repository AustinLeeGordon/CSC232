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

        double heightFt, heightIn, weight;
        bool valid = false;

        public BMIAppForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void heightFt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkValid()
        {
            if (heightFt > 0 && heightIn < 12 && heightFt >= 0 && weight > 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            if (valid)
            {
                computeButton.Enabled = true;
                computeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            }
            else
            {
                computeButton.Enabled = false;
            }
        }
    }
}
