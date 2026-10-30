namespace ASSEGMENTONE
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemestter = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepertment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.showinformation = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(208, 95);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(142, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "ENTER Student Name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(208, 165);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(118, 16);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "ENTER Student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(208, 219);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(127, 16);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "ENTER Department";
            // 
            // lblsemestter
            // 
            this.lblsemestter.AutoSize = true;
            this.lblsemestter.Location = new System.Drawing.Point(208, 280);
            this.lblsemestter.Name = "lblsemestter";
            this.lblsemestter.Size = new System.Drawing.Size(115, 16);
            this.lblsemestter.TabIndex = 3;
            this.lblsemestter.Text = "ENTER Semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(613, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(256, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(613, 165);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(256, 22);
            this.txtstudentid.TabIndex = 5;
            // 
            // txtdepertment
            // 
            this.txtdepertment.Location = new System.Drawing.Point(613, 213);
            this.txtdepertment.Name = "txtdepertment";
            this.txtdepertment.Size = new System.Drawing.Size(256, 22);
            this.txtdepertment.TabIndex = 6;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(613, 280);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(256, 22);
            this.txtsemester.TabIndex = 7;
            // 
            // showinformation
            // 
            this.showinformation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.showinformation.Location = new System.Drawing.Point(440, 414);
            this.showinformation.Name = "showinformation";
            this.showinformation.Size = new System.Drawing.Size(165, 85);
            this.showinformation.TabIndex = 8;
            this.showinformation.Text = "show information";
            this.showinformation.UseVisualStyleBackColor = false;
            this.showinformation.Click += new System.EventHandler(this.showinformation_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear.Location = new System.Drawing.Point(765, 414);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 85);
            this.clear.TabIndex = 9;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(149, 337);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(720, 74);
            this.lbloutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 548);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showinformation);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepertment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemestter);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemestter;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepertment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button showinformation;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label lbloutput;
    }
}

