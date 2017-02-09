namespace Bibliothouris.Forms.BookForm
{
    partial class BookList
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
            this.SearchBookByISBN = new System.Windows.Forms.Label();
            this.txtSearchByIsbn = new System.Windows.Forms.TextBox();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.lblSearchByAuthor = new System.Windows.Forms.Label();
            this.txtSearchByAuthor = new System.Windows.Forms.TextBox();
            this.txtSearchByTitle = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBookByISBN
            // 
            this.SearchBookByISBN.AutoSize = true;
            this.SearchBookByISBN.Location = new System.Drawing.Point(12, 9);
            this.SearchBookByISBN.Name = "SearchBookByISBN";
            this.SearchBookByISBN.Size = new System.Drawing.Size(77, 13);
            this.SearchBookByISBN.TabIndex = 0;
            this.SearchBookByISBN.Text = "Search by isbn";
            this.SearchBookByISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearchByIsbn
            // 
            this.txtSearchByIsbn.Location = new System.Drawing.Point(15, 25);
            this.txtSearchByIsbn.Name = "txtSearchByIsbn";
            this.txtSearchByIsbn.Size = new System.Drawing.Size(251, 20);
            this.txtSearchByIsbn.TabIndex = 1;
            this.txtSearchByIsbn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.Location = new System.Drawing.Point(12, 58);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(74, 13);
            this.lblSearchByTitle.TabIndex = 2;
            this.lblSearchByTitle.Text = "Search by title";
            // 
            // lblSearchByAuthor
            // 
            this.lblSearchByAuthor.AutoSize = true;
            this.lblSearchByAuthor.Location = new System.Drawing.Point(12, 108);
            this.lblSearchByAuthor.Name = "lblSearchByAuthor";
            this.lblSearchByAuthor.Size = new System.Drawing.Size(88, 13);
            this.lblSearchByAuthor.TabIndex = 3;
            this.lblSearchByAuthor.Text = "Search by author";
            // 
            // txtSearchByAuthor
            // 
            this.txtSearchByAuthor.Location = new System.Drawing.Point(15, 133);
            this.txtSearchByAuthor.Name = "txtSearchByAuthor";
            this.txtSearchByAuthor.Size = new System.Drawing.Size(251, 20);
            this.txtSearchByAuthor.TabIndex = 4;
            this.txtSearchByAuthor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSearchByTitle
            // 
            this.txtSearchByTitle.Location = new System.Drawing.Point(15, 74);
            this.txtSearchByTitle.Name = "txtSearchByTitle";
            this.txtSearchByTitle.Size = new System.Drawing.Size(251, 20);
            this.txtSearchByTitle.TabIndex = 5;
            this.txtSearchByTitle.TextChanged += new System.EventHandler(this.txtSearchByTitle_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSearch.Location = new System.Drawing.Point(15, 177);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(122, 67);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Search>>";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 534);
            this.Controls.Add(this.txtSearchByIsbn);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearchByTitle);
            this.Controls.Add(this.txtSearchByAuthor);
            this.Controls.Add(this.lblSearchByAuthor);
            this.Controls.Add(this.lblSearchByTitle);
            this.Controls.Add(this.SearchBookByISBN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchBookByISBN;
        private System.Windows.Forms.TextBox txtSearchByIsbn;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.Label lblSearchByAuthor;
        private System.Windows.Forms.TextBox txtSearchByAuthor;
        private System.Windows.Forms.TextBox txtSearchByTitle;
        private System.Windows.Forms.Button btSearch;
    }
}