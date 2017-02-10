namespace Bibliothouris.Forms.BookForm
{
    partial class SearchBooks
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
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearchISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(107, 88);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(196, 20);
            this.txtSearchLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 13);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Author Last Name";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(107, 36);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(196, 20);
            this.txtSearchTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(107, 62);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(196, 20);
            this.txtSearchFirstName.TabIndex = 2;
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(10, 65);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(91, 13);
            this.lblAuthorFirstName.TabIndex = 13;
            this.lblAuthorFirstName.Text = "Author First Name";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(13, 119);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearchISBN
            // 
            this.txtSearchISBN.Location = new System.Drawing.Point(107, 10);
            this.txtSearchISBN.Name = "txtSearchISBN";
            this.txtSearchISBN.Size = new System.Drawing.Size(196, 20);
            this.txtSearchISBN.TabIndex = 0;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(10, 12);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN";
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 171);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearchISBN);
            this.Controls.Add(this.lblISBN);
            this.Name = "SearchBooks";
            this.Text = "SearchBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearchISBN;
        private System.Windows.Forms.Label lblISBN;
    }
}