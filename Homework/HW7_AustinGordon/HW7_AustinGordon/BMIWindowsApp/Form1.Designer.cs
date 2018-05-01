namespace BMIWindowsApp
{
    partial class BMIAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appHeading = new System.Windows.Forms.Label();
            this.heightFtTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInTextBox = new System.Windows.Forms.TextBox();
            this.ftLabel = new System.Windows.Forms.Label();
            this.inLabel = new System.Windows.Forms.Label();
            this.lbsLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.BMIOutput = new System.Windows.Forms.Label();
            this.weightStatusOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appHeading
            // 
            this.appHeading.AutoSize = true;
            this.appHeading.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appHeading.Location = new System.Drawing.Point(1, 9);
            this.appHeading.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.appHeading.Name = "appHeading";
            this.appHeading.Padding = new System.Windows.Forms.Padding(15);
            this.appHeading.Size = new System.Drawing.Size(480, 59);
            this.appHeading.TabIndex = 0;
            this.appHeading.Text = "Calculate Your Body Mass Index (BMI)";
            this.appHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightFtTextBox
            // 
            this.heightFtTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.heightFtTextBox.Location = new System.Drawing.Point(19, 110);
            this.heightFtTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.heightFtTextBox.MinimumSize = new System.Drawing.Size(50, 35);
            this.heightFtTextBox.Name = "heightFtTextBox";
            this.heightFtTextBox.Size = new System.Drawing.Size(50, 35);
            this.heightFtTextBox.TabIndex = 1;
            this.heightFtTextBox.TextChanged += new System.EventHandler(this.heightFt_TextChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(16, 83);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 17);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height";
            // 
            // heightInTextBox
            // 
            this.heightInTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.heightInTextBox.Location = new System.Drawing.Point(126, 110);
            this.heightInTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.heightInTextBox.MinimumSize = new System.Drawing.Size(50, 35);
            this.heightInTextBox.Name = "heightInTextBox";
            this.heightInTextBox.Size = new System.Drawing.Size(50, 35);
            this.heightInTextBox.TabIndex = 2;
            // 
            // ftLabel
            // 
            this.ftLabel.AutoSize = true;
            this.ftLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.ftLabel.Location = new System.Drawing.Point(76, 119);
            this.ftLabel.Name = "ftLabel";
            this.ftLabel.Size = new System.Drawing.Size(28, 23);
            this.ftLabel.TabIndex = 4;
            this.ftLabel.Text = "ft.";
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.inLabel.Location = new System.Drawing.Point(183, 119);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(30, 23);
            this.inLabel.TabIndex = 5;
            this.inLabel.Text = "in.";
            // 
            // lbsLabel
            // 
            this.lbsLabel.AutoSize = true;
            this.lbsLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.lbsLabel.Location = new System.Drawing.Point(355, 119);
            this.lbsLabel.Name = "lbsLabel";
            this.lbsLabel.Size = new System.Drawing.Size(41, 23);
            this.lbsLabel.TabIndex = 8;
            this.lbsLabel.Text = "lbs.";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(270, 83);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(52, 17);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.weightTextBox.Location = new System.Drawing.Point(273, 110);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.weightTextBox.MinimumSize = new System.Drawing.Size(75, 35);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(75, 35);
            this.weightTextBox.TabIndex = 3;
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.computeButton.Enabled = false;
            this.computeButton.FlatAppearance.BorderSize = 0;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Arial", 12F);
            this.computeButton.Location = new System.Drawing.Point(19, 180);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(139, 54);
            this.computeButton.TabIndex = 9;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Arial", 12F);
            this.resetButton.Location = new System.Drawing.Point(183, 180);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(139, 54);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // BMIOutput
            // 
            this.BMIOutput.AutoSize = true;
            this.BMIOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.BMIOutput.Location = new System.Drawing.Point(15, 277);
            this.BMIOutput.Name = "BMIOutput";
            this.BMIOutput.Size = new System.Drawing.Size(0, 23);
            this.BMIOutput.TabIndex = 11;
            // 
            // weightStatusOutput
            // 
            this.weightStatusOutput.AutoSize = true;
            this.weightStatusOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.weightStatusOutput.Location = new System.Drawing.Point(15, 308);
            this.weightStatusOutput.Name = "weightStatusOutput";
            this.weightStatusOutput.Size = new System.Drawing.Size(0, 23);
            this.weightStatusOutput.TabIndex = 12;
            // 
            // BMIAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(482, 359);
            this.Controls.Add(this.weightStatusOutput);
            this.Controls.Add(this.BMIOutput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.lbsLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.ftLabel);
            this.Controls.Add(this.heightInTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightFtTextBox);
            this.Controls.Add(this.appHeading);
            this.Enabled = false;
            this.Name = "BMIAppForm";
            this.Text = "BMI App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appHeading;
        private System.Windows.Forms.TextBox heightFtTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInTextBox;
        private System.Windows.Forms.Label ftLabel;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label lbsLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label BMIOutput;
        private System.Windows.Forms.Label weightStatusOutput;
    }
}

