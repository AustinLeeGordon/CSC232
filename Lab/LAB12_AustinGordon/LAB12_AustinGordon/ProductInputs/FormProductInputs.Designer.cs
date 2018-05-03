namespace ProductInputs
{
    partial class FormProductInputs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductInputs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSouth = new System.Windows.Forms.RadioButton();
            this.radioButtonNorth = new System.Windows.Forms.RadioButton();
            this.radioButtonWest = new System.Windows.Forms.RadioButton();
            this.radioButtonEast = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTruck = new System.Windows.Forms.RadioButton();
            this.radioButtonTrain = new System.Windows.Forms.RadioButton();
            this.listBoxColor = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxFragile = new System.Windows.Forms.CheckBox();
            this.checkBoxPerish = new System.Windows.Forms.CheckBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSalesTaxRate = new System.Windows.Forms.Label();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStateName = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT INPUTs FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Number (1-1000):";
            // 
            // textBoxProductNum
            // 
            this.textBoxProductNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNum.Location = new System.Drawing.Point(243, 85);
            this.textBoxProductNum.Name = "textBoxProductNum";
            this.textBoxProductNum.Size = new System.Drawing.Size(154, 23);
            this.textBoxProductNum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radioButtonSouth);
            this.groupBox1.Controls.Add(this.radioButtonNorth);
            this.groupBox1.Controls.Add(this.radioButtonWest);
            this.groupBox1.Controls.Add(this.radioButtonEast);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region of Origin";
            // 
            // radioButtonSouth
            // 
            this.radioButtonSouth.AutoSize = true;
            this.radioButtonSouth.Location = new System.Drawing.Point(27, 113);
            this.radioButtonSouth.Name = "radioButtonSouth";
            this.radioButtonSouth.Size = new System.Drawing.Size(68, 21);
            this.radioButtonSouth.TabIndex = 0;
            this.radioButtonSouth.TabStop = true;
            this.radioButtonSouth.Text = "South";
            this.radioButtonSouth.UseVisualStyleBackColor = true;
            // 
            // radioButtonNorth
            // 
            this.radioButtonNorth.AutoSize = true;
            this.radioButtonNorth.Location = new System.Drawing.Point(27, 86);
            this.radioButtonNorth.Name = "radioButtonNorth";
            this.radioButtonNorth.Size = new System.Drawing.Size(66, 21);
            this.radioButtonNorth.TabIndex = 0;
            this.radioButtonNorth.TabStop = true;
            this.radioButtonNorth.Text = "North";
            this.radioButtonNorth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWest
            // 
            this.radioButtonWest.AutoSize = true;
            this.radioButtonWest.Location = new System.Drawing.Point(27, 59);
            this.radioButtonWest.Name = "radioButtonWest";
            this.radioButtonWest.Size = new System.Drawing.Size(62, 21);
            this.radioButtonWest.TabIndex = 0;
            this.radioButtonWest.TabStop = true;
            this.radioButtonWest.Text = "West";
            this.radioButtonWest.UseVisualStyleBackColor = true;
            // 
            // radioButtonEast
            // 
            this.radioButtonEast.AutoSize = true;
            this.radioButtonEast.Location = new System.Drawing.Point(27, 32);
            this.radioButtonEast.Name = "radioButtonEast";
            this.radioButtonEast.Size = new System.Drawing.Size(58, 21);
            this.radioButtonEast.TabIndex = 0;
            this.radioButtonEast.TabStop = true;
            this.radioButtonEast.Text = "East";
            this.radioButtonEast.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.radioButtonTruck);
            this.groupBox2.Controls.Add(this.radioButtonTrain);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(178, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping Method";
            // 
            // radioButtonTruck
            // 
            this.radioButtonTruck.AutoSize = true;
            this.radioButtonTruck.Location = new System.Drawing.Point(22, 52);
            this.radioButtonTruck.Name = "radioButtonTruck";
            this.radioButtonTruck.Size = new System.Drawing.Size(67, 21);
            this.radioButtonTruck.TabIndex = 0;
            this.radioButtonTruck.TabStop = true;
            this.radioButtonTruck.Text = "Truck";
            this.radioButtonTruck.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrain
            // 
            this.radioButtonTrain.AutoSize = true;
            this.radioButtonTrain.Location = new System.Drawing.Point(22, 28);
            this.radioButtonTrain.Name = "radioButtonTrain";
            this.radioButtonTrain.Size = new System.Drawing.Size(64, 21);
            this.radioButtonTrain.TabIndex = 0;
            this.radioButtonTrain.TabStop = true;
            this.radioButtonTrain.Text = "Train";
            this.radioButtonTrain.UseVisualStyleBackColor = true;
            // 
            // listBoxColor
            // 
            this.listBoxColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColor.FormattingEnabled = true;
            this.listBoxColor.ItemHeight = 16;
            this.listBoxColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "White"});
            this.listBoxColor.Location = new System.Drawing.Point(179, 274);
            this.listBoxColor.Name = "listBoxColor";
            this.listBoxColor.Size = new System.Drawing.Size(120, 84);
            this.listBoxColor.Sorted = true;
            this.listBoxColor.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.checkBoxFragile);
            this.groupBox3.Controls.Add(this.checkBoxPerish);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 62);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // checkBoxFragile
            // 
            this.checkBoxFragile.AutoSize = true;
            this.checkBoxFragile.Location = new System.Drawing.Point(201, 39);
            this.checkBoxFragile.Name = "checkBoxFragile";
            this.checkBoxFragile.Size = new System.Drawing.Size(77, 21);
            this.checkBoxFragile.TabIndex = 0;
            this.checkBoxFragile.Text = "Fragile";
            this.checkBoxFragile.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerish
            // 
            this.checkBoxPerish.AutoSize = true;
            this.checkBoxPerish.Location = new System.Drawing.Point(16, 39);
            this.checkBoxPerish.Name = "checkBoxPerish";
            this.checkBoxPerish.Size = new System.Drawing.Size(104, 21);
            this.checkBoxPerish.TabIndex = 0;
            this.checkBoxPerish.Text = "Perishable";
            this.checkBoxPerish.UseVisualStyleBackColor = true;
            // 
            // comboBoxState
            // 
            this.comboBoxState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(364, 150);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(140, 24);
            this.comboBoxState.TabIndex = 7;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ship to State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sales Tax Rate (%):";
            // 
            // labelSalesTaxRate
            // 
            this.labelSalesTaxRate.AutoSize = true;
            this.labelSalesTaxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelSalesTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesTaxRate.Location = new System.Drawing.Point(527, 195);
            this.labelSalesTaxRate.Name = "labelSalesTaxRate";
            this.labelSalesTaxRate.Size = new System.Drawing.Size(43, 17);
            this.labelSalesTaxRate.TabIndex = 10;
            this.labelSalesTaxRate.Text = "label";
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOK.Image")));
            this.pictureBoxOK.Location = new System.Drawing.Point(427, 309);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(122, 37);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 11;
            this.pictureBoxOK.TabStop = false;
            this.pictureBoxOK.Click += new System.EventHandler(this.pictureBoxOK_Click);
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.Image = global::ProductInputs.Properties.Resources.cancel;
            this.pictureBoxCancel.Location = new System.Drawing.Point(427, 397);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(122, 37);
            this.pictureBoxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCancel.TabIndex = 12;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Click += new System.EventHandler(this.pictureBoxCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Color:";
            // 
            // labelStateName
            // 
            this.labelStateName.AutoSize = true;
            this.labelStateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelStateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStateName.Location = new System.Drawing.Point(510, 151);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(39, 15);
            this.labelStateName.TabIndex = 14;
            this.labelStateName.Text = "label";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(427, 353);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(122, 37);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FormProductInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(602, 495);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.labelStateName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxCancel);
            this.Controls.Add(this.pictureBoxOK);
            this.Controls.Add(this.labelSalesTaxRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBoxColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxProductNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductInputs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Inputs";
            this.Load += new System.EventHandler(this.FormProductInputs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSouth;
        private System.Windows.Forms.RadioButton radioButtonNorth;
        private System.Windows.Forms.RadioButton radioButtonWest;
        private System.Windows.Forms.RadioButton radioButtonEast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTruck;
        private System.Windows.Forms.RadioButton radioButtonTrain;
        private System.Windows.Forms.ListBox listBoxColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxFragile;
        private System.Windows.Forms.CheckBox checkBoxPerish;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSalesTaxRate;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.PictureBox pictureBoxCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStateName;
        private System.Windows.Forms.Button resetButton;
    }
}

