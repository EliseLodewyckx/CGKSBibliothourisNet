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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddBook = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1260, 455);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1175, 473);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(97, 32);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
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
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAddBook);
            this.Controls.Add(this.listView1);
            this.Name = "BookList";
            this.Text = "BookList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btClear;
    }
}