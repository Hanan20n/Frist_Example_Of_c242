namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guji = new System.Windows.Forms.Label();
            this.bntone = new System.Windows.Forms.Button();
            this.txtone = new System.Windows.Forms.TextBox();
            this.txbtwo = new System.Windows.Forms.TextBox();
            this.picone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picone)).BeginInit();
            this.SuspendLayout();
            // 
            // guji
            // 
            this.guji.AutoSize = true;
            this.guji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.guji.Location = new System.Drawing.Point(56, 143);
            this.guji.Name = "guji";
            this.guji.Size = new System.Drawing.Size(205, 16);
            this.guji.TabIndex = 0;
            this.guji.Text = "                                                                  \r\n";
            // 
            // bntone
            // 
            this.bntone.Location = new System.Drawing.Point(106, 181);
            this.bntone.Name = "bntone";
            this.bntone.Size = new System.Drawing.Size(75, 55);
            this.bntone.TabIndex = 1;
            this.bntone.Text = "button1";
            this.bntone.UseVisualStyleBackColor = true;
            this.bntone.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtone
            // 
            this.txtone.Location = new System.Drawing.Point(59, 39);
            this.txtone.Name = "txtone";
            this.txtone.Size = new System.Drawing.Size(184, 22);
            this.txtone.TabIndex = 2;
            this.txtone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbtwo
            // 
            this.txbtwo.Location = new System.Drawing.Point(59, 87);
            this.txbtwo.Name = "txbtwo";
            this.txbtwo.Size = new System.Drawing.Size(184, 22);
            this.txbtwo.TabIndex = 3;
            // 
            // picone
            // 
            this.picone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picone.Image = ((System.Drawing.Image)(resources.GetObject("picone.Image")));
            this.picone.Location = new System.Drawing.Point(357, 27);
            this.picone.Name = "picone";
            this.picone.Size = new System.Drawing.Size(275, 357);
            this.picone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picone.TabIndex = 4;
            this.picone.TabStop = false;
            this.picone.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picone);
            this.Controls.Add(this.txbtwo);
            this.Controls.Add(this.txtone);
            this.Controls.Add(this.bntone);
            this.Controls.Add(this.guji);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guji;
        private System.Windows.Forms.Button bntone;
        private System.Windows.Forms.TextBox txtone;
        private System.Windows.Forms.TextBox txbtwo;
        private System.Windows.Forms.PictureBox picone;
    }
}

