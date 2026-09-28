namespace Test_Score_Applicaation
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
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblavrg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(206, 198);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(287, 57);
            this.btnCalculateAverage.TabIndex = 0;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(361, 38);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(245, 22);
            this.txtScore1.TabIndex = 1;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(361, 81);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(245, 22);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(361, 132);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(245, 22);
            this.txtScore3.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(300, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(259, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "total";
            // 
            // lblavrg
            // 
            this.lblavrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblavrg.Location = new System.Drawing.Point(300, 338);
            this.lblavrg.Name = "lblavrg";
            this.lblavrg.Size = new System.Drawing.Size(203, 16);
            this.lblavrg.TabIndex = 5;
            this.lblavrg.Text = "avrage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblavrg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.btnCalculateAverage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblavrg;
    }
}

