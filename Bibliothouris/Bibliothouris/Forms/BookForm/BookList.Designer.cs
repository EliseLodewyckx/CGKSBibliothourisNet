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
            this.bookListView = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddBook = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author});
            this.bookListView.Location = new System.Drawing.Point(12, 12);
            this.bookListView.MultiSelect = false;
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(1260, 455);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            this.bookListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bookListView_MouseDoubleClick);
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 154;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 252;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 356;
            // 
            // btAddBook
            // 
            this.btAddBook.Location = new System.Drawing.Point(12, 473);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(97, 32);
            this.btAddBook.TabIndex = 1;
            this.btAddBook.Text = "Add books";
            this.btAddBook.UseVisualStyleBackColor = true;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1175, 473);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(97, 32);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1072, 473);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 32);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Visible = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAddBook);
            this.Controls.Add(this.bookListView);
            this.Name = "BookList";
            this.Text = "BookList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btClear;
    }
}