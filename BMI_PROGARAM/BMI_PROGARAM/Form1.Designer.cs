namespace BMI_PROGARAM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.bntclose = new System.Windows.Forms.Button();
            this.bntclear = new System.Windows.Forms.Button();
            this.txtbmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (m):";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(210, 47);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(237, 22);
            this.txtWeight.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(210, 105);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(237, 22);
            this.txtHeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 135);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(355, 278);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(108, 83);
            this.bntclose.TabIndex = 5;
            this.bntclose.Text = "&close";
            this.bntclose.UseVisualStyleBackColor = true;
            this.bntclose.Click += new System.EventHandler(this.bntclose_Click);
            // 
            // bntclear
            // 
            this.bntclear.Location = new System.Drawing.Point(210, 278);
            this.bntclear.Name = "bntclear";
            this.bntclear.Size = new System.Drawing.Size(108, 83);
            this.bntclear.TabIndex = 4;
            this.bntclear.Text = "&clear";
            this.bntclear.UseVisualStyleBackColor = true;
            this.bntclear.Click += new System.EventHandler(this.bntclear_Click);
            // 
            // txtbmi
            // 
            this.txtbmi.Location = new System.Drawing.Point(210, 155);
            this.txtbmi.Name = "txtbmi";
            this.txtbmi.Size = new System.Drawing.Size(237, 22);
            this.txtbmi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "BMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "RESELT";
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBMIResult.Location = new System.Drawing.Point(516, 133);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(256, 44);
            this.lblBMIResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBMIResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntclear);
            this.Controls.Add(this.bntclose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button bntclose;
        private System.Windows.Forms.Button bntclear;
        private System.Windows.Forms.TextBox txtbmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBMIResult;
    }
}

