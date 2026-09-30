namespace tip_tax_and_total
{
    partial class txtFood
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
            this.txtwater = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalculute = new System.Windows.Forms.Button();
            this.lblreaselt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtwater
            // 
            this.txtwater.Location = new System.Drawing.Point(458, 51);
            this.txtwater.Name = "txtwater";
            this.txtwater.Size = new System.Drawing.Size(224, 22);
            this.txtwater.TabIndex = 0;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(458, 109);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(224, 22);
            this.txtPrice1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(458, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(458, 216);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(224, 22);
            this.txtPrice2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the water";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the amont";
            // 
            // btncalculute
            // 
            this.btncalculute.Location = new System.Drawing.Point(300, 256);
            this.btncalculute.Name = "btncalculute";
            this.btncalculute.Size = new System.Drawing.Size(189, 59);
            this.btncalculute.TabIndex = 8;
            this.btncalculute.Text = "calculute";
            this.btncalculute.UseVisualStyleBackColor = true;
            this.btncalculute.Click += new System.EventHandler(this.btncalculute_Click_1);
            // 
            // lblreaselt
            // 
            this.lblreaselt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblreaselt.Location = new System.Drawing.Point(255, 345);
            this.lblreaselt.Name = "lblreaselt";
            this.lblreaselt.Size = new System.Drawing.Size(255, 23);
            this.lblreaselt.TabIndex = 9;
            this.lblreaselt.Text = "reselt";
            // 
            // txtFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblreaselt);
            this.Controls.Add(this.btncalculute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.txtwater);
            this.Name = "txtFood";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwater;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalculute;
        private System.Windows.Forms.Label lblreaselt;
    }
}

