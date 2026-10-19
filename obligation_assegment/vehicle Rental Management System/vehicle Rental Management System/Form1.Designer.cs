namespace vehicle_Rental_Management_System
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLuxury = new System.Windows.Forms.RadioButton();
            this.rbSUV = new System.Windows.Forms.RadioButton();
            this.rbEconomy = new System.Windows.Forms.RadioButton();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.txtDrivingExperience = new System.Windows.Forms.TextBox();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 579);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 99);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 579);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 99);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 99);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkinsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 76);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance  Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Location = new System.Drawing.Point(22, 37);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(310, 29);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance ($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLuxury);
            this.groupBox2.Controls.Add(this.rbSUV);
            this.groupBox2.Controls.Add(this.rbEconomy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Type";
            // 
            // rbLuxury
            // 
            this.rbLuxury.AutoSize = true;
            this.rbLuxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLuxury.Location = new System.Drawing.Point(321, 52);
            this.rbLuxury.Name = "rbLuxury";
            this.rbLuxury.Size = new System.Drawing.Size(86, 24);
            this.rbLuxury.TabIndex = 9;
            this.rbLuxury.TabStop = true;
            this.rbLuxury.Text = "Luxury";
            this.rbLuxury.UseVisualStyleBackColor = true;
            // 
            // rbSUV
            // 
            this.rbSUV.AutoSize = true;
            this.rbSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSUV.Location = new System.Drawing.Point(159, 52);
            this.rbSUV.Name = "rbSUV";
            this.rbSUV.Size = new System.Drawing.Size(67, 24);
            this.rbSUV.TabIndex = 8;
            this.rbSUV.TabStop = true;
            this.rbSUV.Text = "SUV";
            this.rbSUV.UseVisualStyleBackColor = true;
            // 
            // rbEconomy
            // 
            this.rbEconomy.AutoSize = true;
            this.rbEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEconomy.Location = new System.Drawing.Point(6, 52);
            this.rbEconomy.Name = "rbEconomy";
            this.rbEconomy.Size = new System.Drawing.Size(106, 24);
            this.rbEconomy.TabIndex = 7;
            this.rbEconomy.TabStop = true;
            this.rbEconomy.Text = "Economy";
            this.rbEconomy.UseVisualStyleBackColor = true;
            // 
            // lstresults
            // 
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 16;
            this.lstresults.Items.AddRange(new object[] {
            "Rental Details"});
            this.lstresults.Location = new System.Drawing.Point(686, 2);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(322, 564);
            this.lstresults.TabIndex = 22;
            // 
            // txtDrivingExperience
            // 
            this.txtDrivingExperience.Location = new System.Drawing.Point(356, 186);
            this.txtDrivingExperience.Name = "txtDrivingExperience";
            this.txtDrivingExperience.Size = new System.Drawing.Size(167, 30);
            this.txtDrivingExperience.TabIndex = 3;
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(356, 137);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(167, 30);
            this.txtRentalDays.TabIndex = 2;
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Location = new System.Drawing.Point(356, 93);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(167, 30);
            this.txtCustomerAge.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(356, 37);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(167, 30);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "year of driveing expereince:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Rental day:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Age:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRentalDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDrivingExperience);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomerAge);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 260);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custemer Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 763);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLuxury;
        private System.Windows.Forms.RadioButton rbSUV;
        private System.Windows.Forms.RadioButton rbEconomy;
        private System.Windows.Forms.ListBox lstresults;
        private System.Windows.Forms.TextBox txtDrivingExperience;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

