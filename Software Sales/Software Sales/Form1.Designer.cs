namespace Software_Sales
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
            this.txtPackages = new System.Windows.Forms.TextBox();
            this.txtpriceperpackage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btncleare = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPackages
            // 
            this.txtPackages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackages.Location = new System.Drawing.Point(299, 40);
            this.txtPackages.Name = "txtPackages";
            this.txtPackages.Size = new System.Drawing.Size(269, 22);
            this.txtPackages.TabIndex = 0;
            // 
            // txtpriceperpackage
            // 
            this.txtpriceperpackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpriceperpackage.Location = new System.Drawing.Point(299, 107);
            this.txtpriceperpackage.Name = "txtpriceperpackage";
            this.txtpriceperpackage.Size = new System.Drawing.Size(269, 22);
            this.txtpriceperpackage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Package :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price Per Package :";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(12, 236);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(139, 139);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "&calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btncleare
            // 
            this.btncleare.Location = new System.Drawing.Point(209, 265);
            this.btncleare.Name = "btncleare";
            this.btncleare.Size = new System.Drawing.Size(75, 81);
            this.btncleare.TabIndex = 3;
            this.btncleare.Text = "&clear";
            this.btncleare.UseVisualStyleBackColor = true;
            this.btncleare.Click += new System.EventHandler(this.btncleare_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(347, 265);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 81);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Items.AddRange(new object[] {
            "Softwer sales Result"});
            this.lstResults.Location = new System.Drawing.Point(623, 25);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(367, 340);
            this.lstResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncleare);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpriceperpackage);
            this.Controls.Add(this.txtPackages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPackages;
        private System.Windows.Forms.TextBox txtpriceperpackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btncleare;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstResults;
    }
}

