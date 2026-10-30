namespace home_assegment
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
            this.lblnameoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblNumaricMonth = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtdayweek = new System.Windows.Forms.TextBox();
            this.txtnamemonth = new System.Windows.Forms.TextBox();
            this.txtnumaricofmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnameoftheweek
            // 
            this.lblnameoftheweek.AutoSize = true;
            this.lblnameoftheweek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameoftheweek.Location = new System.Drawing.Point(149, 35);
            this.lblnameoftheweek.Name = "lblnameoftheweek";
            this.lblnameoftheweek.Size = new System.Drawing.Size(205, 23);
            this.lblnameoftheweek.TabIndex = 0;
            this.lblnameoftheweek.Text = "Enter Day of the Week";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(160, 89);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(194, 23);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter Name of Month";
            // 
            // lblNumaricMonth
            // 
            this.lblNumaricMonth.AutoSize = true;
            this.lblNumaricMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumaricMonth.Location = new System.Drawing.Point(62, 153);
            this.lblNumaricMonth.Name = "lblNumaricMonth";
            this.lblNumaricMonth.Size = new System.Drawing.Size(292, 23);
            this.lblNumaricMonth.TabIndex = 2;
            this.lblNumaricMonth.Text = "Enter The Numeric of The Month";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(215, 211);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(139, 23);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter The year";
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(77, 266);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(556, 71);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.Text = "                                                                                 " +
    "         ";
            // 
            // txtdayweek
            // 
            this.txtdayweek.Location = new System.Drawing.Point(385, 32);
            this.txtdayweek.Name = "txtdayweek";
            this.txtdayweek.Size = new System.Drawing.Size(273, 22);
            this.txtdayweek.TabIndex = 5;
            // 
            // txtnamemonth
            // 
            this.txtnamemonth.Location = new System.Drawing.Point(385, 77);
            this.txtnamemonth.Name = "txtnamemonth";
            this.txtnamemonth.Size = new System.Drawing.Size(273, 22);
            this.txtnamemonth.TabIndex = 6;
            // 
            // txtnumaricofmonth
            // 
            this.txtnumaricofmonth.Location = new System.Drawing.Point(385, 152);
            this.txtnumaricofmonth.Name = "txtnumaricofmonth";
            this.txtnumaricofmonth.Size = new System.Drawing.Size(273, 22);
            this.txtnumaricofmonth.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(385, 210);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(273, 22);
            this.txtyear.TabIndex = 8;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(143, 364);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(118, 79);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "show Data";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(318, 364);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 79);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(502, 364);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(118, 79);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 620);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumaricofmonth);
            this.Controls.Add(this.txtnamemonth);
            this.Controls.Add(this.txtdayweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblNumaricMonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lblnameoftheweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnameoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblNumaricMonth;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtdayweek;
        private System.Windows.Forms.TextBox txtnamemonth;
        private System.Windows.Forms.TextBox txtnumaricofmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

