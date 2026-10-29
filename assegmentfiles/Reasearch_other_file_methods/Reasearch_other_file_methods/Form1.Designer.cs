namespace Reasearch_other_file_methods
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
            this.btnReadwithStreamReader = new System.Windows.Forms.Button();
            this.btnreadall = new System.Windows.Forms.Button();
            this.btn_readlines = new System.Windows.Forms.Button();
            this.btn_deleteitem = new System.Windows.Forms.Button();
            this.btndeleteentirefile = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadwithStreamReader
            // 
            this.btnReadwithStreamReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadwithStreamReader.Location = new System.Drawing.Point(9, 192);
            this.btnReadwithStreamReader.Name = "btnReadwithStreamReader";
            this.btnReadwithStreamReader.Size = new System.Drawing.Size(359, 144);
            this.btnReadwithStreamReader.TabIndex = 0;
            this.btnReadwithStreamReader.Text = "Read with StreamReader";
            this.btnReadwithStreamReader.UseVisualStyleBackColor = true;
            this.btnReadwithStreamReader.Click += new System.EventHandler(this.btnReadwithStreamReader_Click);
            // 
            // btnreadall
            // 
            this.btnreadall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadall.Location = new System.Drawing.Point(398, 192);
            this.btnreadall.Name = "btnreadall";
            this.btnreadall.Size = new System.Drawing.Size(359, 144);
            this.btnreadall.TabIndex = 1;
            this.btnreadall.Text = "ReadAllLines()";
            this.btnreadall.UseVisualStyleBackColor = true;
            this.btnreadall.Click += new System.EventHandler(this.btnreadall_Click);
            // 
            // btn_readlines
            // 
            this.btn_readlines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readlines.Location = new System.Drawing.Point(9, 342);
            this.btn_readlines.Name = "btn_readlines";
            this.btn_readlines.Size = new System.Drawing.Size(359, 144);
            this.btn_readlines.TabIndex = 2;
            this.btn_readlines.Text = "ReadLines()";
            this.btn_readlines.UseVisualStyleBackColor = true;
            this.btn_readlines.Click += new System.EventHandler(this.btn_readlines_Click);
            // 
            // btn_deleteitem
            // 
            this.btn_deleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitem.Location = new System.Drawing.Point(398, 342);
            this.btn_deleteitem.Name = "btn_deleteitem";
            this.btn_deleteitem.Size = new System.Drawing.Size(359, 144);
            this.btn_deleteitem.TabIndex = 3;
            this.btn_deleteitem.Text = "Delete Selected Item";
            this.btn_deleteitem.UseVisualStyleBackColor = true;
            this.btn_deleteitem.Click += new System.EventHandler(this.btn_deleteitem_Click);
            // 
            // btndeleteentirefile
            // 
            this.btndeleteentirefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteentirefile.Location = new System.Drawing.Point(9, 515);
            this.btndeleteentirefile.Name = "btndeleteentirefile";
            this.btndeleteentirefile.Size = new System.Drawing.Size(748, 92);
            this.btndeleteentirefile.TabIndex = 4;
            this.btndeleteentirefile.Text = "Delete Entire File";
            this.btndeleteentirefile.UseVisualStyleBackColor = true;
            this.btndeleteentirefile.Click += new System.EventHandler(this.btndeleteentirefile_Click);
            // 
            // lst
            // 
            this.lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 25;
            this.lst.Items.AddRange(new object[] {
            "\tlistBox_items_from_thefile"});
            this.lst.Location = new System.Drawing.Point(51, 34);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(638, 129);
            this.lst.TabIndex = 5;
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteToFile.Location = new System.Drawing.Point(747, 63);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(68, 60);
            this.btnWriteToFile.TabIndex = 6;
            this.btnWriteToFile.Text = "WriteToFile";
            this.btnWriteToFile.UseVisualStyleBackColor = false;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 640);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btndeleteentirefile);
            this.Controls.Add(this.btn_deleteitem);
            this.Controls.Add(this.btn_readlines);
            this.Controls.Add(this.btnreadall);
            this.Controls.Add(this.btnReadwithStreamReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadwithStreamReader;
        private System.Windows.Forms.Button btnreadall;
        private System.Windows.Forms.Button btn_readlines;
        private System.Windows.Forms.Button btn_deleteitem;
        private System.Windows.Forms.Button btndeleteentirefile;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnWriteToFile;
    }
}

