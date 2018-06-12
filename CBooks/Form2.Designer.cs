namespace CBooks
{
    partial class Form2
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
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookDescription = new System.Windows.Forms.TextBox();
            this.saveBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(53, 49);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(258, 20);
            this.bookName.TabIndex = 0;
            // 
            // bookDescription
            // 
            this.bookDescription.Location = new System.Drawing.Point(53, 104);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(258, 20);
            this.bookDescription.TabIndex = 1;
            // 
            // saveBook
            // 
            this.saveBook.Location = new System.Drawing.Point(53, 150);
            this.saveBook.Name = "saveBook";
            this.saveBook.Size = new System.Drawing.Size(117, 23);
            this.saveBook.TabIndex = 2;
            this.saveBook.Text = "Save Book";
            this.saveBook.UseVisualStyleBackColor = true;
            this.saveBook.Click += new System.EventHandler(this.saveBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Description";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBook);
            this.Controls.Add(this.bookDescription);
            this.Controls.Add(this.bookName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox bookDescription;
        private System.Windows.Forms.Button saveBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}